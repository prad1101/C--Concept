namespace Delegates
{
    public delegate void printdelegate();
    public class Program
    {
        static void Main(string[] args)
        {

            printdelegate p = new printdelegate(print);
            Practice.Test(p);
        }

        private static void print()
        {
            Console.WriteLine("this is the print method");
        }
    }

    class Practice
    {
        public static void Test(printdelegate p)
        {
            p();
        }

    }
}
