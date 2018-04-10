using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavyCompositePattern.Classes;

namespace NavyCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite _composite = new Composite();
            Leaf _leaf1 = new Leaf();
            Leaf _leaf2 = new Leaf();
            
            List<Composite> _list = new List<Composite>();
            
            _composite.AddChild(_leaf1);
            _composite.AddChild(_leaf2);
            _composite.Operation();
            

        }
    }
}
