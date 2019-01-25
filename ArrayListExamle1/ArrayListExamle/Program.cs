using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExamle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("=======================");
            HashTableBase obj3 = new HashTableBase();
            obj3.Work();

            Console.WriteLine("=======================");
            SortedListBase obj4 = new SortedListBase();
            obj4.Work();
            Console.ReadKey();
        }
    }
}
