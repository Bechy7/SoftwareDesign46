using System;

namespace NavyCompositePattern
{
    //Composite class - include subordinates and other methods
    public sealed class NavyLeaf : NavyComponent
    {
        public NavyLeaf(string name, string gender, string rank)
        : base(name, gender, rank)
        { }

        public override void SetCurrentOperation(string operation)
        {
            Operation = operation;
            Console.WriteLine($"{Rank} {Name} received operation: {Operation}\n");
        }

        public override void SetOrder(string order, bool delegateOrder)
        {
            Order = order;
            Console.WriteLine($"{Rank} {Name} received order: {Order}\n");
        }

        public override void ForwardOrder(string order)
        {
            Order = order;
            Console.WriteLine($"{Rank} {Name} received order: {Order}\n");
        }
    }
}