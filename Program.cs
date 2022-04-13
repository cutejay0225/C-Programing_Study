using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x<50)
            {
                Console.Clear(); // 콘솔 화면을 지우는 메서드
                Console.SetCursorPosition(x, 5); // 특정한 위치로 옮기는 메서드

                // 출력
                if (x % 3 == 0)
                    Console.WriteLine(" __@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100); // 100밀리초 정지
                x++; // x 증가
            }
        }

    }



}

