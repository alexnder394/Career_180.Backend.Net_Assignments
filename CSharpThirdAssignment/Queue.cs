using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpThirdAssignment
{
    public class Queue
    {
        int size;
        int front;
        int rear;
        int[] arr;
        public static int count = 0; // Initialize once, globally for all instances

        public Queue(int _size)
        {
            size = _size;
            arr = new int[size];
            front = rear = 0;
            count++;
        }

        public void Enqueue(int data)
        {
            if (rear == size)
            {
                Console.WriteLine("Queue Is Full!");
                return;
            }

            arr[rear++] = data;
        }

        public int? Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue Is Empty!");
                front = rear = 0; // Reset pointers
                return null;
            }

            return arr[front++];
        }

    }
}
