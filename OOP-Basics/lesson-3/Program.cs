using System;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(GetStringReverse(text));

            Console.ReadKey();
        }

        public static string GetStringReverse(string text) //метод возвращает строку в обратном порядке
        {
            string reverse = null;

            for (int i = text.Length - 1; i >= 0; --i)
            {
                reverse += text[i];
            }
            
            return reverse;
        }
    }
}
