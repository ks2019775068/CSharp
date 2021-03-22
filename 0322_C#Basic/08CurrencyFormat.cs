using System;

namespace CurrencyFormat
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal value = 123456.789m;
			Console.WriteLine("잔액은 {0:C2}원 입니다.", value);
			Console.WriteLine("{0,20:C2}원 입니다.", value);
			Console.WriteLine("{0,-20:C2}원 입니다.", value);
			Console.WriteLine("123456789012345678901234567890");
		}
	}
}

/*C : 통화
D : 십진수(정수)
E : 지수(과학)
G : 일반
N : 천 단위 구분 기호 숫자
P : 퍼센트
R : 라운드트립
X : 16진수*/
