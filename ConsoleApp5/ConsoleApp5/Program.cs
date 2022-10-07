using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 16;



            Console.WriteLine(EqualToAnswer(n)); ;

        }

        public static bool EqualToAnswer(int n)
            

        {

           
            while (n != 1) 
            {
               
                if (n%2!=0)
                {
                    return false;
                   

                }
                n = n / 2;
            }

            return true;


            


        }


    }
}
