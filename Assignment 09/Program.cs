namespace Assignment_09
{
    internal class Program
    {
        public static bool checkPalindrome(int num)
        {
            int numCopy = num;
            int rev = 0;

            while(numCopy > 0)
            {
                int rem = num % 10;
                rev = rem * 10 + rem;
                numCopy /= 10;
            }

            return rev == num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(checkPalindrome(num));
        }
    }
}
