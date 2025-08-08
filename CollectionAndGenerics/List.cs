using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndGenerics
{
    internal class List
    {
        public void ListExample()
        {
            List<string> num = new List<string> { "Arif", "Mahmud", "Shishir" };
            foreach (string item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
