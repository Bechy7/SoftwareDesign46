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

            NavyComponent daniboi = new NavyComposite("daniboi", "mand", "highRank");

            NavyComponent sørenboi = new NavyComposite("soerenmightbeboesseboi", "mand", "highRankToo");

            NavyComponent Fætimå = new NavyComposite("Fætimø", "Kvindfolk", "MiddleRanks");

            sørenboi.AddChild(new NavyLeaf("im small", "mand", "lavt"));
            sørenboi.AddChild(new NavyLeaf("hej", "ikke noget køn", "hahaha"));

            daniboi.AddChild(new NavyLeaf("Marto", "mandboi", "Soldier"));

            NavyComponent test = new NavyComposite("above all", "mand", "highest rank");

            test.AddChild(Fætimå);

            Fætimå.AddChild(daniboi);
            Fætimå.AddChild(sørenboi);

            Fætimå.GiveOrder("Rens toiletter", false);


            test.Print();

            sørenboi.ExecuteOrder();
            
            sørenboi.SetCurrentOperation("Sandstorm");
            
            daniboi.SetCurrentOperation("Kill_Kate");

            Console.WriteLine();
            test.Print();
        }
    }
}
