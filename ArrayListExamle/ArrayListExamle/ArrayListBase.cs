using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExamle
{
    class ArrayListBase
    {
        ArrayList list;

        public void Work() {
            list = new ArrayList();
            Console.WriteLine("Empty list");
            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);


            Console.WriteLine("\n Add five elemenys of different types ");
            list.Add("A");
            list.Add(1);
            list.Add("Tim");
            list.Add(2.12);
            list.Add('И');

            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);

            Console.WriteLine("\n Remove one of elements by Value");
            list.Remove("Tim");
            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);

            Console.WriteLine("\n Remove one of elements by Key");
            list.RemoveAt(1);
            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);

            Console.WriteLine("\n Add new 10 elements");
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);

            Console.WriteLine("\n Change 3 elements");
            list[1] = "ioio";
            list[3] = 9090;
            list[10] = "asdfghjkl";

            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);

            Console.WriteLine("\n Use of TrimToSize()");
            list.TrimToSize();
            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);
        }
            
    }
}
