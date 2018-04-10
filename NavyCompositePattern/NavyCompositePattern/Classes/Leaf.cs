using System;
using NavyCompositePattern.Interfaces;

namespace NavyCompositePattern.Classes
{
    public class Leaf : Component
    {
        public void Operation()
        {
            Console.WriteLine("Leaf");
        }
    }
}