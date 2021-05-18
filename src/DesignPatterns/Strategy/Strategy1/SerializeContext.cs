using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy1
{
    class SerializeContext
    {
        private SeralizationStrategy _strategy;
        public SerializeContext(SeralizationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Save(string path) => _strategy.Persist(path);
        public object Load(string path) => _strategy.Load(path);


    }
}
