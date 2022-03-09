using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 9,  76, 34, 6 };
            Console.WriteLine("Arrayin en kicik elementi:"+Min(arr));
        }
        static int Min ( int [] arr  )
        {
            
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
            

        }
    }
}
