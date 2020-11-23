using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]  //pasquel case ValueTypes
        public void ValueTypes()
        {
            //   whole numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumnber = 16;
            int wholeNumber = 32;
            Int16 anotherSmallNumber = 16; 
            long largeWholeNumber = 64;

            //--Decimals
            float floatExamples = 1.234567f;
            double doubleExample = 1.237909;
            decimal decimalExample = 1.700000m;

            //Character
            char letter = 'R';
            char reTurn = '\n';

            //  Operators
            int numOne = 17;
            int numTwo = 2;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo; // 17 / 5 = 2
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; // 17 % 5 = 2
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");



        }
    }
}
