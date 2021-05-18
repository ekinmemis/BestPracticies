using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype1
{
    [Serializable]
    public abstract class PrototypeHelper<T>
    {
        //Shallow Clone
        public T ShallowClone()
        {
            return (T) this.MemberwiseClone();
        }

        //Deep Clone
        public T DeepClone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(ms, this);
            ms.Seek(0, SeekOrigin.Begin);
            T temp = (T)bf.Deserialize(ms);
            ms.Close();

            return temp;
        }
    }
}
