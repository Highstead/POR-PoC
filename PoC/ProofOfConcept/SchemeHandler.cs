using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;

namespace PoR.ProofOfConcept
{
    internal class SchemeHandler : ISchemeHandler
    {
        private readonly IDictionary<string, string> resources;

        public SchemeHandler()
        {

        }

        public bool ProcessRequestAsync(IRequest request, ISchemeHandlerResponse response, OnRequestCompletedHandler requestCompletedCallback)
        {
            // The 'host' portion is entirely ignored by this scheme handler.
            var uri = new Uri(request.Url);
            var fileName = uri.AbsolutePath;

            string resource;
            if (resources.TryGetValue(fileName, out resource) && !String.IsNullOrEmpty(resource))
            {
                var bytes = Encoding.UTF8.GetBytes(resource);
                response.ResponseStream = new MemoryStream(bytes);
                response.MimeType = GetMimeType(fileName);

                //Execute in async fashion
                requestCompletedCallback.BeginInvoke(requestCompletedCallback.EndInvoke, null);

                return true;
            }

            return false;
        }

        private string GetMimeType(string fileName)
        {
            if (fileName.EndsWith(".css")) return "text/css";
            if (fileName.EndsWith(".js")) return "text/javascript";
            if (fileName.EndsWith(".tff")) return "font/opentype";
            if (fileName.EndsWith(".woff")) return "application/x-font-woff";

            return "text/html";
        }
    }
}
