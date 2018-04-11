using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavyCompositePattern.Composite;
using NavyCompositePattern.Interfaces;
using NavyCompositePattern.Leaves;

namespace NavyCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff _staff = new Staff();
            IPrivate _pfc = new IPrivate {ID = 0,Name = "Fatima",Weapon ="Dildogun"};

            _staff.AddChild(_pfc);
                     
            
            foreach (IPrivate soldiers in _staff)
            {
                Console.Write(_pfc.Name);
                Console.WriteLine("\n ID = {0}, Name = {1}, Weapon = {2}",_pfc.ID, _pfc.Name, _pfc.Weapon);
            }
            //_staff.Operation();
        }
    }
}
