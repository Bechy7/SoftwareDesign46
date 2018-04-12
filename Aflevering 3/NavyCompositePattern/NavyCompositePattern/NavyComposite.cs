using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace NavyCompositePattern
{
    //Composite class - include subordinates and other methods
    public class NavyComposite : NavyComponent
    {
        public NavyComposite(string name, string gender, string rank)
        : base(name, gender, rank)
        { }

        // Delegate order to subordinates or set order 
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

        // Forward to subordinates or set order
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

        // Give order to direct subordinates or forward
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

        // Set operation in this object plus all subordinates
        public override void SetCurrentOperation(string operation)
        {
            Operation = operation;
            Console.WriteLine($"{Rank} {Name} received operation: {Operation}\n");

            foreach (var navyComponent in Subordinates)
            {
                navyComponent.SetCurrentOperation(operation);
            }
        }

        // Add child to subordinates
        public override void AddChild(NavyComponent subordinate)
        {
            Subordinates.Add(subordinate);
        }

        // Remove child from subordinates
        public override void RemoveChild(NavyComponent subordinate)
        {
            Subordinates.Remove(subordinate);
        }
    }
}