using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using Proxy.Client;
using Proxy.Host;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Host

            IChannel channel = new TcpChannel(8477);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ConcreateSubject), "csd.rem", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Host açıldı kapatmak için bir tuşa basınız");
            Console.ReadLine();

            ChannelServices.UnregisterChannel(channel);

            #endregion

            ////////

            #region Client

            SampleProxy proxy = new SampleProxy();
            proxy.Request();
            proxy.Request();
            proxy.Request();
            proxy.Request();
            proxy.RequstAsync();
            proxy.RequstAsync();

            #endregion
        }
    }
}
