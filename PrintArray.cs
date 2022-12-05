using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Generics
{
    internal class PrintArray<T>
    {

        //public static void toPrint<T>(T[] inputArray)
        public T[] inputArray;

        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void toPrint()
        {

            foreach (var element in inputArray)
            {
                System.Console.WriteLine(element);
            }
            Console.WriteLine("------------------------  ");
        }
    }
}
