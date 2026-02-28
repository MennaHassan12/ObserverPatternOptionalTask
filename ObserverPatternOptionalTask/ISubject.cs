using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternOptional
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify();
    }
}
