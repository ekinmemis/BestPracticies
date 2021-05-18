using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Host
{
    public abstract class Subject : MarshalByRefObject
    {
        public abstract void Request();

    }
}
