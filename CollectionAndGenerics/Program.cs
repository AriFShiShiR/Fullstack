namespace CollectionAndGenerics
{
    public class Program
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

            // HashSet Example
            Console.WriteLine(" ");
            HasSet h1= new HasSet();
            h1.HashSetExample();

            // SortedSet Example
            Console.WriteLine(" ");
            SortedSet sse = new SortedSet();
            sse.SortedSetExample();
        }
    }
}
