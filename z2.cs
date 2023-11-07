using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_z2
{
    internal class z2
    {
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                Data = data;
            }
        }
        public class Queue<T>
        {
            private Node<T> head;
            private Node<T> tail;
            private int countt;

            public Queue()
            {
                countt = 0;
            }
            public bool IsEmpty()
            {
                return countt == 0;
            }

            public int Size()
            {
                return countt;
            }
            public void Push(T data)
            {
                Node<T> node = new Node<T>(data);
                Node<T> tempNode = tail;
                tail = node;
                if (countt == 0)
                    head = tail;
                else
                    tempNode.Next = tail;
                countt++;
                Console.WriteLine("ok");
            }
            public T Pop()
            {
                if (countt == 0)
                {
                    Console.WriteLine("Error");
                }
                T output = head.Data;
                head = head.Next;
                countt--;
                return output;
            }
            public T Front()
            {
                if (IsEmpty())
                {
                   
                    Console.WriteLine("Error");
                }
                return head.Data;
            }
            public void Clear()
            {
                while (!IsEmpty()) Pop();

            }

            public void Exit()
            {
                Clear();
                Console.WriteLine("bye");
            }
        }

        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Push(1);
            int a = queue.Front();
            Console.WriteLine(a);
            queue.Exit();
        }
    }
}
