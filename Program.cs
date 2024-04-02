namespace Candelaria_Frinna_Number_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int A = 1; A < 101; A++)
            {
                if (A % 15 == 0)
                {
                    Console.WriteLine("Hello Goodbye");
                }
                else if (A % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }
                else if (A % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                else
                {
                    Console.WriteLine(A);
                }
            }
        }
    }
}