﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExamle
{
    class HashTableBase
    {
        Hashtable table;

        public void Work()
        {
            table = new Hashtable();
            Console.WriteLine("Empty table");
            Console.WriteLine("Count = {0} ", table.Count);
            ICollection keys = table.Keys;
            ICollection values = table.Values;
            foreach(var s in keys)
            { Console.WriteLine(s + " - " + table[s]); }

            Console.WriteLine("\n Add five elements ");
            table.Add("A","Letter A");
            table.Add(1,"number 1");
            table.Add(13,13);
            table.Add(2.12,3.12);
            table.Add('И','s');

            keys = table.Keys;
            values = table.Values;
            foreach (var s in keys)
            { Console.WriteLine(s + " - " + table[s]); }

            Console.WriteLine("\n Add one more element ");
            table["Jane"] = "Name";

            Console.WriteLine("Count = {0} ", table.Count);
            keys = table.Keys;
            values = table.Values;
            foreach (var s in keys)
            { Console.WriteLine(s + " - " + table[s]); }

            Console.WriteLine("\n Change thr element by key ");
            table["Jane"] = "NewName";

            Console.WriteLine("Count = {0} ", table.Count);
            keys = table.Keys;
            values = table.Values;
            foreach (var s in keys)
            { Console.WriteLine(s + " - " + table[s]); }

            Console.WriteLine("\n Remove one exist element ");
            table.Remove(1);
            Console.WriteLine("Count = {0} ", table.Count);
            keys = table.Keys;
            values = table.Values;
            foreach (var s in keys)
            { Console.WriteLine(s + " - " + table[s]); }

            Console.WriteLine("\n Try to remove not exist element ");// Не выбрасывает исключение, если не найден элемент для удаления, просто идёт дальше
            try
            {
                table.Remove(2);
                Console.WriteLine("Count = {0} ", table.Count);
                keys = table.Keys;
                values = table.Values;
                foreach (var s in keys)
                { Console.WriteLine(s + " - " + table[s]); }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n Try to remove not exist element ");// Не выбрасывает исключение, если не найден элемент для удаления, просто идёт дальше
            if(table.Contains("2"))
            { 
                table.Remove(2);
                Console.WriteLine("Count = {0} ", table.Count);
                keys = table.Keys;
                values = table.Values;
                foreach (var s in keys)
                { Console.WriteLine(s + " - " + table[s]); }
            }
            else
            {
                Console.WriteLine("The object doesn't exist");
            }


            Console.WriteLine(table.ContainsValue("Tom"));
            Console.WriteLine(table.ContainsValue("Letter A"));
            Console.WriteLine(table.ContainsKey("2"));
            Console.WriteLine(table.ContainsKey(2.12));
        }
    }
}
