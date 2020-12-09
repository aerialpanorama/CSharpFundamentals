using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()

        {
            int studentCount = 15;

            //1 Starting point
            //2 Condition that happens while true, keeps the loop running
            /// what happens after each loop
            //4 body of the loop, what happens each iteration
            /// for          //2                    //3
            for (int i = 0; i < studentCount; i++) // i = i + 1; -> i++
            {
                //4
                Console.WriteLine(i);
            }
        }
        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Eleven Fifty Academy";

            //1 Collection that's being worked on
            //2 Name of the current iteration being used
            //3 current type in the collection
            //4 in keyword, use to seperate the individual and the collection
            //5 Body of the loop

            //foreach //3 //2 //4 //1
            foreach (char letter in name) ; // 5
            {
            Console.WriteLine(letter); //5

            }
            [TestMethod]

            Public void WhileLoops()
            {
                int total = 1;
                //1 Loop runs while the condition is true
                //2 The body of the loop

                //while //1
                while (total =  ! = 30)

                {
                    Console.WriteLine(total);
                    total++; //total = total + 1;
                }
            }

        }
    }
}
