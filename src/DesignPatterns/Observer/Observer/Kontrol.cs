using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    abstract class Kontrol
    {
        protected string _text;
        protected string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public string Text { get => _text; set => _text = value; }
        public abstract void Add(IObservable o);
        public abstract void Remove(IObservable o);
        public abstract void onAction(string val);
    }
}
