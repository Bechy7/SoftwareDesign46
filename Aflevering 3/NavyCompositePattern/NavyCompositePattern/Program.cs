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

            NavyComponent admiral1 = new NavyComposite("Amos", "Male", "Admiral");
            NavyComponent captain1 = new NavyComposite("Fatima", "Female", "Captain");
            NavyComponent captain2 = new NavyComposite("Jogvan", "Male", "Captain");
            NavyComponent captain3 = new NavyComposite("Hans", "Male", "Captain");
            NavyComponent lieutenant1 = new NavyComposite("Daniel", "Male", "Lieutenant");
            NavyComponent lieutenant2 = new NavyComposite("Søren", "Male", "Lieutenant");
            NavyComponent sailor1 = new NavyLeaf("JensFup", "Male", "Sailor");
            NavyComponent sailor2 = new NavyLeaf("John", "Male", "Sailor");

            captain3.AddChild(new NavyComposite("Bente", "Female", "Lieutenant"));

            lieutenant2.AddChild(sailor2);
            captain2.AddChild(new NavyLeaf("Jensine", "Female", "Sailor"));

            lieutenant1.AddChild(new NavyLeaf("Martin", "Male", "Sailor"));
            
            admiral1.AddChild(captain1);
            admiral1.AddChild(captain2);
            admiral1.AddChild(captain3);

            captain1.AddChild(lieutenant1);
            captain1.AddChild(lieutenant2);

            lieutenant2.AddChild(sailor1);
            lieutenant2.GiveOrder("Clean toilettes", false);

            captain1.GiveOrder("Kill Søren", false);

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            admiral1.Print();

            Console.WriteLine("---------------------------------");

            Console.WriteLine();

            lieutenant2.SetCurrentOperation("Sandstorm");
            lieutenant1.SetCurrentOperation("Kill_Kate");

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            admiral1.Print();

            Console.WriteLine("---------------------------------");

            lieutenant1.AddChild(sailor2);
            captain1.RemoveChild(lieutenant2);

            Console.WriteLine();

            lieutenant1.ExecuteOrder();
            lieutenant1.RemoveChild(lieutenant2);

            Console.WriteLine($"Manually removing {lieutenant2.Name} " +
                              $"and adding {sailor2.Name} under {lieutenant1.Name}");

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            admiral1.Print();

            Console.WriteLine("---------------------------------\n");

            admiral1.GiveOrder("Invade Africa", false);


            lieutenant1.GiveOrder("Make coffee for all captains", true);

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            admiral1.Print();

            Console.WriteLine("---------------------------------\n");

            sailor2.ExecuteOrder();

            Console.WriteLine($"PRINTING ONLY TREE UNDER {lieutenant1.Name}");
            Console.WriteLine("---------------------------------");

            lieutenant1.Print();

            Console.WriteLine("---------------------------------\n");

            Console.WriteLine($"{sailor1.Rank} {sailor1.Name} trying to give order:");
            try
            {
                sailor1.GiveOrder("Make me captain", true);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
