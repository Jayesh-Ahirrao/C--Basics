namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] strs = { "one", "two", "three", "one", "four", "one" };

            for(int i = 0; i < strs.Length -1; i++)
            {
                bool isDusplicate = false;

                for(int j = 1; j < strs.Length; j++)
                {
                    if(i != j &&  strs[j] == strs[i])
                    {
                        isDusplicate = true; 
                        break;
                    }
                }

                if (!isDusplicate)
                {
                    Console.WriteLine(strs[i]);
                }
            }
        }
    }
}
