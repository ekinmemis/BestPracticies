using System;

namespace DMS.Proxy
{
    public class GetDocumentEventArgs : EventArgs
    {
        public string Result { get; set; }
        public GetDocumentEventArgs()
        {

        }

        public GetDocumentEventArgs(string result)
        {
            Result = result;
        }
    }
}
