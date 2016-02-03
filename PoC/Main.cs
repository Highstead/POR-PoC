using CefSharp;
using CefSharp.WinForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace PoR.PoC
{
    public partial class Main : Form
    {
        private ChromiumWebBrowser Browser = null;
        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public Main()
        {
            InitializeComponent();

            var settings = new CefSettings();
           
            /*var settings = new CefSettings();
            settings.RegisterScheme(new CefCustomScheme()
            {
                SchemeName = SchemeFactory.SchemeName,
                SchemeHandlerFactory = new SchemeFactory()
            });*/
            Cef.Initialize(settings);
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
            this.pnlWebBrowser.Controls.Add(Browser);
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


        private string convertToChromePath(string path)
        {
            var output = "file:///";
            output += path.Replace("\\", "/");
            return output;
        }
    }
}
