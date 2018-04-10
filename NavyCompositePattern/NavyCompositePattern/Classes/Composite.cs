using System;
using System.Collections;
using System.Collections.Generic;
using NavyCompositePattern.Interfaces;

namespace NavyCompositePattern.Classes
{
    //Template composite
    public class Composite : Component
    {
        //Listen skal være af den attribute der skal composite
        private List<Component> _children = new List<Component>();
        public void Operation()
        {
            string msg = string.Format($"Composite with {_children.Count} child(ren)");
            Console.WriteLine(msg);
        }

        public void AddChild(Component child)
        {
            _children.Add(child);
        }

        public void RemoveChild(Component child)
        {
            _children.Remove(child);
        }

        public Component GetChild(int index)
        {
            return _children[index];
        }

        //public IEnumerator GetEnumerator()
        //{
        //    foreach (Component child in _children)
        //        yield return child;   
        //}
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

    }
}