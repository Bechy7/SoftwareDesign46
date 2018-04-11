using System;
using NavyCompositePattern.Interfaces;

namespace NavyCompositePattern.Leaves
{
    public class Leaf : Component
    {
        void Operation()
        {
            Console.WriteLine("Leaf");
        }
    }
}