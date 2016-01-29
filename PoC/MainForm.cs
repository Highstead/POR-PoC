using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace PoR.PoC
{
    public partial class MainForm : Form
    {
        ChromiumWebBrowser m_chromeBrowser = null;

        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
            Closing += MainForm_Closing;
            this.AddButton.Click += addUser_Click;
            this.ListUserButton.Click += listUser_Click;
        }

        void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Cef.Shutdown();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            Cef.Initialize();
            var myBrowser = new ChromiumWebBrowser("http://www.maps.google.com");
            this.WebBrowser.Controls.Add(myBrowser);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            /*
            var page = string.Format("{0}wwwroot/html/addUser.html", GetAppLocation());
            m_chromeBrowser.Load(page);
            */
        }

        private void listUser_Click(object sender, EventArgs e)
        {
            /*
            var page = string.Format("{0}wwwroot/html/listUsers.html", GetAppLocation());
            m_chromeBrowser.Load(page);
            */
        }
    }
}
