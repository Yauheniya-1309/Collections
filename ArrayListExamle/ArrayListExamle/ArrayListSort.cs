using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExamle
{
    class ArrayListSort
    {
        ArrayList list;

        public void Work()
        {
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

            Console.WriteLine("\n Try to sort list with different types");
            try
            {
                list.Sort();
                Console.WriteLine("Capacity = {0} ", list.Capacity);
                Console.WriteLine("Count = {0}", list.Count);

                foreach (object obj in list)
                    Console.Write("{0}  ", obj);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("\n Clear the list");
            list.Clear();
            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);

            Console.WriteLine("\n Add ten elemenys of one type ");
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(100));
            }

            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);


            Console.WriteLine("\n Try to sort of list");
            list.Sort();

            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);

            Console.WriteLine("\n Reverse of list");
            list.Reverse();
            Console.WriteLine("Capacity = {0} ", list.Capacity);
            Console.WriteLine("Count = {0}", list.Count);

            foreach (object obj in list)
                Console.Write("{0}  ", obj);
          
            Console.WriteLine("\n Convert to Array ");
            int[] ar = (int[])list.ToArray(typeof(int));

            foreach (object obj in ar)
                Console.Write("{0}  ", obj);
        }
    }
}
