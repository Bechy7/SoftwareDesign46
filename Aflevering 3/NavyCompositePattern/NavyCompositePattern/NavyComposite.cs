using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace NavyCompositePattern
{
    //Composite class - include subordinates and other methods
    public class NavyComposite : NavyComponent
    {
        //private string _order;
        //private bool _delegateOrder;

        private List<NavyComponent> _subordinates = new List<NavyComponent>();
        
        public NavyComposite(string name, string gender, string rank)
        : base(name, gender, rank)
        {
        }
        public override void Print(int depth)
        {
            for(int i = 0; i < depth; i++)
                Console.Write("-");

            Console.WriteLine(Name + ", " + Gender + ", " + Rank);

            foreach (NavyComponent component in _subordinates)
                component.Print(depth + 1);
            //Soldater under ham

            //foreach (Component soldiers in _officers)
            //{
            //    Console.WriteLine("\n Name = {0}, Gender = {1}", soldiers.GetGender());
            //}
        }

        public override void ForwardOrder(string order)
        {
            //_order = order;
        }
        public override void GiveOrder(string order, bool delegateOrder)
        {
            //_order = order;
            //_delegateOrder = delegateOrder;
        }

        public override string GetCurrentOperation()
        {
            string msg = string.Format($"Composite with {_subordinates.Count} Officer(s)");
            return "0";
        }

        public override void AddChild(NavyComponent officer)
        {
            _subordinates.Add(officer);
        }

        public override void RemoveChild(NavyComponent officer)
        {
            _subordinates.Remove(officer);
        }

        public override NavyComponent GetChild(int index)
        {
            return _subordinates[index];
        }
        public override IEnumerator GetEnumerator()
        {
            foreach (NavyComponent sub in _subordinates)
                yield return sub;
        }
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

    }
}