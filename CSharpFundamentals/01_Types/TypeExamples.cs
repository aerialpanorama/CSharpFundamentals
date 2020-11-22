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

        }
    }
}
