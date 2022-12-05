

namespace Day13_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H','E', 'L', 'L', 'O' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();

        }
    }
}