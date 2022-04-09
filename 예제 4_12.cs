using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_4_12
    // 별 찍기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(' '); //공백 출력
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*'); // * 출력

                Console.Write('\n'); // 개행
                
            }
            Console.WriteLine("컴퓨터공학과, 20210845, 2학년, 홀수반, 서예빈");
        }
    }
}
