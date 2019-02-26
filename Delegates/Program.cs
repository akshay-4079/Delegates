using System;

namespace Delegates
{
   public class Program
    {
        static void Main(string[] args)
        {
         
            Print printDel = PrintNumber;

    

            printDel(100000);
            printDel(200);

            printDel = PrintMoney;

            printDel(10000);
            printDel(200);
            printDel.Invoke(10000000);

        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

    }
}
