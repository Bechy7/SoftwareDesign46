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

            var general = new NavyComposite("Amos", "Male", "General");
            var captain1 = new NavyComposite("Daniel", "Male", "Captain");
            var captain2 = new NavyComposite("Søren", "Male", "Captain");
            var officer = new NavyComposite("Fatima", "Female", "Officer");
            var officer2 = new NavyComposite("Jogvan", "Male", "Officer");
            var private1 = new NavyLeaf("JensFup", "Male", "Private");
            var private2 = new NavyLeaf("John", "Male", "Private");

            captain2.AddChild(private2);
            captain2.AddChild(new NavyLeaf("Jensine", "Female", "Private"));

            captain1.AddChild(new NavyLeaf("Martin", "Male", "Private"));
            
            general.AddChild(officer);
            general.AddChild(officer2);

            officer.AddChild(captain1);
            officer.AddChild(captain2);

            officer2.AddChild(private1);
            officer2.GiveOrder("Clean toilettes", false);

            officer.GiveOrder("Kill Søren", false);

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            general.Print();

            Console.WriteLine("---------------------------------");

            Console.WriteLine();

            captain2.SetCurrentOperation("Sandstorm");
            captain1.SetCurrentOperation("Kill_Kate");

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            general.Print();

            Console.WriteLine("---------------------------------");

            captain1.AddChild(private2);
            captain2.RemoveChild(private2);

            Console.WriteLine();

            captain1.ExecuteOrder();
            officer.RemoveChild(captain2);

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            general.Print();

            Console.WriteLine("---------------------------------\n");

            general.GiveOrder("Invade Africa", false);


            captain1.GiveOrder("Make coffee for all captains", true);

            Console.WriteLine("PRINTING FULL TREE");
            Console.WriteLine("---------------------------------");

            general.Print();

            Console.WriteLine("---------------------------------\n");

            private2.ExecuteOrder();

            Console.WriteLine($"PRINTING ONLY TREE UNDER {captain1.Name}");
            Console.WriteLine("---------------------------------");

            captain1.Print();

            Console.WriteLine("---------------------------------");

        }
    }
}
