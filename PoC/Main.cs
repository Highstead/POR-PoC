using CefSharp;
using CefSharp.WinForms;
using System;
using System.IO;
using System.Windows.Forms;
using PoR.Logic.BL;

namespace PoR.PoC
{
    public partial class Main : Form
    {
        private int UserCount = 0;

        private ChromiumWebBrowser Browser = null;
        private JavascriptCallbackObject jsObj = null;

        private ItemBL _itemBl = null;

        private delegate void SetUserCountTextCallback(string text);

        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public Main()
        {
            InitializeComponent();
            _itemBl = new ItemBL();
            UserCount = _itemBl.GetItemCount();
            UpdateUserCountLabel(UserCount);

            var settings = new CefSettings();
            Cef.Initialize(settings);

            jsObj = new JavascriptCallbackObject();
            jsObj.UserCount = UserCount;
            jsObj.UserCountCallback = UpdateUserCountLabel;

            // Handlers
            Load += MainForm_Load;
            Closing += MainForm_Closing;
            this.btnAddUser.Click += addUser_Click;
            this.btnListUsers.Click += listUser_Click;
        }

        void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Cef.Shutdown();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            var page = string.Format("{0}wwwroot\\html\\index.html", GetAppLocation());
            var outpath = convertToChromePath(page);
            Browser = new ChromiumWebBrowser(outpath);
            Browser.RegisterJsObject("winformObj", jsObj);
            jsObj.Browser = Browser;

            this.pnlWebBrowser.Controls.Add(Browser);
            // Dev tools option purely for debugging.
            ChromeDevToolsSystemMenu.CreateSysMenu(this);
        }

        /// <summary>
        /// Adding dev tools for debug purposes.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Test if the About item was selected from the system menu
            if ((m.Msg == ChromeDevToolsSystemMenu.WM_SYSCOMMAND) && ((int)m.WParam == ChromeDevToolsSystemMenu.SYSMENU_CHROME_DEV_TOOLS))
            {
                Browser.ShowDevTools();
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var page = string.Format("{0}wwwroot\\html\\addItem.html", GetAppLocation());
            var outpath = convertToChromePath(page);
            Browser.Load(outpath);
        }

        
        private void listUser_Click(object sender, EventArgs e)
        {
            var page = string.Format("{0}wwwroot\\html\\listItems.html", GetAppLocation());
            var outpath = convertToChromePath(page);
            Browser.Load(outpath);
        }

        /// <summary>
        /// Fixes an issue caused by the 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string convertToChromePath(string path)
        {
            var output = "file:///";
            output += path.Replace("\\", "/");
            return output;
        }

        public void UpdateUserCountLabel(int count)
        {
            SetUserCountText("" + count);
            UserCount = count;
        }

        private void SetUserCountText(string text)
        {
            if (this.lblUserCountVal.InvokeRequired)
            {
                SetUserCountTextCallback d = new SetUserCountTextCallback(SetUserCountText);
                this.Invoke(d, new object[] {text});
            }
            else
            {
                this.lblUserCountVal.Text = text;
            }
        }
    }
}
