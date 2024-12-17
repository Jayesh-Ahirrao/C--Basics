namespace Assignment_11
{
    internal class Program
    {
        static void display(int[] arr)
        {
            foreach(int num in arr){
                Console.Write($"{num} : ");
            }
        }

        static int getSum(int[] nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }
            return sum;
        }

        static void PrintMinMax(int[] nums)
        {
            if(nums.Length > 0)
            {
                int min = nums[0];
                int max = nums[0];

                for(int i =1; i < nums.Length; i++)
                {
                    if (nums[i] < min) min = nums[i];
                    if (nums[i] > max) max = nums[i];
                }

                Console.WriteLine($"MIN : {min} \nMAX : {max}");
            }
            else
            {
                Console.WriteLine("Array is empty");
            }
            
        }
        
        static bool isPerfect(int num)
        {
            int sum = 0;

            for(int i = 1; i <= num/2; i++)
            {
                if(num %i == 0)
                {
                    sum += i;
                }
            }

            return sum == num;
        }

        static void DisplayPerfects(int[] nums)
        {
            HashSet<int> perfects = new HashSet<int>();
            HashSet<int> notPerfects = new HashSet<int>();

            foreach (int num in nums)
            {
                if (isPerfect(num))
                {
                    perfects.Add(num);
                }
                else
                {
                    notPerfects.Add(num);
                }
            }

            Console.Write("Perfect Numbers are : ");
            foreach(int num in perfects)
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();


            Console.Write("Non-perfect Numbers are : ");
            foreach (int num in notPerfects)
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();
        }

        static bool isPrime(int num)
        {
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void DisplayPrimes(int[] nums)
        {
            HashSet<int> primes = new HashSet<int>();
            //HashSet<int> nonPrimes = new HashSet<int> { 0 
            HashSet<int> nonPrimes = new HashSet<int> { 0 };

            foreach(int num in nums)
            {
                if(isPrime(num))
                {
                    primes.Add(num);
                }
                else
                {
                    nonPrimes.Add(num);
                }
            }

            Console.Write("Prime Numbers are : ");
            foreach (int num in primes)
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();


            Console.Write("Non-Prime Numbers are : ");
            foreach (int num in nonPrimes)
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();

        }


        static void Main(string[] args)
        {
            int[] nums = new int[args.Length];

            for(int i = 0; i < args.Length; i++)
            {
               if(!int.TryParse(args[i], out nums[i]))
                {
                    Console.WriteLine("invalid args");
                    return;
                }   
            }



            do
            {
                Console.WriteLine("\n\n********************** MENU **********************\n" +
                    "1. Display array elements\n" +
                    "2. Sum of array elements\n" +
                    "3. Min and Max from array elements\n" +
                    "4. Check array elements is perfect or not\n" +
                    "5. Check array element are prime are not\n" +
                    "6. Count frequency of each element in the array\n" +
                    "7. Find second largest element in the array\n" +
                    "8. Sort elements of array in increasing order\n" +
                    "9. Sort elements in decreasing order\n" +
                    "10. Reverse an array\n" +
                    "99. Exit\n" );

                int input = int.Parse(Console.ReadLine());

                if (input == 99)
                {
                    break;
                }

                switch (input) 
                {
                    case 1: display(nums);
                        break;
                    case 2: Console.WriteLine( getSum(nums)); break;
                    case 3: PrintMinMax(nums); break;
                    case 4: DisplayPerfects(nums); break;
                    case 5: DisplayPrimes(nums); break;
                }

            } while (true);
        }
    }
}
