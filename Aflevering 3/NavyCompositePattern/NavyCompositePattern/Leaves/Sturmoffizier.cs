using System;
using NavyCompositePattern.Interfaces;

namespace NavyCompositePattern.Leaves
{
    //Leaf template
    public class Sturmoffizier : Component
    {
        public void Operation()
        {
            Console.WriteLine("Sturmoffizier");
        }
    }
}