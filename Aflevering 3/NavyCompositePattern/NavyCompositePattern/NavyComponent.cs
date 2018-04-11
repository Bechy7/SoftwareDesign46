using System;
using System.Collections;

namespace NavyCompositePattern
{
    public abstract class NavyComponent : IEnumerable
    {
        public virtual string Name { get; set; }

        public virtual string Rank { get; set; }

        public virtual string Gender { get; set; }

        protected NavyComponent(string name, string rank, string gender)
        {
            Name = name;
            Rank = rank;
            Gender = gender;
        }

        public virtual void SetCurrentOperation(string operation) { throw new NotSupportedException(); }

        public virtual string GetCurrentOperation() { throw new NotSupportedException(); }

        public virtual void AddChild(NavyComponent child) { throw new NotSupportedException(); }

        public virtual void RemoveChild(NavyComponent child) { throw new NotSupportedException(); }

        public virtual NavyComponent GetChild(int index) { throw new NotSupportedException(); }

        public virtual void GiveOrder(string order, bool delegateOrder) { throw new NotSupportedException(); }

        public virtual void Print(int depth) { throw new NotSupportedException(); }

        public virtual void ExecuteOrder(string order, bool execute) { throw new NotSupportedException(); }

        // Only be able to execute - for leaves only
        public virtual void ExecuteOrder(string order) { throw new NotSupportedException(); }

        public virtual void ForwardOrder(string order) { throw new NotSupportedException(); }

        public virtual IEnumerator GetEnumerator() { throw new NotSupportedException(); }
    }
}