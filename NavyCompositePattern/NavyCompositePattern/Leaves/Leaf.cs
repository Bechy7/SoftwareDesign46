using System;
using NavyCompositePattern.Interfaces;

namespace NavyCompositePattern.Leaves
{
    public class Leaf : Component
    {
        public void Operation()
        {
            Console.WriteLine("Leaf");
        }
    }
}