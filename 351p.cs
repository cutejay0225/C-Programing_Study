using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    namespace A
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }
        class child : Parent
        {
            public child()
            {
                Console.WriteLine("자식 생성자");
            }
        }

    }
    namespace B
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }
        class child : Parent
        {
            public child() : base()
            {
                Console.WriteLine("자식 생성자");
            }
        }

    }
    namespace C
    {
        class Parent
        {
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }
        }
        class Child : Parent
        {
            public Child() : base(10)
            {
                Console.WriteLine("child() : base(10)");
            }
            public Child(string input): base(input)
            {
                Console.WriteLine("child(string input):base(input)");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
