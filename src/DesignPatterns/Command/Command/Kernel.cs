using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Command
{
    class Kernel
    {
        public void DirListApi(string path)
        {
            if (path == string.Empty)
                Console.WriteLine("ListCommand requires a valid path");
            else
            {
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < files.Length; i++)
                    Console.WriteLine(files);
            }
        }

        public void MakeDirApi(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void DeleteApi(string path)
        {
            File.Delete(path);
        }

        public void QuitApi()
        {
            Console.WriteLine("---- Free CSD ----");
            Environment.Exit(0);
        }
    }
}
