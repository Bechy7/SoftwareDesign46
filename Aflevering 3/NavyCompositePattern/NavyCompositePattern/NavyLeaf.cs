using System;

namespace NavyCompositePattern
{
    //Composite class - include subordinates and other methods
    public sealed class NavyLeaf : NavyComponent
    {
        private string Operation { get; set; }

        public NavyLeaf(string name, string gender, string rank)
        : base(name, rank, gender)
        {

        }

        public override void SetCurrentOperation(string operation)
        {
            Operation = operation;
            Console.Write(Name + " received operation '" + Operation + "'");
        }

        public override string GetCurrentOperation()
        {
            return Operation;
        }

        public override void Print(int depth)
        {
            for (int i = 0; i < depth; i++)
                Console.Write("-");

            Console.Write(Name + ", " + Gender + ", " + Rank);

            if (Operation != null)
                Console.WriteLine(", on current operation '" + Operation + "'");
            else
                Console.WriteLine(", with no current operation");
        }

        public override void ExecuteOrder(string order)
        {
            Console.WriteLine("Executing order " + order);
        }

    }
}