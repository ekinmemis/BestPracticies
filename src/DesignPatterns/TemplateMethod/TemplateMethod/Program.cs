using System;

namespace TemplateMethod
{
    class Program
    {
        static void Raporlama(ReportHelper rph)
        {
            rph.CreateReport();
        }
        static void Main(string[] args)
        {
            Raporlama(new Chart());
            Raporlama(new Pivot());
        }
    }
}
