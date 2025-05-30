using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections.StackYapisi
{
    public class MyStack<T>
    {
        int _size;
        int count;
        Node<T> top;
        public MyStack(int size)
        {
            _size = size;
            count = 0;
            top = null;
        }

        //**********Push Method************
        public void Push(T value)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is Full!");
            }
            else
            {
                Node<T> newNode =new Node<T>(value) ;
                if (isEmpty())
                {
                   top = newNode;
                }
                else
                {
                    newNode.Next = top;
                    top = newNode;
                }
                count++;
            }
        }

        //**********Pop Method************
        public T Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty!");
                return default(T);
            }
            else
            {
                T value = top.Value;
                top = top.Next;
               count--;
                return value;
            }
        }

        //**********Peek Method************
        public T Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty!");
                return default(T);
            }
            else
            {
                return top.Value;
            }
        }

        //**********Size Method************
        public int Size()
        { 
            return count;
        }

        //**********isFull Method************
        public bool isFull()
        {  
            return count == _size;
        }

        //**********isEmpty Method************
        public bool isEmpty()
        {
          return count == 0;
        }

        //**********Print Mehtod************
        public void Print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty!");
            }
            else
            {
                Node<T> current = top;
                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
                
            }
        }
    }
}
