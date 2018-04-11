using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavyCompositePattern.Composite;
using NavyCompositePattern.Templates;


namespace NavyCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component daniboi = new Templates.Composite();
            
            daniboi.Name = "daniboi";

            Component sørenboi= new Templates.Composite();
            sørenboi.Name = "soerenmightbeboesseboi";

            ColonialMarine test = new ColonialMarine();

            test.AddChild(daniboi);
            test.AddChild(sørenboi);
            
            foreach (Component stuff in test)
            {
                //Console.Write();
                stuff.Print();
            }
            //_staff.Operation();
        }
    }
}
