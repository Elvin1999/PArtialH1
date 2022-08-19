using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    //public class Worker
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Worker()
    //    {
    //        Console.WriteLine("Default constructor");
    //    }

    //    public Worker(int id, string name)
    //    {
    //        Id = id;
    //        Name = name;
    //    }
    //    static Worker()
    //    {
    //       //// throw new Exception("Some error occurred");
    //        Console.WriteLine(DateTime.Now);
    //        Console.WriteLine("Static Constructor");
    //    }
    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Worker worker1 = new Worker();
    //        Worker worker2 = new Worker();
    //        Worker worker3 = new Worker();
    //    }
    //}


//    class Car
//    {
//        public static DateTime GlobalStartTime;
//        static Car()
//        {
//            GlobalStartTime = DateTime.Now;
//            Console.WriteLine($@"Static constructor called
//            Global Start Time : {GlobalStartTime.ToLongTimeString()}");
//        }

//        public Car(int id)
//        {
//            Thread.Sleep(1500);
//            Id = id;
//        }

//        public int Id { get; set; }


//        public void Drive()
//        {
//            TimeSpan elapsedTime = DateTime.Now - GlobalStartTime;

//            Console.WriteLine($@"
//Car ID : {Id}  is starting its works
//{elapsedTime.Seconds} seconds
//after global start time 
//{GlobalStartTime.ToLongTimeString()}");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Car car = null;
//            for (int i = 0; i < 10; i++)
//            {
//                car = new Car(i);
//                Thread.Sleep(500);
//            }
//            car.Drive();
//        }
//    }


    class Program
    {
        static void Main(string[] args)
        {
            //Partial

            BankAccount bankAccount = new BankAccount(1, "Access Bank", 3000);
            bankAccount.ShowInfo();
            Console.WriteLine(BankAccount.Tax);
            bankAccount.CallTransferMoney(1500);
            bankAccount.ShowInfo();
        }
    }
}
