using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {         
                int v1 = int.Parse(args[0]);
                int v2 = int.Parse(args[1]);
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
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Please specify range of values");
            }
        }
    }
}
