using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_4_6
    // for 반복문으로 곱셈
    // 1부터 20까지 곱하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = 1;

            for (int i = 1; i <= 20; i++)
            {
                output *= i;
            }
            Console.WriteLine(output);
            Console.WriteLine("컴퓨터공학과, 20210845, 2학년, 홀수반, 서예빈");
        }
        
    }
}
