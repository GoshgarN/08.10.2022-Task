using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int n = 13;

            CountPrimeComposite(n);
        }

        public static void CountPrimeComposite( int n)

        {
            int a = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) 
                {
                    a++;

                }





            }

            if (a==2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Composite");
            }
        }
    }
}
