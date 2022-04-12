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
           for(int Line = 0; Line < 10; Line++)
            {
                for(int blank = 0; blank<10-Line; blank++)
                    Console.Write(' ');
                for(int star = 0; star < 2*Line -1; star++)
                    Console.Write('*');
                Console.Write('\n');
            }
            

        }

    }



}

