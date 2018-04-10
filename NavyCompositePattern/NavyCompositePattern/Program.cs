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
            Obersturmfuhrer _unteroffizier1 = new Obersturmfuhrer();
            Obersturmfuhrer _unteroffizier2 = new Obersturmfuhrer();
            USF _grenadier = new USF();

            _staff.AddChild(_unteroffizier1);
            _staff.AddChild(_unteroffizier2);
            _staff.Operation();
            _staff.RemoveChild(_unteroffizier2);

            _unteroffizier1.Operation();
            foreach (USF soldiers in _staff)
            {
                Console.WriteLine("\n EmpID={0}, Name={1}", manager.EmpID, manager.Name);
            }
            _staff.Operation();
        }
    }
}
