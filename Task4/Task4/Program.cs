using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sahe(-4));
            Console.WriteLine(Sahe(-4, 5));
            Console.WriteLine(Sahe(4, 5, 2));
            Console.WriteLine(Sahe(4, 5, 4));

        }
        static int Sahe (int radius )
        {
            if (radius > 0)
            {
                return radius * radius * 3;
            }
            return -1;
        }
        static int Sahe(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                return a * b;
            }
            return -1;
        }
        static int Sahe(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return 2 * (a * b + a * c + b * c);
            }
            return -1;
        }
        static int Sahe(int a, int b, int c, int r, int p)
        {
            if (a > 0 && b > 0 && c > 0 && r>0)
            {
                return ((a + b + c) / 2) * r;
            }
            return -1;
        }


    }
}
