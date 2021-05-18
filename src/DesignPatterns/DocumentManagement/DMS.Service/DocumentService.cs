using System.ComponentModel;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.ServiceProcess;

namespace DMS.Service
{
    public partial class DocumentService : ServiceBase
    {
        private HttpChannel _channel;
        private IContainer components = null;

        public DocumentService()
        {
            InitializeComponent();
            _channel = new HttpChannel(9977);
        }
     
        private void InitializeComponent()
        {
            components = new Container();
            ServiceName = "DocumentService";
        }
        
        protected override void OnStart(string[] args)
        {
            ChannelServices.RegisterChannel(_channel,false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(DocumentSystem), "dms.rem", WellKnownObjectMode.SingleCall);
        }
        
        protected override void OnStop()
        {
            ChannelServices.UnregisterChannel(_channel);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }
    }
}
