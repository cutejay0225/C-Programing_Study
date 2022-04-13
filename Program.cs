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
            bool state = true;
            while (state)
            {
                int x = 0;
                int y = 0;
                
                while (x < 50 && y<50)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    
                    switch (info.Key)
                    {
                        case ConsoleKey.RightArrow:
                            x++;                            
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.Write('@');
                            break;
                        case ConsoleKey.LeftArrow:
                            x--;                           
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.Write('@');
                            break;
                        case ConsoleKey.DownArrow:
                            y++;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.Write('@');
                            break;
                        case ConsoleKey.UpArrow:
                            y--;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.Write('@');
                            break;

                    }
       
                }
            }
            
        }

    }



}

