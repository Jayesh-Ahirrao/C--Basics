using System.Runtime.CompilerServices;

namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] subs = { "Physics", "Chemistry", "Computer Application" };
            int[] marks = new int[3];
            int totalMarks = 0;
            int percentage = 0;
            string remakr = "";


            Console.WriteLine("Input roll number of student");
            int rollNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Input name of student");
            string name = Console.ReadLine();

            int index = 0;
            foreach (string sub in subs)
            {
                Console.WriteLine($"Enter marks for {sub}");
                marks[index] = int.Parse(Console.ReadLine());
                totalMarks += marks[index++];
            }



            percentage = (totalMarks * 100) / 300;

            Console.WriteLine($"Roll Number : {rollNumber}" );

            Console.WriteLine($"Name of Student: {name}");

            Console.WriteLine($"marks in {subs[0]} : {marks[0]}");
            Console.WriteLine($"marks in {subs[1]} : {marks[1]}");
            Console.WriteLine($"marks in {subs[2]} : {marks[2]}");

            Console.WriteLine($"Total marks : {totalMarks}");
            Console.WriteLine($"Pecentage : {percentage}" );

            Console.WriteLine($"marks in {subs[0]} : {marks[0]}");

            if(percentage <= 35)
            {
                remakr = "failed";
            }else if(percentage <= 60)
            {
                remakr = "third class";
            }else if(percentage <= 80)
            {
                remakr = "Second class";
            }
            else
            {
                remakr = "First class";
            }

            Console.WriteLine($"Class : {remakr}" );

        }
    }
}
