using System;
using System.Collections.Generic;

namespace CollectionAndGenerics
{
    public class SortedSet
    {
        public void SortedSetExample()
        {
            SortedSet<int> num = new SortedSet<int> { 2, 5, 6, 7, 9, 1, 5, 3, 8 };

            num.Add(10);
            num.Add(4);

            Console.WriteLine("SortedSet Elements:");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            SortedSet<int> numbers = new SortedSet<int> { 2, 3, 4, 5 };
            numbers.ToList().ForEach(n => Console.WriteLine(n));

            //accessing elements by index using linq
            SortedSet<int> num2 = new SortedSet<int> { 2, 3, 4, 5 };

            Console.WriteLine(num2.ElementAt(0)); // Prints 2
            Console.WriteLine(num2.ElementAt(3)); // Prints 5

        }

    }
}
