using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Aflevering_1
{
    abstract class Subject
    {
        private string _name;
        private double _value;

        private List<IObserver> _observers = new List<IObserver>();

        public Subject(string name, double value = 0)
        {
            _name = name;
            _value = value;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            //Console.WriteLine($"Notifying that stock {_name} has changed to {_value}");
            foreach (IObserver obs in _observers)
            {
                obs.Update(this);
            }
        }

        public double Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    Notify();
                }
            }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}