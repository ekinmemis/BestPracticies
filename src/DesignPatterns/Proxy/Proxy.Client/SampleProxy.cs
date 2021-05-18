
using Proxy.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy.Client
{
    public class SampleProxy : Subject
    {
        private ConcreateSubject _cs;
        private TcpChannel _channel;

        public SampleProxy()
        {
            Activation("tcp://127.0.0.1:8477/csd.rem");
        }


        private void Activation(string url)
        {
            _channel = new TcpChannel();
            ChannelServices.RegisterChannel(_channel, false);
            _cs = (ConcreateSubject)Activator.GetObject(typeof(ConcreateSubject), url);
            return;
        }

        public override void Request()
        {
            Console.WriteLine("Senkron request");
            _cs.Request();
        }

        public void RequstAsync()
        {
            Console.WriteLine("Asenkron request");
            Thread thread = new Thread(_cs.Request);
            thread.Start();
        }
        ~SampleProxy()
        {
            ChannelServices.UnregisterChannel(_channel);
        }
    }
}
