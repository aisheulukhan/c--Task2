using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Ayseee";
            Console.WriteLine(VowelLetter(text));
        }
        static int VowelLetter (string text)
        {
            int count = 0;
            char[] letter = { 'a', 'i', 'o', 'u', 'e', 'A', 'I', 'O', 'U', 'E' };
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (text[i]==letter[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
