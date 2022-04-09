using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_4_8
    // 역 for 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열을 생성합니다
            int[] intArray = { 1, 2, 3, 4, 5, 6};

            // 요소의 길이를 출력합니다
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.WriteLine("컴퓨터공학과, 20210845, 2학년, 홀수반, 서예빈");
        }
    }
}
