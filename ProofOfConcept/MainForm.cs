using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using PoR.ProofOfConcept;

namespace ProofOfConcept
{
    public partial class Form1 : Form
    {
        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public Form1()
        {
            var settings = new CefSettings();
            settings.RegisterScheme(new CefCustomScheme()
            {
                SchemeName = SchemeFactory.SchemeName,
                SchemeHandlerFactory = new SchemeFactory()
            });
            Cef.Initialize(settings);
            InitializeComponent();
        }
    }
}
