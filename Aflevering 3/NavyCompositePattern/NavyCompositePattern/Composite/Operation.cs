using System;
using System.Collections;
using System.Collections.Generic;
using NavyCompositePattern.Templates;

namespace NavyCompositePattern.Composite
{
    //Template composite
    public class Operation : Component, IEnumerable
    {
        //En operation kan indeholde 
        //Listen skal være af den attribute der skal composite
        private List<Component> _army = new List<Component>();
        public string GetName { get; }
        public string SetInfo { get; set; }

        public void AddChild(Component army)
        {
            _army.Add(army);
        }

        public void RemoveChild(Component army)
        {
            _army.Remove(army);
        }

        public Component GetChild(int index)
        {
            return _army[index];
        }
        //Gør i stand til at kunne foreach det hele
        public IEnumerator GetEnumerator()
        {
            foreach (Component army in _army)
                yield return army;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}