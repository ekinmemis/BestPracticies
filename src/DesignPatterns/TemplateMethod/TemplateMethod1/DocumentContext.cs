using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TemplateMethod1
{
    sealed class DocumentContext : DocumentManagementSystem
    {
        public override bool Authentication(string name, string pwd)
        {
            if (name == "name" && pwd == "pwd")
                return true;
            else
                return false;
        }

        public override void Open(string path)
        {
            Process p = new Process();
            p.StartInfo.Arguments = path;

            switch (Path.GetExtension(path).Replace(".",""))
            {
                case "xls":
                case "xlsx":
                    p.StartInfo.FileName = "";
                    break;

                case "txt":
                case "cs":
                case "cpp":
                case "java":
                    p.StartInfo.FileName = "";
                    break;

                case "pdf":
                    p.StartInfo.FileName = "";
                    break;
            }
            p.Start();
        }
    }
}
