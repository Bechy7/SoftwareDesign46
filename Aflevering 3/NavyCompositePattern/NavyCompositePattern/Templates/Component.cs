using System;
using System.Collections;
using System.Collections.Generic;

namespace NavyCompositePattern.Templates
{
    public abstract class Component
    {
        public string Name { get; set; }

        void SetCurrentOperation(string operation)
        {
            throw new NotSupportedException();
        }

        string GetCurrentOperation()
        {
            throw new NotSupportedException();
        }

        public void AddChild(Component child)
        {
            throw new NotSupportedException();
        }

        public void RemoveChild(Component child)
        {
            throw new NotSupportedException();
        }

        Component GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public string GetName()
        {
            throw new NotSupportedException();
        }

        public string GetGender()
        {
            throw new NotSupportedException();
        }

        public void GiveOrder(string order, bool delegateOrder)
        {
            throw new NotSupportedException();
            //Give to subordinate below or delegate to leaf
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public void ExecuteOrder(string order, bool execute)
        {
            throw new NotSupportedException();
        }

        public void ForwardOrder(string order)
        {
            throw new NotSupportedException();
        }
    }
}