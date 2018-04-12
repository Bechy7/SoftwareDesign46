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

        //private List<NavyComponent> _subordinates = new List<NavyComponent>();
        
        public NavyComposite(string name, string gender, string rank)
        : base(name, gender, rank)
        { }

        public override void GetOrder(string order, bool delegateOrder)
        {
            if (delegateOrder)
                ForwardOrder(order);
            else
                Order = order;
        }

        public override void ForwardOrder(string order)
        {
            if (Subordinates.Count == 0)
                Order = order;
            else
            {
                foreach (var navyComponent in Subordinates)
                    navyComponent.GetOrder(order, true);
            }
        }
        public override void GiveOrder(string order, bool delegateOrder)
        {
            if (delegateOrder)
                ForwardOrder(order);

            else
            foreach (var navyComponent in Subordinates)
                navyComponent.GetOrder(order, false);
        }

        public override void SetCurrentOperation(string operation)
        {
            Operation = operation;

            foreach (var navyComponent in Subordinates)
            {
                navyComponent.SetCurrentOperation(operation);
            }
        }

        public override void AddChild(NavyComponent subordinate)
        {
            Subordinates.Add(subordinate);
        }

        public override void RemoveChild(NavyComponent subordinate)
        {
            Subordinates.Remove(subordinate);
        }

        public override IEnumerator GetEnumerator()
        {
            foreach (NavyComponent sub in Subordinates)
                yield return sub;
        }

    }
}