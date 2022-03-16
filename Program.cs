
using System;

namespace LineComparison_OOPS
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program Using OOPS\n");

            //LengthCalculation lengthCalculation = new LengthCalculation();ssssss
            //lengthCalculation.LineLengthCalculation();

            //Equality equality = new Equality();
            //equality.EqualityOfTwoLengths();

            LengthCompare lengthCompare = new LengthCompare();
            lengthCompare.LengthComparisson();
        }
    }
}

