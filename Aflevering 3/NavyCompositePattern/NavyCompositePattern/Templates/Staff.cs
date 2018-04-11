//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace NavyCompositePattern.Composite
//{
//    //Template composite
//    public class Staff : IPrivate, IEnumerable
//    {
//        //Listen skal være af den attribute der skal composite
//        private List<IPrivate> _personnel = new List<IPrivate>();
//        public void Operation()
//        {
//            string msg = string.Format($"Staff with {_personnel.Count} USMC(s)");
//            Console.WriteLine(msg);
//        }

//        public void AddChild(IPrivate soldier)
//        {
//            _personnel.Add(soldier);
//        }

//        public void RemoveChild(IPrivate soldier)
//        {
//            _personnel.Remove(soldier);
//        }

//        public IPrivate GetChild(int index)
//        {
//            return _personnel[index];
//        }

//        //Gør til at jeg kan foreach lortet
//        public IEnumerator GetEnumerator()
//        {
//            foreach (IPrivate soldier in _personnel)
//                yield return soldier;
//        }
//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }

//    }
//}