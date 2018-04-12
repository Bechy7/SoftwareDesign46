using System;

namespace NavyCompositePattern
{
    //Composite class - include subordinates and other methods
    public sealed class NavyLeaf : NavyComponent
    {
        public NavyLeaf(string name, string gender, string rank)
        : base(name, gender, rank)
        { }

        // Set current operation, no forwarding
        public override void SetCurrentOperation(string operation)
        {
            Operation = operation;
            Console.WriteLine($"{Rank} {Name} received operation: {Operation}\n");
        }

        // Set order, no forwarding
        public override void SetOrder(string order, bool delegateOrder)
        {
            Order = order;
            Console.WriteLine($"{Rank} {Name} received order: {Order}\n");
        }

        // Only be able to set order
        public override void ForwardOrder(string order)
        {
            this.SetOrder(order, false);
        }
    }
}