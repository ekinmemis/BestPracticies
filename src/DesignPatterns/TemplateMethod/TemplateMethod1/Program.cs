using System;

namespace TemplateMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentManagementSystem dms = new DocumentContext();

            try
            {
                dms.GetDocument("name", "pwd", "path");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
