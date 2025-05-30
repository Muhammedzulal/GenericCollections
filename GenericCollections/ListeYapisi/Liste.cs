using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections.ListeYapisi
{
    public class Liste<T>
    {
        Node<T> head=null;
        Node<T> tail=null;

        //**********Sona Ekleme**********
        public void SonaEkle(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }
        //**********Başa Ekleme**********
        public void BasaEkle(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head=newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }
        //**********Araya Ekleme**********
        public void ArayaEkle(int Index, T value)
        {
            if (Index < 0)
            {
                Console.WriteLine("Negatif bir indexe değer eklenemez!");
                return;
            }

            Node<T> newNode = new Node<T>(value);
            
            if (Index == 0)
            {
                BasaEkle(value);
                return;
            }
            Node<T> temp = head;
            for (int i = 0; i < Index-1; i++)
            {
                if (temp == null)
                {
                    Console.WriteLine("Index, listenin boyutundan büyük!");
                    return;
                }
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
            if (newNode.Next == null)
            {
                tail = newNode;
            }
            
        }
        //**********Sondan Sil**********
        public void SondanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste zaten boş!");
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                Node<T> temp=head;
                while (temp.Next != tail)
                {
                    temp = temp.Next;
                }
                tail = temp;
                tail.Next = null;
            }
        }
        //**********Baştan Sil**********
        public void BastanSil()
        {
            if(head == null)
            {
                Console.WriteLine("Liste zaten boş!");
                return ;
            }
            head = head.Next;
            if(head == null)
            {
                tail=null;
            }
        }
        //**********Aradan Sil**********
        public void AradanSil(int Index) {
            if (head == null)
            {
                Console.WriteLine("Liste zaten boş!");
                return;
            }
            if (Index == 0)
            {
                BastanSil();
                return;
            }
            Node<T> temp=head;
            for (int i = 0; i < Index-1; i++)
            {
                if (temp == null || temp.Next == null)
                {
                    Console.WriteLine("Index, listenin boyutundan büyük!");
                    return;
                }
                temp = temp.Next;
            }
            if (temp.Next == null)
            {
                Console.WriteLine("Index, listenin boyutundan büyük!");
                return;
            }
           temp.Next = temp.Next.Next;
            if (temp.Next == null)
            {
                tail = temp; // Eğer silinen son eleman ise tail'i güncelle
            }

        }
        //**********Temizleme**********
        public void Temizle()
        {
            head = null;
            tail = null;
        }
        //**********Yazdırma**********
        public void Yazdir()
        {
            Node<T> current = head;
            Console.Write("\n[");
            while (current != null)
            {
                Console.Write(current.Value);
                if (current.Next != null)
                {
                    Console.Write(", ");
                }
                current = current.Next;
            }
            Console.Write("]\n");
        }
    }
}
