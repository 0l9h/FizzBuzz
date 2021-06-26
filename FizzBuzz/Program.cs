using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter start value:");
                int v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter finish value:");
                int v2 = int.Parse(Console.ReadLine());
                FizzBuzz fb = new FizzBuzz(v1, v2);
                fb.Play();
            }
            catch(FizzBuzzOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
