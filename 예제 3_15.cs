using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("입력: ");
            string input = Console.ReadLine();

            if(input.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요!");
            }
            else
            {
                Console.WriteLine("^^");
            }
            
        }

    }



}

