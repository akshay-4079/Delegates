using System;
using Delegates;

namespace DelegatesMedium
{
    class MainClass:Program
    {
        static void Main(string[] args)
        {

            PrintHelper(PrintNumber, 10000);
            PrintHelper(PrintMoney, 10000);

        }
        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }

    }
}
