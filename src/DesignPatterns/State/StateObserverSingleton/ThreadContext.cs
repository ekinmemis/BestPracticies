using System;
using System.Collections.Generic;
using System.Text;

namespace StateObserverSingleton
{
    class ThreadContext : IObservable
    {
        public string ThreadId { get; set; }
        public IThreadState ThreadState { get; set; }
        public List<IObserver> Observers { get; set; }
        public ThreadContext()
        {
            Console.WriteLine("Thread yaratıldı ve henüz çalışmıyor");
            ThreadId = Guid.NewGuid().ToString();
            ThreadState = StoppedState.Create();
            Observers = new List<IObserver>();
        }

        public void Start()
        {
            ThreadState.Run(this);
        }
        public void Sleep()
        {
            ThreadState.Wait(this);
        }
        public void Abort()
        {
            ThreadState.Stop(this);
        }

        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(string threadId, ThreadStateMachine tsm)
        {
            for (int i = 0; i < Observers.Count - 1; i++)
                Observers[i].Handle(threadId, tsm);
        }
    }
}
