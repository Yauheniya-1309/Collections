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
            ArrayListBase obj1 = new ArrayListBase();
                obj1.Work();
            Console.WriteLine("=======================");
            ArrayListSort obj2= new ArrayListSort();
            obj2.Work();
            Console.ReadKey();
        }
    }
}
