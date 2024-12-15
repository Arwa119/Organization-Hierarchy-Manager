using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgHirarchy_WinForm
{
    internal class EmpQueue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Enqueue(T item)
        {
            list.AddLast(item);
        }

        public T Dequeue()
        {
            if (list.Count > 0)
            {
                T value = list.First.Value;
                list.RemoveFirst();
                return value;
            }
            //Console.WriteLine("Queue is empty. No element to dequeue.");
            return default(T);
        }
        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public bool IsEmpty()
        {
            if (list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
