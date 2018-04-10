using System;
using System.Collections;
using System.Collections.Generic;
using NavyCompositePattern.Interfaces;

namespace NavyCompositePattern.Composite
{
    //Template composite
    public class Staff : Component, IEnumerable
    {
        //Listen skal være af den attribute der skal composite
        private List<Component> _personnel = new List<Component>();
        public void Operation()
        {
            string msg = string.Format($"Staff with {_personnel.Count} USMC(s)");
            Console.WriteLine(msg);
        }

        public void AddChild(Component child)
        {
            _personnel.Add(child);
        }

        public void RemoveChild(Component child)
        {
            _personnel.Remove(child);
        }

        public Component GetChild(int index)
        {
            return _personnel[index];
        }

        //Gør til at jeg kan foreach lortet
        public IEnumerator GetEnumerator()
        {
            foreach (Component child in _personnel)
                yield return child;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}