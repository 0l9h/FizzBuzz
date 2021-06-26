using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzOutOfRangeException : ApplicationException
    {
        public override string Message { get; } 
        public FizzBuzzOutOfRangeException()
        {
            Message = "Start value must be greater than 0 and less than finish value";
        }
    }
}
