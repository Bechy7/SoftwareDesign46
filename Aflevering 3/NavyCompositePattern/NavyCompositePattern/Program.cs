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

            NavyComponent daniboi = new NavyComposite("daniboi", "mand", "highRank")
            {
                Name = "daniboi",
                Operation = "nana"
            };

            NavyComponent sørenboi = new NavyComposite("sørenboi", "mand", "highRankToo")
            {
                Name = "soerenmightbeboesseboi"
            };

            sørenboi.AddChild(new NavyLeaf("im small", "mand", "lavt"));
            sørenboi.AddChild(new NavyLeaf("hej", "ikke noget køn", "hahaha"));

            NavyComponent test = new NavyComposite("above all", "mand", "highest rank");

            test.AddChild(daniboi);
            test.AddChild(sørenboi);

            test.GiveOrder("Rens toiletter", false);

            test.Print(1);
            //foreach (NavyComponent stuff in test)
            //{
            //    //Console.Write();
            //    stuff.Print();
            //}
            //_staff.Operation();
        }
    }
}
