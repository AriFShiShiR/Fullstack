namespace CollectionAndGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List listExample = new List();
              listExample.ListExample();
            Console.WriteLine(" ");

            // Sorted List Example
            Console.WriteLine("Sorted List Example:");
            SortedList sle = new SortedList();
            sle.SortedListExample();
        }
    }
}
