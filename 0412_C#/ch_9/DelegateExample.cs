using System;
namespace DelegateExample
{
    class DelegateExample
    {
        delegate bool MemberTest(int a);
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 4, 2, 6, 4, 6, 8, 54, 23, 4, 6, 4 };
            Console.WriteLine(Count(4));
            Console.WriteLine(Count(arr, 4));
            Console.WriteLine("짝수의 갯수: " + EvenCount(arr));
            Console.WriteLine("홀수의 갯수: " + OddCount(arr));
            Console.WriteLine("짝수의 갯수: " + Count(arr, IsEven));
            Console.WriteLine("홀수의 갯수: " + Count(arr, IsOdd));
        }
        static int EvenCount(int[] a)
        {
            int cnt = 0;
            foreach (var n in a)
            {
                if (n % 2 == 0)
                    cnt++;
            }
            return cnt;
        }
        static int OddCount(int[] a)
        {
            int cnt = 0;
            foreach (var n in a)
            {
                if (n % 2 == 1)
                    cnt++;
            }
            return cnt;
        }
