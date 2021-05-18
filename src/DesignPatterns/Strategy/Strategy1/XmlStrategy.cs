using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Strategy1
{
    sealed class XmlStrategy : SeralizationStrategy
    {
        private XmlSerializer xmlSerializer;
        public XmlStrategy(object graph) : base(graph)
        {
            xmlSerializer = new XmlSerializer(base._type);
        }

        public override void Persist(string path)
        {
            FileStream fs = File.Create(path);
            xmlSerializer.Serialize(fs, base._graph);
            fs.Close();
        }

        public override object Load(string path)
        {
            FileStream fs = File.Open(path, FileMode.Open);
            object tmp = xmlSerializer.Deserialize(fs);
            fs.Close();
            return tmp;
        }
        ~XmlStrategy()
        {
            xmlSerializer = null;
        }
    }
}
