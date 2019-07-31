using System;

namespace data_structures_stack
{
    public class CustomStack <T>
    {
        private T[] _stack;
        private uint _currentIndex;

        public CustomStack(uint capacity)
        {
            if (capacity == 0)
            {
                throw new Exception("Size of the stack can not be zero");
            }
            
            _stack = new T[capacity];
        }

        public void Push (T item)
        {
            if (_currentIndex >= _stack.Length)
            {
                throw new StackOverflowException();
            }

            _stack[_currentIndex] = item;

            _currentIndex++;
        }

        public T Pop ()
        {
            if (_currentIndex == 0)
            {
                throw  new InvalidOperationException("Stack is empty");
            }

            _currentIndex--;

            return _stack[_currentIndex];
        }

        public T Peek()
        {
            if (_currentIndex == 0)
            {
                throw  new InvalidOperationException("Stack is empty");
            }

            return _stack[_currentIndex - 1];
        }

    }
}
