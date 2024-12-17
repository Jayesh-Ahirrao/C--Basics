namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String[] subs = { "Math", "Physics", "Chem" };
            int[] marks = new int[subs.Length];
            int[] minMarks = { 65, 55, 50 };
            int minTotal = 180;
            int totalMarks = 0;
            string remakr = "Can be admitted";



            for(int i = 0; i < subs.Length; i++)
            {
                Console.WriteLine($"Enter marks for {subs[i]}");
                marks[i] = int.Parse(Console.ReadLine());
            }

            for(int i= 0; i <  marks.Length; i++)
            {
                totalMarks += marks[i];
                if(marks[i] < minMarks[i])
                {
                    remakr = "Cannot get admitted";
                    break;
                }
            }

            if(totalMarks  < minTotal)
            {
                remakr = "Cannot get admitted";
            }
            

            Console.WriteLine(remakr);
        }
    }
}
