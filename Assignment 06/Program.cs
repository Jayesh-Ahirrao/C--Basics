namespace Assignment_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of month");
            int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 1: Console.WriteLine("Jan");
                    break;
                case 2: Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("Aug");
                    break;
                case 9:
                    Console.WriteLine("Sept");
                    break;
                case 10:
                    Console.WriteLine("Oct");
                    break;
                case 11:
                    Console.WriteLine("Nov");
                    break;
                case 12:
                    Console.WriteLine("Dec");
                    break;
                default:
                    Console.WriteLine("Enter valid month number");
                    break;
            }
        }
    }
}
