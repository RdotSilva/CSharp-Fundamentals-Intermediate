using System;
using System.Dynamic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push("Cool");
            stack.Push(5);
            stack.Push("Ok");
            stack.Clear();
            stack.Push(true);
            stack.Push(2525);


            for (int i = 0; i < 5; i++)
                Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }
}
