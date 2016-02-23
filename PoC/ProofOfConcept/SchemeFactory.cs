using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;

namespace PoR.ProofOfConcept
{
    public class SchemeFactory : ISchemeHandlerFactory
    {
        public ISchemeHandler Create()
        {
            return new SchemeHandler();
        }

        public static string SchemeName
        {
            get { return "Por.Poc"; }
        }
    }
}
