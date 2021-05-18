using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Strategy1
{
    sealed class SoapStrategy : SeralizationStrategy
    {
        private SoapFormatter formatter;
        public SoapStrategy(object graph) : base(graph)
        {
            formatter = new SoapFormatter();
        }

        public override void Persist(string path)
        {
            FileStream fs = File.Create(path);
            formatter.Serialize(fs, base._graph);
            fs.Close();
        }

        public override object Load(string path)
        {
            FileStream fs = File.Open(path, FileMode.Open);
            object tmp = formatter.Deserialize(fs);
            fs.Close();
            return tmp;
        }

        ~SoapStrategy()
        {
            formatter = null;
        }
    }
}
