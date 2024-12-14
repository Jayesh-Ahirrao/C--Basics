
namespace C_Basics
{
    internal class Assignment_01
    {
        static void Main(string[] args) { 
            System.Console.WriteLine("Enter your name : ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Enter first num: ");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Second num: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is:  " + name);

            Console.WriteLine("Addition is:  " +( num1 + num2));


        }
    }
}
