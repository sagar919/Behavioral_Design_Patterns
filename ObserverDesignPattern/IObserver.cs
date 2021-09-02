using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public interface IObserver
    {
        public void update(string availability);
    }
}
