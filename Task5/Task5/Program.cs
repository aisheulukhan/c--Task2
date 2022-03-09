using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasLetter("Menim adim Aysedir", "k"));
        }
        static bool HasLetter(string text, string word)
        {
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (text [i]==word [j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
    }
}
