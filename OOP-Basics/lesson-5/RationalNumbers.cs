using System;

namespace lesson_5
{
    public class RationalNumbers
    {
        /// <summary>
        /// Числитель
        /// </summary>
        private int _numerator;
        /// <summary>
        /// Знаменатель
        /// </summary>
        private int _denominator;
        
        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен 0");
            }
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            _numerator = numerator;
            _denominator = denominator;
            CommonDivisor();
        }
        
        /// <summary>
        /// Определяет общий делитель для числителя и знаменателя
        /// </summary>
        private void CommonDivisor()
        {
            int greatestCommonDivision = RationalNumbers.OperatorCommonDivisor(_numerator, _denominator);
            _numerator /= greatestCommonDivision;
            _denominator /= greatestCommonDivision;
        }
        
        /// <summary>
        /// Определение оператора ==
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator ==(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            return !(rationalNumber1._numerator != rationalNumber2._numerator && rationalNumber1._denominator != rationalNumber2._denominator);
        }
        
        /// <summary>
        /// Определение оператора !=
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator !=(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            return !(rationalNumber1._numerator == rationalNumber2._numerator && rationalNumber1._denominator == rationalNumber2._denominator);
        }
        
        /// <summary>
        /// Определение оператора <
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator <(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            double firstNumber = (double)rationalNumber1._numerator / (double)rationalNumber1._denominator;
            double secondNumber = (double)rationalNumber2._numerator / (double)rationalNumber2._denominator;
            return (firstNumber < secondNumber);
        }
        
        /// <summary>
        /// Определение оператора >
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator >(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            double firstNumber = (double)rationalNumber1._numerator / (double)rationalNumber1._denominator;
            double secondNumber = (double)rationalNumber2._numerator / (double)rationalNumber2._denominator;
            return (firstNumber > secondNumber);
        }
        
        /// <summary>
        /// Определение оператора <=
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator <=(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            double firstNumber = rationalNumber1._numerator / (double)rationalNumber1._denominator;
            double secondNumber = rationalNumber2._numerator / (double)rationalNumber2._denominator;
            return (firstNumber <= secondNumber);
        }
        
        /// <summary>
        /// Определение оператора >=
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator >=(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            double firstNumber = rationalNumber1._numerator / (double)rationalNumber1._denominator;
            double secondNumber = rationalNumber2._numerator / (double)rationalNumber2._denominator;
            return firstNumber >= secondNumber;
        }

        /// <summary>
        /// Определение оператора +
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static RationalNumbers operator +(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            int newDenominator = rationalNumber1._denominator * rationalNumber2._denominator;
            int newNumerator = rationalNumber1._numerator * rationalNumber2._denominator + rationalNumber2._numerator * rationalNumber1._denominator;
            RationalNumbers result = new RationalNumbers(newNumerator, newDenominator);
            return result;
        }
        
        /// <summary>
        /// Определение оператора -
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static RationalNumbers operator -(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            int newDenominator = rationalNumber1._denominator * rationalNumber2._denominator;
            int newNumerator = rationalNumber1._numerator * rationalNumber2._denominator - rationalNumber2._numerator * rationalNumber1._denominator;
            RationalNumbers result = new RationalNumbers(newNumerator, newDenominator);
            return result;
        }
        
        /// <summary>
        /// Определение оператора *
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static RationalNumbers operator *(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            int newDenominator = rationalNumber1._denominator * rationalNumber2._denominator;
            int newNumerator = rationalNumber1._numerator*rationalNumber2._numerator;
            RationalNumbers result = new RationalNumbers(newNumerator, newDenominator);
            return result;
        }
        
        /// <summary>
        /// Определение оператора /
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static RationalNumbers operator /(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            int newDenominator = rationalNumber1._denominator * rationalNumber2._numerator;
            int newNumerator = rationalNumber1._numerator * rationalNumber2._denominator;
            RationalNumbers result = new RationalNumbers(newNumerator, newDenominator);
            return result;
        }
        
        /// <summary>
        /// Определение оператора ++
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <returns></returns>
        public static RationalNumbers operator ++(RationalNumbers rationalNumber1)
        {
            int newNumerator = rationalNumber1._numerator + rationalNumber1._denominator;
            RationalNumbers result = new RationalNumbers(newNumerator, rationalNumber1._denominator);
            return result;
        }
        
        /// <summary>
        /// Определение оператора --
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <returns></returns>
        public static RationalNumbers operator --(RationalNumbers rationalNumber1)
        {
            int newNumerator = rationalNumber1._numerator - rationalNumber1._denominator;
            RationalNumbers result = new RationalNumbers(newNumerator, rationalNumber1._denominator);
            return result;
        }

        /// <summary>
        /// Определение оператора %
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static RationalNumbers operator %(RationalNumbers rationalNumber1, RationalNumbers rationalNumber2)
        {
            int newNumerator = rationalNumber1._numerator * rationalNumber2._denominator;
            int newDenominator = rationalNumber1._denominator * rationalNumber2._numerator;
            RationalNumbers result = new RationalNumbers(newNumerator, newDenominator);
            result._numerator /= result._denominator;
            result._denominator = 1;
            return result;
        }

        /// <summary>
        /// Определение оператора float
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <returns></returns>
        public static explicit operator float(RationalNumbers rationalNumber1)
        {
            return rationalNumber1._numerator;
        }
        
        /// <summary>
        /// Определение оператора int
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <returns></returns>
        public static explicit operator int(RationalNumbers rationalNumber1)
        {
            return rationalNumber1._numerator;
        }
        
        
        private static int OperatorCommonDivisor(int numerator, int denominator)
        {
            if (denominator == 0)
                return numerator;
            
            return OperatorCommonDivisor(denominator, numerator % denominator);
        }
        
        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (_numerator != 0){ string returnString = $"{_numerator}/{_denominator}"; return returnString; }
            return "0";
        }
    }
}