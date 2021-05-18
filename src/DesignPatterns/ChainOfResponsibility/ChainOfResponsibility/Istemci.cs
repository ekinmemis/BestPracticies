using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Istemci
    {
        public static void CagriAc(CallCenter callCenter)
        {
            callCenter.CagriAl();
        }
    }
}
