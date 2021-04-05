using System;

namespace FractionApp
{
    class Fraction
    {
        int numerator;
        int denominator;
        public Fraction(int num, int denom)
        { // 생성자
            numerator = num;
            denominator = denom;
        }
        public void PrintFraction()
        { // 출력 메소드
            Console.WriteLine(numerator + "/" + denominator);
        }
    }
    class FractionApp
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(1, 2);
            f.PrintFraction();
        }
    }
}
