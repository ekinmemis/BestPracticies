using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy1
{
    abstract class SeralizationStrategy
    {
        protected object _graph;
        protected Type _type;

        protected SeralizationStrategy(object graph)
        {
            _graph = graph;
            _type = graph.GetType();
        }

        public abstract void Persist(string path);
        public abstract object Load(string path);
    }
}
