using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Strategy1
{
    sealed class BinaryStrategy : SeralizationStrategy
    {
        private BinaryFormatter binaryFormatter;
        public BinaryStrategy(object graph):base(graph)
        {
            binaryFormatter = new BinaryFormatter();
        }

        public override void Persist(string path)
        {
            FileStream fileStream = File.Create(path);
            binaryFormatter.Serialize(fileStream, base._graph);
            fileStream.Close();
        }

        public override object Load(string path)
        {
            FileStream fs = File.Open(path, FileMode.Open);
            object tmp = binaryFormatter.Deserialize(fs);
            fs.Close();
            return tmp;
        }

        ~BinaryStrategy()
        {
            binaryFormatter = null;
        }
    }
}
