using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3_adv
{

    public delegate bool SortDelegate<T>(T num1, T num2);
    internal class BubbleSort
    {
        public static void PrintArrays(int[] arr)
        {

            foreach (int i in arr)
            {
                Console.Write($"{i}  ");

            }

        }





        public static void sortnumbers<T>(T[] arr,SortDelegate<T> refernce)
        {

            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (refernce.Invoke(arr[j], arr[j+1]))
                        {
                            SortBySwap.Swap(ref arr[j], ref arr[j + 1]);


                        }



                    }






                }

            }

        }


        //public static void sortnumbergreater(int[] arr)
        //{

        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1; j++)
        //            {
        //                if (ExpressionSort.LessThan(arr[j], arr[j + 1]))
        //                {
        //                    SortBySwap.Swap(ref arr[j], ref arr[j + 1]);


        //                }



        //            }






        //        }

        //    }

        //}



        //public static void sortnumbersless(int[] arr)
        //{

        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1; j++)
        //            {
        //                if (ExpressionSort.LessThan(arr[j], arr[j + 1]))
        //                {
        //                    SortBySwap.Swap(ref arr[j], ref arr[j + 1]);


        //                }



        //            }






        //        }

        //    }

        //}


    }
}
