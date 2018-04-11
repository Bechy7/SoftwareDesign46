using System;
using System.Collections;
using System.Collections.Generic;
using NavyCompositePattern.Templates;

namespace NavyCompositePattern.Composite
{
    //Template composite
    public class ColonialMarine : Component, IEnumerable
    {
        private string _order;
        private bool _delegateOrder;
        //Listen skal være af den attribute der skal composite
        private List<Component> _officers = new List<Component>();

        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            //Soldater under ham

            //foreach (Component soldiers in _officers)
            //{
            //    Console.WriteLine("\n Name = {0}, Gender = {1}", soldiers.GetGender());
            //}
        }

        public void ExecuteOrder(string order, bool execute)
        {
            _order = order;
            _delegateOrder = execute;
        }

        public void ForwardOrder(string order)
        {
            _order = order;
        }
        public void GiveOrder(string order, bool delegateOrder)
        {
            _order = order;
            _delegateOrder = delegateOrder;
        }

        public void GetCurrentOperation()
        {
            string msg = string.Format($"Composite with {_officers.Count} Officer(s)");
            Console.WriteLine(msg);
        }

        public void AddChild(Component officer)
        {
            _officers.Add(officer);
        }

        public void RemoveChild(Component officer)
        {
            _officers.Remove(officer);
        }

        public Component GetChild(int index)
        {
            return _officers[index];
        }
        //Gør i stand til at kunne foreach det hele
        public IEnumerator GetEnumerator()
        {
            foreach (Component officer in _officers)
                yield return officer;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}