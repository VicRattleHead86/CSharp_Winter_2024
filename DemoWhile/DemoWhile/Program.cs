/*
 * Reg Westly 
 * While loop
 * Jan 30, 2024
 * 
 * 
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
            int iNum = -999;                                    // intentionally outside range;
            double dNum = -999.99;                               // intentionally outside range
            string sName = "";
            bool bTry = true;

            int iLowValue = 10;             // acceptable range
            int iHighValue = 20;
            string sIMessage = $"\nEnter a whole number between {iLowValue} and {iHighValue}: ";

            double dLowValue = 0.0;         // acceptable range
            double dHighValue = 100.0;
            string sDMessage = $"\nEnter a number between {dLowValue:N2} and {dHighValue:N2}: ";

            while (bTry)
            {
                // Input validation

                //Integer Number
                while ((iNum < iLowValue) || (iNum > iHighValue))
                {
                    Console.Write(sIMessage);
                    if (!int.TryParse(Console.ReadLine(), out iNum))
                    {
                        Console.WriteLine("This is not a valid whole number");      // not an integer;
                        iNum = -999;
                    }
                    else if ((iNum < iLowValue) || (iNum > iHighValue))
                    {
                        Console.WriteLine("This number is outside the acceptable range.");
                    }
                }   

                //Double number
                while ((dNum < dLowValue) || (dNum > dHighValue))
                {
                    Console.Write(sDMessage);
                    if (!double.TryParse(Console.ReadLine(), out dNum))
                    {
                        Console.WriteLine("that is not a valid number");
                        dNum = -999.99;
                    }
                    else if ((dNum < dLowValue) || ( dNum > dHighValue))
                    {
                        Console.WriteLine($"This number is outside the acceptable range of {dLowValue:N2} and {dHighValue:N2}");
                    }
                }









                Console.Write("\nWould you like to try again? (y): ");
                sName = Console.ReadLine().ToLower();
                if (sName != "y")
                {
                    bTry = false;
                    Console.WriteLine("\n\nProgram quiting now");
                    Thread.Sleep(1000);                                 // wait one second
                }
                else
                {
                    bTry = true;
                }
            }
        }
    }
}
