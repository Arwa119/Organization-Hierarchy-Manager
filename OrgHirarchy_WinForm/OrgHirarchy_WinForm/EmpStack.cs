using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgHirarchy_WinForm
{
    internal class EmpStack<T>
    {
        private T[] items;
        private int top;
        private int capacity;

        public EmpStack(int size)
        {
            capacity = size;
            items = new T[capacity];
            top = -1;
        } 

        public void Push(T item)
        {
            if (top == capacity - 1)
            {
                throw new InvalidOperationException("Stack Overflow");
            }
            items[++top] = item;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");

            }
            return items[top];
        }
        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Count()
        {
            return top + 1;
        }
        public void Clear()
        {
            top = -1;
        }
    }
}
