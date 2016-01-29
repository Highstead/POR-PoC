using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PoR.PoC
{
    public partial class Main : Form
    {
        private ChromiumWebBrowser m_chromeBrowser = null;

        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public Main()
        {
            InitializeComponent();
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
            Cef.Initialize();
            var myBrowser = new ChromiumWebBrowser("http://www.maps.google.com");
            this.pnlWebBrowser.Controls.Add(myBrowser);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var page = string.Format("{0}wwwroot\\html\\addUser.html", GetAppLocation());
            using (var fs = new FileStream(page, FileMode.Open))
            {
                var fsByte = fs.ReadByte();
            }
            m_chromeBrowser.Load(page);
        }

        private void listUser_Click(object sender, EventArgs e)
        {
            var page = string.Format("{0}wwwroot\\html\\listUsers.html", GetAppLocation());
            m_chromeBrowser.Load(page);
        }
    }
}
