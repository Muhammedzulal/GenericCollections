using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections.QueueYapisi
{
    public class MyQueue<T>
    {
        Node<T> front;
        Node<T> rear;
        int size;
        int count;
       public MyQueue(int size)
        {
            this.size = size;
            front = null;
            rear = null;
            count = 0;
        }
        //********** Enqueue **********
        public void Enqueue(T value)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full!");
                return;
            }
            Node<T> newNode = new Node<T>(value);
            if (isEmpty())
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            count++;
        }

        //********** Dequeue **********
        public T Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            T data = front.Value;
            front = front.Next;
            count--;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }

        //********** Peek **********
        public T Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return front.Value;
        }

        //********** IsFull **********
        public bool isFull()
        {
            return count == size;
        }
        
        //********** IsEmpty **********
        public bool isEmpty()
        {
            return count == 0;
        }

        //********** Size **********
        public int Size()
        {
            return count;
        }

        //********** Print **********
        public void Print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return;
            }
            Node<T> current = front;
            while (current != null)
            {
                Console.Write(current.Value + "<--");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
