using DMS;
using DMS.Proxy;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace DocumentManagement
{
    public partial class Form1 : Form
    {
        private DocumentSystemProxy _proxy;


        public Form1()
        {
            InitializeComponent();
            _proxy = new DocumentSystemProxy();

            _proxy.GetDocumentCompleted += ProxyGetDocumentsComlepted;
            _proxy.AddDocumentCompleted += delegate (object sender, EventArgs e) { MessageBox.Show("Döküman başarı ile eklendi"); };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Senkron
            string rawdata = _proxy.GetDocument();
            MessageBox.Show(rawdata);
            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<DocumentEntity> docs = jss.Deserialize<List<DocumentEntity>>(rawdata);
            dataGridView1.DataSource = docs;
            //asenkron
            //_proxy.GetDocummentAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _proxy.AddDocummentAsync(textBox1.Text);
        }

        public void ProxyGetDocumentsComlepted(object sende, GetDocumentEventArgs e)
        {
            MessageBox.Show(e.Result);
            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<DocumentEntity> docs = jss.Deserialize<List<DocumentEntity>>(e.Result);
            dataGridView1.DataSource = docs;
        }
    }
}
