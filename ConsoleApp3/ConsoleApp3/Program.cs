using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 12, 13, 5, 2, 3, };

            //Console.WriteLine(SumOddArr(a));

            //Console.WriteLine(CountOddArr(a));


        }

        #region Task6

       
        public static int CountOddArr(int[] a)

        {
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    count++;
                }
            }


            return count;

             #endregion


            #region Task5


            //public static int SumOddArr(int[] a)

            //{
            //    int sum = 0;

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] % 2 == 1) 
            //        {
            //            sum += a[i];
            //        }
            //    }


            //    return sum;
            #endregion
        }

}
}
