using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NavyCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            NavyComponent Captain1 = new NavyComposite("Daniel", "Male", "Captain");

            NavyComponent Captain2 = new NavyComposite("Søren", "Male", "Captain");

            NavyComponent Officer = new NavyComposite("Fatima", "Female", "Officer");

            Captain2.AddChild(new NavyLeaf("John", "Male", "Private"));
            Captain2.AddChild(new NavyLeaf("Jensine", "Female", "Private"));

            Captain1.AddChild(new NavyLeaf("Martin", "Male", "Private"));

            NavyComponent General = new NavyComposite("Amos", "Male", "General");

            General.AddChild(Officer);

            Officer.AddChild(Captain1);
            Officer.AddChild(Captain2);

            Officer.GiveOrder("Rens toiletter", false);


            General.Print();

            Captain2.ExecuteOrder();
            
            Captain2.SetCurrentOperation("Sandstorm");
            
            Captain1.SetCurrentOperation("Kill_Kate");

            Console.WriteLine();
            General.Print();
        }
    }
}
