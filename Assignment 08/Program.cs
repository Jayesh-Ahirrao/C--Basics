using System.Security.Cryptography;

namespace Assignment_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colWidth = 4;
            for(int i = 1; i <= 12; i++)
            {

                for(int j = 1; j <= 10; j++)
                {
                    Console.Write($"{(j*i).ToString().PadLeft(colWidth)}");
                }
                Console.WriteLine();
            }
        }
    }
}
