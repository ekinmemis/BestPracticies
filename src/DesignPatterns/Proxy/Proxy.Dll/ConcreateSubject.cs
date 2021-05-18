using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Host
{
    public class ConcreateSubject : Subject
    {
        private int _m;
        public ConcreateSubject()
        {
            Console.WriteLine("ConcreateSubject oluşturuldu");
        }
        ~ConcreateSubject()
        {
            Console.WriteLine("ConcreateSubject yok edildi");
        }


        public override void Request()
        {
            ++_m;
            Console.WriteLine("Request: {0}", _m);
        }
    }
}
