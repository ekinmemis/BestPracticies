using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TemplateMethod1
{
    abstract class DocumentManagementSystem
    {
        public abstract void Open(string path);
        public abstract bool Authentication(string name, string pwd);

        public DocumentBase GetDocument(string name, string pwd, string path)
        {
            if (Authentication(name, pwd))
            {
                Open(path);

                DocumentBase docBase = null;

                switch (Path.GetExtension(path))
                {
                    case "xls":
                    case "xlsx":
                        docBase = new SpreadSheet() { Path = path };
                        break;
                    case "txt":
                    case "cs":
                    case "cpp":
                    case "java":
                        docBase = new Text() { Path = path };
                        break;

                    case "pdf":
                        docBase = new Pdf() { Path = path };
                        break;
                }

                return docBase;

            }
            else
                throw new Exception("Wrong credentials");
        }
    }
}
