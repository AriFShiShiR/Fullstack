using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndGenerics
{
    internal class HasSet
    {
        public void HashSetExample()
        {
            HashSet<int> list = new HashSet<int>();
            // Adding elements to the HashSet
            list.Add(40);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(70);
            list.Add(20);

            Console.WriteLine("HashSet Example:");
            // Displaying the elements of the HashSet
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            HashSet<int> list2 = new HashSet<int>();

            // Inserting elements into HashSet
            for (int i = 0; i < 10; i++)
            {
                list2.Add(i);
            }

            Console.WriteLine("The elements in HashSet are : ");

            // Displaying the elements in HashSet
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
