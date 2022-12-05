

namespace Day13_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int intArray = MaxNumberCheck.MaxIntegerNumber(23, 42, 12);
            Console.WriteLine("\nMax integer number is: " + intArray);

            double MaxFloat = MaxNumberCheck.MaxFloatNumber(33.2, 23.4, 12.5);
            Console.WriteLine("\nMax float number is: " + MaxFloat);

            string strArr = MaxNumberCheck.MaxStringNumber("karan", "chetan", "yogesh");
            Console.WriteLine("\nMax string is: " + strArr);

        }
    }
}