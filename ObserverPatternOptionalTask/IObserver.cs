using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternOptional
{
    public interface IObserver
    {
        void Update(string stockName, double price);
    }
}
