using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    public abstract class BrowserOpen
    {
        protected string UriView { get; set; }
        protected string NameHtml { get; set; }

        protected abstract string CreateView();

        public BrowserOpen()
        {
            NameHtml = "index.html";
        }
        public string CreateViewFile()
        {
            string pathTmpPreview = Path.GetFullPath(NameHtml);
            StreamWriter wr = new StreamWriter(pathTmpPreview);
            wr.Write(this.CreateView());
            wr.Close();

            return pathTmpPreview;
        }

        public void Open()
        {
            if (String.IsNullOrEmpty(UriView))
            {
                UriView = CreateViewFile();
            }
            if (!String.IsNullOrEmpty(UriView))
            {
                Process.Start(UriView);
            }
        }
    }
}
