using System;
using System.Threading.Channels;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ Деление на 0 ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            RationalNumbers number1 = new RationalNumbers(50, 0);
            Console.WriteLine(number1.ToString()); //Знаменатель не может быть равен нулю 1/0
            
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ Вывод дробей ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            RationalNumbers number2 = new RationalNumbers(7,15);
            Console.WriteLine(number2.ToString());
            RationalNumbers number3 = new RationalNumbers(9,11);
            Console.WriteLine(number3.ToString());
            RationalNumbers number4 = new RationalNumbers(7, 9);
            
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ == != Equals ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine(number2 == number3);
            Console.WriteLine(number2 != number3);
            Console.WriteLine(number1.Equals(number2));
            Console.WriteLine(number2.Equals(number3));
            
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ > и < ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine(number3 > number1);
            Console.WriteLine(number3 > number2);
            Console.WriteLine(number3 < number2);
            
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ >= и <= ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine(number3 <= number4);
            Console.WriteLine(number2 <= number4);
            Console.WriteLine(number4 >= number2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ + - * / ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine(number2+number3);
            Console.WriteLine(number2-number3);
            Console.WriteLine(number2*number3);
            Console.WriteLine(number2/number3);
            
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ++ и -- ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine(number2++);
            Console.WriteLine(number2--);
            
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ float и int ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            RationalNumbers number5 = new RationalNumbers(720000000, 5);
            Console.WriteLine((float)number5);
            Console.WriteLine((int)number5);
            
            Console.ReadLine();
        }
    }
}
