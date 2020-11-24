using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void ReferenceTypes()
        {
            // Strings
            string stringExample = "This is a string.";
            string name = "Rafael";

            string declared;
            declared = "Now it;'s initialized.";

            // Formatting strings
            string concatenate = stringExample + " " + name; //This is a string. Rafael
            string interpolate = $"{name}. here is the string: {stringExample}."; //Rafael. here is a string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(1975, 4, 29); //() parenthesis is the constructor - new is a keyword
            
            TimeSpan waitTime = randomDate - now; // used to find difference between time (time Interval)
                            
            //dot operator and property below
            Console.WriteLine(waitTime.TotalSeconds);

            //--Collections are also reference types
            // Arrays -not normally used in C Sharp
            string anotherExampleString = "Hello World"; // this is a string
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" }; // square brackets defines an array
            string[] students = new string[15];

            Console.WriteLine(students); //outputs stringArray[]

            // Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence"); // no predetermined size //collection of similar types. normally how arrays work in other languages


            //Quees
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //Dictionaries have to give key and value
                        //key //value    
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh"); //use J to get value of josh - (key&door)

            //Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();

            

           




        }
    }
}
