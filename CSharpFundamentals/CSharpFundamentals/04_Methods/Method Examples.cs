using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methods
{
    [TestClass]
    public class UnitTest1
    {
        //input
        //what we do
        //output


        //access modifier - return type -  method signature (Name and list of parameters)

    
        public int AddTwoNumbers((int numone, int numtwo)
        {
            int sum = numOne + numTwo;
            return sum; 

        }
        [TestMethod]
        public void MethodTests()

        {
            int sum = AddTwoNumbers(7, 12);

        }
    }
}
