using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   string input;   // 입력 받아야할 때
            do
            {
                Console.Write("입력 (exit을 입력하면 종료): ");
                input = Console.ReadLine();
            } while (input != "exit");

            Console.WriteLine("컴퓨터공학과, 20210845, 2학년, 홀수반, 서예빈");
        }
    }
    
}
