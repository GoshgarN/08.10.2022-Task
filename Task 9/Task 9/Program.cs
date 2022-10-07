using System;

namespace Task_9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 19, 53, 2, 7, 69, 4, 99 };



            Console.WriteLine(SumArrPower(n));


            //Console.WriteLine(MultiplyArr(n));

        }

        #region Task10

       
        public static int SumArrPower(int[] n)
            

        {
            int sum = 0;
            int power = 1;
            

            for (int i = 0; i < n.Length; i++)
            {

                if (n[i]%2==0)

                {
                    sum += n[i];

                }



            }

            power = sum * sum;

            return power;
            #endregion



            #region Task9


            //public static int MultiplyArr(int[] n)

            //{
            //    int mult = 1;

            //    for (int i = 0; i < n.Length; i++)
            //    {

            //        if (1<=n[i] && n[i]<=20 )

            //        {
            //            mult = mult * n[i];

            //        }



            //    }
            //    return mult;


        }
        #endregion

    }
}
