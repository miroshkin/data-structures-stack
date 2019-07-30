using System;

namespace data_structures_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var customStack = new CustomStack<int>();

            customStack.Push(1);
            customStack.Push(2);
        }
    }
}
