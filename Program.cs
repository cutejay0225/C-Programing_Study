using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열을 생성
            int[] intArray = { 52, 273, 32, 65, 103 };

            // 배열의 0번째 요소를 변경
            intArray[0] = 0;

            // 요소를 출력
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine("컴퓨터공학과, 20210845, 2학년, 홀수반, 서예빈");
        }
    }
}
