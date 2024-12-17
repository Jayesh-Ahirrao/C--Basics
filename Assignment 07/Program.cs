namespace Assignment_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int columnWidth = 4;
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 12; j++)
                {
                    Console.Write($"{(i*j).ToString().PadLeft(columnWidth)}");
                }
                Console.WriteLine();
            }
        }
    }
}
