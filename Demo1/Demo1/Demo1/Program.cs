/*
 * Program Demo1
 * Function Demonstration of basic setup
 * 
 * Reg Westly
 * CMPE1300 A03
 * Jan 8, 2024
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int iCounterOfTheNumberOfBalls = 0;             // Counter for number of times
            string sBallName;                               // name of the ball
            bool bWork = false;                             // result of tryparse

            // Get the data
            Console.Write("Please enter the name of ball: ");
            sBallName = Console.ReadLine();
            Console.Write("Please enter the number of balls: ");
            bWork = int.TryParse(Console.ReadLine(), out iCounterOfTheNumberOfBalls);   // try to change input to integer result in variable
            
            // write out results
            Console.WriteLine("\n\n\n\t\t\t" + sBallName + " " + iCounterOfTheNumberOfBalls + " " + bWork);

            //Wait
            Console.ReadKey();
            
        }
    }
}
