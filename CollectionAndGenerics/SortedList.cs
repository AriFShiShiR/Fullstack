using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndGenerics
{
    internal class SortedList
    {
        public void SortedListExample ()
        { 
            SortedList<int, string> sl= new SortedList<int, string>();
            sl.Add(11, "Volkswagen");
            sl.Add(2, "Audi");
            sl.Add(12, "Porsche");
            sl.Add(8, "Kia");
            sl.Add(6, "Nissan");
            sl.Add(3, "Mercedes");
            sl.Add(9, "Ford");
            sl.Add(1, "BMW");
            sl.Add(10, "Chevrolet");
            sl.Add(4, "Toyota");
            sl.Add(7, "Hyundai");
            sl.Add(5, "Honda");

            foreach (var Item in sl)
            {
                Console.WriteLine($"{Item.Key}:{Item.Value}");
            }

        }
    }
}
