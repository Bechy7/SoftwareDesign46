using System;
using NavyCompositePattern.Interfaces;

namespace NavyCompositePattern.Leaves
{
    public class Obersturmfuhrer : Component
    {
        public void Operation()
        {
            Console.WriteLine("Obersturmführer");
        }
    }
}