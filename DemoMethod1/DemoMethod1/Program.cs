using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethod1
{
    internal class Program
    {
        // Global Variables go here



        static void Main(string[] args)
        {
            string sTitle = "Reg Westly - Demo Method 1\n";
            int iNumber = 0;
            double dNumber = 0;
            int iLow = 1;
            int iHigh = 10;

            DispTitle(sTitle);
            iNumber = GetNum($"Please enter an integer number between {iLow} - {iHigh}: ", iLow, iHigh);
            dNumber = GetNum($"\nEnter a positive number with a decimal point: ", 0.00);
            DispMultNums(iNumber, dNumber);
            PressAnyKey();
        }

        // Write my methods here
        static void DispTitle(string sMessage)
        {
            Console.CursorLeft = (Console.WindowWidth - sMessage.Length) / 2;
            Console.WriteLine(sMessage);
            return;
        }

        static int GetNum(string sIMessage, int iLowValue, int iHighValue)
        {
            int iNum = iLowValue - 1;

            while ((iNum < iLowValue) || (iNum > iHighValue))
            {
                Console.Write(sIMessage);
                if (!int.TryParse(Console.ReadLine(), out iNum))
                {
                    Console.WriteLine("This is not a valid whole number.\n");      // not an integer;
                    iNum = iLowValue - 1;
                }
                else if ((iNum < iLowValue) || (iNum > iHighValue))
                {
                    Console.WriteLine("This number is outside the acceptable range.\n");
                }
            }
            return iNum;
        }

        static double GetNum(string sDMessage, double dLowValue)
        {
            double dNum = dLowValue - 1.0;

            while (dNum < dLowValue)
            {
                Console.Write(sDMessage);
                if (!double.TryParse(Console.ReadLine(), out dNum))
                {
                    Console.WriteLine("that is not a valid number.\n");
                    dNum = dLowValue - 1.0;
                }
                else if (dNum < dLowValue)
                {
                    Console.WriteLine($"This number is negative.\n");
                }
            }
            return dNum;
        }

        static void DispMultNums(int iNum, double dNum)
        {
            Console.WriteLine($"\n{iNum} multiplied by {dNum:F2} is equal to {(iNum * dNum):F2}");
            return;
        }

        static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue: ");
            Console.ReadKey();
            return;
        }
    }
}

