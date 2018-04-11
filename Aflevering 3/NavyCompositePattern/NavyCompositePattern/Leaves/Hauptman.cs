using System;
using NavyCompositePattern.Interfaces;

namespace NavyCompositePattern.Leaves
{
    public class Hauptman : Component
    {
        public void Operation()
        {
            Console.WriteLine("Hauptman");
        }
    }
}