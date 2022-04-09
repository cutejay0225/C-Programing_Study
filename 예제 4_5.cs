using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_4_5 
    // for 반복문으로 덧셈하기
    // 0부터 100까지 더하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수를 선언
            int output = 0;

            // 반복을 수행
            for (int i = 0; i <= 100; i++)
            {
                output += i;    // 누적
            }

            Console.WriteLine(output);
            Console.WriteLine("컴퓨터공학과, 20210845, 2학년, 홀수반, 서예빈");

        }
    }
}
