using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgHirarchy_WinForm
{
   
        public class LinkedListNode<T>
        {
            public T Data { get; set; }
            public LinkedListNode<T> Next { get; set; }

            public LinkedListNode(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedListEmp<T>
        {
            private LinkedListNode<T> head;

            public void AddLast(T data)
            {
                var newNode = new LinkedListNode<T>(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    LinkedListNode<T> current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

        public bool RemoveNode(T data)
        {
            if (head == null) 
                return false;

            if (head.Data.Equals(data)) 
            {
                head = head.Next;
                return true;
            }

            LinkedListNode<T> current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    current.Next = current.Next.Next; 
                    return true;
                }
                current = current.Next;
            }
            return false; 
        }


        public List<T> ToList()
            {
                var list = new List<T>();
                LinkedListNode<T> current = head;
                while (current != null)
                {
                    list.Add(current.Data);
                    current = current.Next;
                }
                return list;
            }

            public int Count()
            {
                int count = 0;
                LinkedListNode<T> current = head;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }

            public bool IsEmpty()
            {
                return head == null;
            }
        }

    }

