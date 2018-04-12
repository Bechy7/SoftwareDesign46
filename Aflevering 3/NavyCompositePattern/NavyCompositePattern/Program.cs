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

            var admiral = new NavyComposite("Amos", "Male", "Admiral");
            var captain1 = new NavyComposite("Fatima", "Female", "Captain");
            var captain2 = new NavyComposite("Jogvan", "Male", "Captain");
            var lieutenant1 = new NavyComposite("Daniel", "Male", "Lieutenant");
            var lieutenant2 = new NavyComposite("Søren", "Male", "Lieutenant");
            var sailor1 = new NavyLeaf("JensFup", "Male", "Sailor");
            var sailor2 = new NavyLeaf("John", "Male", "Sailor");

            lieutenant2.AddChild(sailor2);
            captain2.AddChild(new NavyLeaf("Jensine", "Female", "Sailor"));

            lieutenant1.AddChild(new NavyLeaf("Martin", "Male", "Sailor"));
            
            admiral.AddChild(captain1);
            admiral.AddChild(captain2);

            captain1.AddChild(lieutenant1);
            captain1.AddChild(lieutenant2);

            lieutenant2.AddChild(sailor1);
            lieutenant2.GiveOrder("Clean toilettes", false);

            captain1.GiveOrder("Kill Søren", false);

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            admiral.Print();

            Console.WriteLine("---------------------------------");

            Console.WriteLine();

            lieutenant2.SetCurrentOperation("Sandstorm");
            lieutenant1.SetCurrentOperation("Kill_Kate");

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            admiral.Print();

            Console.WriteLine("---------------------------------");

            lieutenant1.AddChild(sailor2);
            lieutenant2.RemoveChild(sailor2);

            Console.WriteLine();

            lieutenant1.ExecuteOrder();
            lieutenant1.RemoveChild(lieutenant2);

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            admiral.Print();

            Console.WriteLine("---------------------------------\n");

            admiral.GiveOrder("Invade Africa", false);


            lieutenant1.GiveOrder("Make coffee for all captains", true);

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            admiral.Print();

            Console.WriteLine("---------------------------------\n");

            sailor2.ExecuteOrder();

            Console.WriteLine($"PRINTING ONLY TREE UNDER {lieutenant1.Name}");
            Console.WriteLine("---------------------------------");

            lieutenant1.Print();

            Console.WriteLine("---------------------------------");

        }
    }
}
