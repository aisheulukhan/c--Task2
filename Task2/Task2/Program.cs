using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 458;
            Console.WriteLine("Ededin reqemlerinin sayi:" +NumLenght(num) );

        }
        static int NumLenght (int num)
        {
            int lenght = 0;
            while (num>0)
            {
                num = num / 10;
                lenght++;
            }
            return lenght;
        }
    }
}
