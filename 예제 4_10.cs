using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_4_10
    // foreach 반복문과 var 키워드
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수 선언
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            // 반복 수행
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("컴퓨터공학과, 20210845, 2학년, 홀수반, 서예빈");
        }  
            
    }    
}
