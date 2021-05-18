using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class ReportHelper
    {
        public void CreateReport()
        {
            Query();
            Render();
        }
        public void Query() => Console.WriteLine("Kayıtlar veritabanında sorgulandı");
        public abstract void Render();
    }
}
