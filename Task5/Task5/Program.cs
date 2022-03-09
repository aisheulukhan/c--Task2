using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasLetter("Menim adim Aysedir", "Menim"));
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
        static bool HasLetter(string text)
        {
            char letter = 'm';
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
