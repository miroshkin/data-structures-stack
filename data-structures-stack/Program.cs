using System;
using System.Collections;

namespace data_structures_stack
{
    class Program
    {
        static void Main(string[] args)
        {

            var stringStack = new CustomStack<string>(4);

            stringStack.Push("1");
            stringStack.Push("2");
            stringStack.Push("3");
            stringStack.Push("4");

            var item = stringStack.Pop();
            Console.WriteLine($"Item value: {item}");



            Stack s = new Stack(4);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);
        }
    }
}
