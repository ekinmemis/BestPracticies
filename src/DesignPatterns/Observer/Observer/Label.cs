namespace Observer
{
    class Label : Kontrol
    {
        public override void Add(IObservable o)
        {
            o.Register(this);
        }

        public override void onAction(string val)
        {
            Text = val;
        }

        public override void Remove(IObservable o)
        {
            o.UnRegister(this);
        }
    }
}
