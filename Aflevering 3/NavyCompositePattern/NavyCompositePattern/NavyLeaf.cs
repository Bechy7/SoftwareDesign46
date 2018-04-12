using System;

namespace NavyCompositePattern
{
    //Composite class - include subordinates and other methods
    public sealed class NavyLeaf : NavyComponent
    {
        public NavyLeaf(string name, string gender, string rank)
        : base(name, rank, gender)
        { }

       public override void ExecuteOrder(string order)
        {
            Console.WriteLine("Executing order " + order);
        }

        public override void GetOrder(string order, bool delegateOrder)
        {
            Order = order;
        }

        public override void ForwardOrder(string order)
        {
            Order = order;
        }
    }
}