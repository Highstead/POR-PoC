using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

namespace PoR.PoC
{
    /// <summary>
    /// All of the functions we want to expose to the javascript callbacks to allow them to 
    /// communicate with the c# application.
    /// </summary>
    public class JavascriptCallbackObject
    {
        public delegate void IncrementCallback(int count);

        [JavascriptIgnore]
        public IncrementCallback UserCountCallback { get; set; }

        [JavascriptIgnore]
        public ChromiumWebBrowser Browser { get; set; }

        public int UserCount { get; set; }


        public JavascriptCallbackObject()
        {
            UserCount = 0;
        }

        public string SuccessAdd()
        {
            UserCount++;
            UserCountCallback(UserCount);
            return "" + UserCount;
        }

    }
}
