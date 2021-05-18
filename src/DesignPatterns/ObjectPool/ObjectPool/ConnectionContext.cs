using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPool
{
    public class ConnectionContext
    {
        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public ConnectionContext()
        {
            isActive = false;
            Console.WriteLine("ConnectionContext yaratıldı");
        }

        public void Open()
        {
            Console.WriteLine("Connection açıldı");
        }

        public void Close()
        {
            Console.WriteLine("Connection kapatıldı");
        }

        public void Execute(string query)
        {
            Console.WriteLine(query+" çalıştı");
        }


    }
}
