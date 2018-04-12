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

            NavyComponent captain1 = new NavyComposite("Daniel", "Male", "Captain");

            NavyComponent captain2 = new NavyComposite("Søren", "Male", "Captain");

            NavyComponent officer = new NavyComposite("Fatima", "Female", "Officer");

            NavyComponent officer2 = new NavyComposite("Jogvan", "Male", "Officer");

            NavyComposite private1 = new NavyComposite("JensFup", "Male", "Private");

            captain2.AddChild(new NavyLeaf("John", "Male", "Private"));
            captain2.AddChild(new NavyLeaf("Jensine", "Female", "Private"));

            captain1.AddChild(new NavyLeaf("Martin", "Male", "Private"));

            NavyComponent general = new NavyComposite("Amos", "Male", "General");

            general.AddChild(officer);
            general.AddChild(officer2);

            officer.AddChild(captain1);
            officer.AddChild(captain2);

            officer2.AddChild(private1);

            officer.GiveOrder("Rens toiletter", false);
            
            general.Print();

            Console.WriteLine();

            captain2.ExecuteOrder();
            
            captain2.SetCurrentOperation("Sandstorm");
            
            captain1.SetCurrentOperation("Kill_Kate");

            Console.WriteLine();

            general.Print();
        }
    }
}
