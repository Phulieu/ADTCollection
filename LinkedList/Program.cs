namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            Console.WriteLine(list);
        }
    }
}
