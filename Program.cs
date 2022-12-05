namespace Day13_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // GenericsProgram genericsProgram = new GenericsProgram();

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'S', 'E', 'L', 'L', 'O' };

            GenericsClass.toPrint(intArray);
            GenericsClass.toPrint(doubleArray);
            GenericsClass.toPrint(charArray);
        }
    }
}