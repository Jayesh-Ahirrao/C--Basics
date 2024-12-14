namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome ");
            foreach (var item in args)
            {
                Console.Write(item);
            }
        }
    }
}
