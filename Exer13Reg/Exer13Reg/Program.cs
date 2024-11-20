using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exer13Reg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dANum = 0.0;
            double dBNum = 0.0;
            double dCNum = 0.0;
            double dRoot1 = 0.0;
            double dRoot2 = 0.0;
            int iMaxMin = 76;
            string sTitle = "Quadratic Roots\n";
            string sMessage = "Enter the value for the coefficient ";
            string sChoice = "";

            do
            {
                Console.Clear();
                Console.CursorLeft = (Console.WindowWidth - sTitle.Length) / 2;
                Console.WriteLine(sTitle);

                dANum = GetDouble(sMessage + "a: ");
                dBNum = GetDouble(sMessage + "b: ");
                dCNum = GetDouble(sMessage + "c: ");

                if(Roots(dANum, dBNum, dCNum, ref dRoot1, ref dRoot2))
                {
                    Console.WriteLine($"\nThe roots of the equation are {dRoot1:F1}, and {dRoot2:F1}\n");
                }
                else
                {
                    Console.WriteLine("\nThe roots could not be calculated.\n");
                }
                Console.WriteLine("Run again? yes or no:");
            }
            while (Console.ReadLine().ToLower() == "yes");
        }

        static double GetDouble(string sDMessage)
        {
            double dNum = 0.0;
            Console.Write($"{sDMessage}");
            while(!double.TryParse(Console.ReadLine(), out dNum))
            {
                Console.WriteLine("\nYou have entered an invalid number, Please try again.\n");
                Console.Write($"{sDMessage}");
            }
            return dNum;
        }

        static bool Roots(double dA, double dB, double dC, ref double x1, ref double x2)
        {
            bool bRoot = false;

            double d = (dB * dB) - (4 * dA * dC);  // Calculating the discriminant

            if (d == 0)  // Checking if the discriminant is equal to 0
            {
                //Console.Write("Both roots are equal.\n");  // Printing a message if both roots are equal
                x1 = -dB / (2.0 * dA);  // Calculating the root when discriminant is zero
                x2 = x1;  // Assigning the same root to x2
                //Console.Write("First Root Root1= {0}\n", x1);  // Printing the root when discriminant is zero
                //Console.Write("Second Root Root2= {0}\n", x2);  // Printing the root when discriminant is zero
                bRoot = true;
            }
            else if (d > 0)  // Checking if the discriminant is greater than 0
            {
                //Console.Write("Both roots are real and different.\n");  // Printing a message if roots are real and different
                x1 = (-dB + Math.Sqrt(d)) / (2 * dA);  // Calculating the first root
                x2 = (-dB - Math.Sqrt(d)) / (2 * dA);  // Calculating the second root
                //Console.Write("First Root Root1= {0}\n", x1);  // Printing the first root
                //Console.Write("Second Root Root2= {0}\n", x2);  // Printing the second root
                bRoot = true;
            }
            else
            {
                //Console.Write("Roots are imaginary;\nNo Solution. \n\n");  // Printing a message if roots are imaginary
                bRoot = false;
            }
            return bRoot;
        }
    }
}
