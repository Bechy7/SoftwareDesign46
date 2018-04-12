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

        public override void SetOrder(string order, bool delegateOrder)
        {
            if (delegateOrder)
                ForwardOrder(order);
            else
            {
                Order = order;
                Console.WriteLine($"{Rank} {Name} receiving order: {order}\n");
            }
        }

        public override void ForwardOrder(string order)
        {
            if (Subordinates.Count == 0)
            {
                Console.WriteLine($"{Rank} {Name} receiving order: {order}\n");
                Order = order;
            }
            else
            {
                Console.WriteLine($"{Rank} {Name} forwarding order: {order}\n");
                foreach (var navyComponent in Subordinates)
                    navyComponent.SetOrder(order, true);
            }
        }
        public override void GiveOrder(string order, bool delegateOrder)
        {
            if (delegateOrder)
            {
                ForwardOrder(order);
            }
            else
            {
                Console.WriteLine($"{Rank} {Name} giving order to direct subordinates: {order}\n");
                foreach (var navyComponent in Subordinates)
                    navyComponent.SetOrder(order, false);
            }
        }

        public override void SetCurrentOperation(string operation)
        {
            Operation = operation;
            Console.WriteLine($"{Rank} {Name} received operation: {Operation}\n");

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