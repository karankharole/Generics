

namespace Day13_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int intArray = MaxNumberCheck<int>.MaxValue(23, 42, 12);
            Console.WriteLine("\nMax integer number is: " + intArray);

            double output = MaxNumberCheck<double>.MaxValue(33.2, 23.4, 12.5);
            Console.WriteLine("\nMax float number is: " + output);

            char strArr = MaxNumberCheck<char>.MaxValue('A', 'S', 'R');
            Console.WriteLine("\nMax string is: " + strArr);

        }
    }
}