using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace DMS.Proxy
{
    public delegate string DlgGetDocuments();
    public delegate void GetDocumentAction(object sender, GetDocumentEventArgs e);
    public delegate void DlgAddDocument(string path);
    public delegate void AddDocumentAction(object sender, EventArgs e);

    public class DocumentSystemProxy : IDocumentSystem
    {
        private DocumentSystem _documentSystem;
        private HttpChannel _channel;

        public event GetDocumentAction GetDocumentCompleted;
        public event AddDocumentAction AddDocumentCompleted;

        public DocumentSystemProxy()
        {
            Activation();
        }

        private void Activation()
        {
            _channel = new HttpChannel();

            ChannelServices.RegisterChannel(_channel, false);

            _documentSystem = (DocumentSystem)Activator.GetObject(typeof(DocumentSystem), "http://127.0.0.1:9977//dms.rem");
        }

        public void AddDocument(string path)
        {
            _documentSystem.AddDocument(path);
        }

        public string GetDocument()
        {
            return _documentSystem.GetDocument();
        }

        public void GetDocummentAsync()
        {
            DlgGetDocuments dlgGetDocuments = new DlgGetDocuments(GetDocument);
            IAsyncResult asyncResult = dlgGetDocuments.BeginInvoke(null, null);
            string returnVal = dlgGetDocuments.EndInvoke(asyncResult);

            GetDocumentCompleted?.Invoke(this, new GetDocumentEventArgs());
        }

        public void AddDocummentAsync(string path)
        {
            DlgAddDocument dlgAddDocument = new DlgAddDocument(AddDocument);
            IAsyncResult asyncResult = dlgAddDocument.BeginInvoke(path, null, null);

            dlgAddDocument.EndInvoke(asyncResult);

            AddDocumentCompleted?.Invoke(this, new EventArgs());
        }
    }
}
