using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_stack
{
    public class CustomStack <T>
    {
        private T[] _stack;
        private int _capacity;
        private int top;

        public CustomStack(int size)
        {
            _stack = new T[size];
            _capacity = size;
        }

        public void Push (T item)
        {
            
        }

        public void Pop (T item)
        {

        }
    }
}
