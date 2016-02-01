using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;

namespace PoR.PoC
{
    public class SchemeFactory : ISchemeHandlerFactory
    {
        public static string SchemeName {
            get { return "Por.Poc";  } 
        }

        public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
