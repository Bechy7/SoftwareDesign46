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
            foreach (var navyComponent in Subordinates)
            {
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

        public override void AddChild(NavyComponent officer)
        {
            Subordinates.Add(officer);
        }

        public override void RemoveChild(NavyComponent officer)
        {
            Subordinates.Remove(officer);
        }

        public override IEnumerator GetEnumerator()
        {
            foreach (NavyComponent sub in Subordinates)
                yield return sub;
        }

    }
}