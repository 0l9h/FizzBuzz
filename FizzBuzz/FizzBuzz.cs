using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzz
    {
        readonly int _lowerBound;
        readonly int _upperBound;

        public FizzBuzz()
        {
            _lowerBound = 1;
            _upperBound = 100;
        }

        public FizzBuzz(int v1, int v2)
        {
            if (v1 >= v2 || v1 <= 0) throw new FizzBuzzOutOfRangeException();
            _lowerBound = v1;
            _upperBound = v2;
        }

        public void Play()
        {
            for (int i = _lowerBound; i <= _upperBound; i++)
            {
                if (i % 15 == 0)     Console.WriteLine("FizzBuzz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else                 Console.WriteLine(i);
            }
        }
    }
}
