using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Exer12regw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sTitle = "Unit Converter - Reg Westly\n";
            char cChoice = ' ';
            bool bQuit = false;
            int iNum = 0;
            double dNum = 0.0;

            Console.CursorLeft = (Console.WindowWidth - sTitle.Length) / 2;
            Console.WriteLine(sTitle);

            do
            {
                cChoice = Menu();
                switch (cChoice)
                {
                    case 'a':
                        GetNumbers("\nPlease enter feet value: ", ref iNum, 0, 1000, "\nEnter the inches value: ", ref dNum, 0, 12);
                        Console.WriteLine($"\nThe length of {iNum} feet and {dNum:n2} inches is equal to {Length(iNum, dNum):n2} meters.");
                        Console.Write("Press any key to continue");
                        Console.ReadKey(true);
                    break;
                            
                    case 'b':
                        GetNumbers("\nPlease enter pound value: ", ref iNum, 0, 1000, "\nEnter the ounce value: ", ref dNum, 0, 16);
                        Console.WriteLine($"\nThe length of {iNum} pounds and {dNum:n2} ounces is equal to {Weight(iNum, dNum):n2} kilograms.");
                        Console.Write("Press any key to continue");
                        Console.ReadKey(true);
                        break; 
                    
                    case 'c':
                        GetNumbers("\nPlease enter cups value: ", ref iNum, 0, 1000, "\nEnter the liquid ounces value: ", ref dNum, 0, 8);
                        Console.WriteLine($"\nThe length of {iNum} cups and {dNum:n2} liquid ounces is equal to {Volume(iNum, dNum):n2} liters");
                        Console.Write("Press any key to continue");
                        Console.ReadKey(true);
                        break;
                    
                    case 'd':
                        bQuit = true;
                    break;

                    default:
                        Console.WriteLine("\nAn error has occured... invalid choice");
                        Console.Write("Press any key to continue");
                        Console.ReadKey(true);
                        break;
                }
            }
            while (!bQuit);
        }

        static char Menu()
        {
            char c = ' ';

            do
            {
                Console.Clear();
                Console.WriteLine("\na) Length Calculation");
                Console.WriteLine("b) Weight Calculation");
                Console.WriteLine("c) Volume Calculation");
                Console.WriteLine("d) Quit");
                Console.WriteLine("\nPress a, b, c, or d");

                c = char.ToLower(Console.ReadKey(true).KeyChar);
                if (c != 'a' && c != 'b' && c != 'c' && c != 'd')
                {
                    Console.WriteLine("\nPlease select either a,b,c,or d\n");
                }
            }
            while (c != 'a' && c != 'b' && c != 'c' && c != 'd');

            return c;
        }

        static int GetInt(string sMessage, int iLowValue, int iHighValue) 
        {
            int iNum = 0;
            do
            {
                Console.Write(sMessage);
                if(!int.TryParse(Console.ReadLine(), out iNum))
                {
                    Console.WriteLine("\nThis is not a valid number.\n");
                    iNum = iLowValue - 1;
                }
                else if (iNum < iLowValue)
                {
                    Console.WriteLine($"\nNumber too low. Please enter a number between {iLowValue} and {iHighValue}.\n");
                }
                else if (iNum > iHighValue) 
                {
                    Console.WriteLine($"\nNumber too high. Please enter a number between {iLowValue} and {iHighValue}.\n");
                }
            }
            while(iNum < iLowValue ||  iNum > iHighValue);
            
            return iNum;
        }

        static double GetDouble(string sMessage, double dLowValue, double dHighValue)
        {
            double dNum = 0;
            do
            {
                Console.Write(sMessage);
                if (!double.TryParse(Console.ReadLine(), out dNum))
                {
                    Console.WriteLine("\nThis is not a valid number.\n");
                    dNum = dLowValue - 1;
                }
                else if (dNum < dLowValue)
                {
                    Console.WriteLine($"\nNumber too low. Please enter a number between {dLowValue:n2} and {dHighValue:n2}.\n");
                }
                else if (dNum > dHighValue)
                {
                    Console.WriteLine($"\nNumber too high. Please enter a number between {dLowValue:n2} and {dHighValue:n2}.\n");
                }
            }
            while (dNum < dLowValue || dNum > dHighValue);

            return dNum;
        }

        static double Length(int iFeet, double dInches) // 12 inches in foot - 1 inch is 0.0254
        {
            return (iFeet * 12 + dInches) * 0.254;
        }

        static double Weight(int iPounds, double dOunces) // 16 ounces in a pound  - 1 ounce is 0.0283495231 Kg
        {
            return (iPounds * 16 + dOunces) * 0.0283495231;
        }

        static double Volume(int iCups, double dOunces)  // 8 fluid ounces in a cup - 1 ounce = 0.0295735296 L
        {
            return (iCups * 8 + dOunces) * 0.0295735296;
        }

        static void GetNumbers (string sFirstMessage, ref int iNumber, int iLow, int iHigh, string sSecondMessage, ref double dNumber, double dLow, double dHigh)
        {
            iNumber = GetInt(sFirstMessage, iLow, iHigh);
            dNumber = GetDouble(sSecondMessage, dLow, dHigh);
            return;
        }

    }
}
