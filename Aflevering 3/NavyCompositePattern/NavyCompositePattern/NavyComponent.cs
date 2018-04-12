using System;
using System.Collections;
using System.Collections.Generic;

namespace NavyCompositePattern
{
    public abstract class NavyComponent : IEnumerable
    {
        // Declare list of subordinates and define all properties
        public List<NavyComponent> Subordinates = new List<NavyComponent>();
        public virtual string Name { get; }
        public virtual string Rank { get; set; }
        public virtual string Gender { get; }
        public virtual string Operation { get; set; }
        public virtual string Order { get; set; }

        // Base class constructor
        protected NavyComponent(string name, string gender, string rank)
        {
            Name = name;
            Rank = rank;
            Gender = gender;
        }

        
        public virtual void SetCurrentOperation(string operation) { throw new NotSupportedException(); }

        public virtual void AddChild(NavyComponent child) { throw new NotSupportedException(); }

        public virtual void RemoveChild(NavyComponent child) { throw new NotSupportedException(); }

        public virtual void GiveOrder(string order, bool delegateOrder) { throw new NotSupportedException(); }

        public virtual void GetOrder(string order, bool delegateOrder) { throw new NotSupportedException(); }

        public virtual void Print(int depth = 0)
        {
            for (int i = 0; i < depth; i++)
                Console.Write("|   ");

            Console.Write(Name + ", " + Gender + ", " + Rank);

            if (Operation != null)
                Console.Write(", on current operation '" + Operation + "'");
            else
                Console.Write(", with no current operation");

            if (Order != null)
                Console.WriteLine(", with current order: '" + Order + "'");
            else
                Console.WriteLine(", with no current order");

            foreach (NavyComponent component in Subordinates)
                component.Print(depth + 1);
        }

        //// Only be able to execute - for leaves only
        public virtual void ExecuteOrder()
        {
            Console.WriteLine($"{Name} executing order:");
            Console.WriteLine(Order == null
                ? $"{Name} had no order to execute\n"
                : $"{Name}: Order '{Order}' has been executed\n");

            Order = null;
        }

        public virtual void ForwardOrder(string order) { throw new NotSupportedException(); }

        public virtual IEnumerator GetEnumerator() { throw new NotSupportedException(); }
    }
}