using System.Collections.Generic;

namespace Aflevering_1
{
    abstract class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();
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
            foreach (IObserver obs in _observers)
            {
                obs.Update();
            }
        }
    }
}