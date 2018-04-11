using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavyCompositePattern.Composite;
using NavyCompositePattern.Interfaces;


namespace NavyCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //here
            Staff _staff = new Staff();
            IPrivate _pfc1 = new IPrivate {ID = 0,Name = "Fatima",Weapon ="M4A1"};
            IPrivate _pfc2 = new IPrivate{ID = 1, Name = "Daniel", Weapon = "M4A1"};

            _staff.AddChild(_pfc1);
            _staff.AddChild(_pfc2);
                     
            
            foreach (IPrivate soldiers in _staff)
            {
                //Console.Write();
                Console.WriteLine("\n ID = {0}, Name = {1}, Weapon = {2}",soldiers.ID, soldiers.Name, soldiers.Weapon);
            }
            //_staff.Operation();
        }
    }
}
