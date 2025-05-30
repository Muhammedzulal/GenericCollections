using System;
using GenericCollections.ListeYapisi;
using GenericCollections.StackYapisi;
using GenericCollections.QueueYapisi;
namespace GenericCollections
{
    public class Program
    {
        static void Main(string[] args)
        {

            Liste<Vehicle> carList = new Liste<Vehicle>();
           carList.SonaEkle(new Car("Toyota", 2020));
            //carList.SonaEkle(new Truck("Ford", 5));
            //carList.SonaEkle(new Motorcycle("Yamaha", 600));
            //carList.SonaEkle(new Bus("Mercedes", 50));
            //carList.SonaEkle(new Bicycle("Giant", 21));
        carList.Yazdir();
            //TestList();
            //TestStack();
            //QueueTest();
        }

        //Liste sınıfını test etmek için kullanılacak metot
        public static void TestList()
        {
            Liste<int> liste = new Liste<int>();
            int choose = -1;
            while (choose != 0)
            {
                Console.WriteLine();
                Console.WriteLine("1-Sona Ekle");
                Console.WriteLine("2-Başa Ekle");
                Console.WriteLine("3-Araya Ekle");
                Console.WriteLine("4-Baştan Silme");
                Console.WriteLine("5-Sondan Silme");
                Console.WriteLine("6-Aradan Silme");
                Console.WriteLine("7-Listeyi Yazdırma");
                Console.WriteLine("8-Listeyi Temizleme");
                Console.WriteLine("0-Çıkış");
                Console.Write("Seçiminizi yapınız: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.Write("Sona eklenecek elemanı giriniz: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        liste.SonaEkle(value);
                        liste.Yazdir();
                        break;
                    case 2:
                        Console.Write("Başa eklenecek elemanı giriniz: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        liste.BasaEkle(value);
                        liste.Yazdir();
                        break;
                    case 3:
                        Console.Write("Araya eklenecek elemanı giriniz: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Eklemek istediğiniz indexi giriniz: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        liste.ArayaEkle(value, index);
                        liste.Yazdir();
                        break;
                    case 4:
                        liste.BastanSil();
                        liste.Yazdir();
                        break;
                    case 5:
                        liste.SondanSil();
                        liste.Yazdir();
                        break;
                    case 6:
                        Console.Write("Silmek istediğiniz indexi giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        liste.AradanSil(index);
                        liste.Yazdir();
                        break;
                    case 7:
                        liste.Yazdir();
                        break;
                    case 8:
                        liste.Temizle();
                        break;
                    case 0:
                        Console.WriteLine("Çıkılıyor...");
                        break;
                }
            }
        }

        //Stack sınıfını test etmek için kullanılacak metot
        public static void TestStack()
        {
            MyStack<int> myStack = new MyStack<int>(5);
            int choose = -1;
            while (choose != 0)
            {
                Console.WriteLine();
                Console.WriteLine("1-Push");
                Console.WriteLine("2-Pop");
                Console.WriteLine("3-Peek");
                Console.WriteLine("4-Size");
                Console.WriteLine("5-isFull");
                Console.WriteLine("6-isEmpty");
                Console.WriteLine("7-Listeyi Yazdırma");
                Console.WriteLine("0-Çıkış");
                Console.Write("Seçiminizi yapınız: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.Write("Push edilecek elemanı giriniz: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        myStack.Push(value);
                        Console.WriteLine();
                        myStack.Print();
                        break;
                    case 2:
                        myStack.Pop();
                        Console.WriteLine();
                        myStack.Print();
                        break;
                    case 3:
                        Console.WriteLine("\n[" + myStack.Peek() + "]");
                        Console.WriteLine();
                        myStack.Print();
                        break;
                    case 4:
                        Console.WriteLine("\nSize :" + myStack.Size());
                        break;
                    case 5:
                        Console.WriteLine("\n" + myStack.isFull());
                        break;
                    case 6:
                        Console.WriteLine("\n" + myStack.isEmpty());
                        break;
                    case 7:
                        Console.WriteLine();
                        myStack.Print();
                        break;
                    case 0:
                        Console.WriteLine("Çıkılıyor...");
                        break;
                }
            }
        }

        //Queue sınıfını test etmek için kullanılacak metot
        public static void QueueTest()
        {
            MyQueue<int> myQueue = new MyQueue<int>(5);
            int choose = -1;
            while (choose != 0)
            {
                Console.WriteLine();
                Console.WriteLine("1-enQueue");
                Console.WriteLine("2-deQueue");
                Console.WriteLine("3-Peek");
                Console.WriteLine("4-Size");
                Console.WriteLine("5-isFull");
                Console.WriteLine("6-isEmpty");
                Console.WriteLine("7-Listeyi Yazdırma");
                Console.WriteLine("0-Çıkış");
                Console.Write("Seçiminizi yapınız: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.Write("enQueue edilecek elemanı giriniz: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        myQueue.Enqueue(value);
                        Console.WriteLine();
                        myQueue.Print();
                        break;
                    case 2:
                        myQueue.Dequeue();
                        Console.WriteLine();
                        myQueue.Print();
                        break;
                    case 3:
                        Console.WriteLine("\n["+myQueue.Peek()+"]");
                        Console.WriteLine();
                        myQueue.Print();
                        break;
                    case 4:
                        Console.WriteLine("\nSize :"+myQueue.Size());
                        break;
                    case 5:
                        Console.WriteLine("\n"+myQueue.isFull());
                        break;
                    case 6:
                        Console.WriteLine("\n" + myQueue.isEmpty());
                        break;
                    case 7:
                        Console.WriteLine();
                        myQueue.Print();
                        break;
                    case 0:
                        Console.WriteLine("Çıkılıyor...");
                        break;
                }
            }
        }
    }
}
