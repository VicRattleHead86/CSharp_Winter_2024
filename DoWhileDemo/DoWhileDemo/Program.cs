/*
 * Reg Westly 
 * Do While Demo
 * Jan 30, 2024
 * 
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
using System.Threading.Tasks;

namespace DoWhileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iValue = 0;
            int iMin = 0;
            int iMax = 10;
            double dValue = 0.0;
            double dMin = 0.0;
            double dMax = 100.0;
            string sIMessage = $"\nPlease enter a number between {iMin} and {iMax}: ";
            string sDMessage = $"\nPlease enter a number between {dMin:N2} and {dMax:N2}: ";

            bool bValid = true;
            char cRepeat = 'n';

            do
            {
                Console.Clear();

                do                                                  // Input validation for integer
                {
                    Console.Write(sIMessage);
                    k = true;
                    if (!int.TryParse(Console.ReadLine(), out iValue))
                    {
                        Console.WriteLine("An invalid number was entered. Please try again.");
                        bValid = false;
                    }
                    else if (iValue < iMin)
                    {
                        Console.WriteLine("The value entered is below the accepted range.");
                        bValid = false;
                    }
                    else if (iValue > iMax)
                    {
                        Console.WriteLine("The value entered is above the accepted range.");
                        bValid = false;
                    }
                }
                while (!bValid);

                do                                                      // input validation for double
                {
                    Console.Write(sDMessage);
                    bValid = true;
                    if (!double.TryParse(Console.ReadLine(), out dValue))
                    {
                        Console.WriteLine("An invalid number was entered. Please try again.");
                        bValid = false;
                    }
                    else if (dValue < dMin)
                    {
                        Console.WriteLine("The value entered is below the accepted range.");
                        bValid = false;
                    }
                    else if (dValue > dMax)
                    {
                        Console.WriteLine("The value entered is above the accepted range.");
                        bValid = false;
                    }
                }
                while (!bValid);







                Console.WriteLine("\nDo you want to play again? (y): ");
                cRepeat = char.ToLower(Console.ReadKey().KeyChar);
            }
            while (cRepeat == 'y');
        }
    }
}
