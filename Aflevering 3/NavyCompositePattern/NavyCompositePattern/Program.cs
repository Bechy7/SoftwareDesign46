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

            general.Print();

            Console.WriteLine("\nSetting new operations: Sandstorm and Kill_Kate\n");

            captain2.SetCurrentOperation("Sandstorm");
            captain1.SetCurrentOperation("Kill_Kate");

            general.Print();

            captain1.AddChild(private2);
            captain2.RemoveChild(private2);

            Console.WriteLine();

            captain1.ExecuteOrder();
            officer.RemoveChild(captain2);

            general.Print();

            general.GiveOrder("Invade Africa", false);

            Console.WriteLine("\nGeneral giving order to subordinates: Invade Africa");
            Console.WriteLine("Captain giving order to all leaves: make coffee for all captains\n");

            captain1.GiveOrder("Make coffee for all captains", true);

            general.Print();

            Console.WriteLine();

            private2.ExecuteOrder();

            Console.WriteLine("Print only tree under a captain\n");

            captain1.Print();
        }
    }
}
