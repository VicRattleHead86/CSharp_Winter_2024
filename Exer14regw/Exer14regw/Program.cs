using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer14regw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sTitle = "Array - Reg Westly\n";
            string sChoice = "y";
            int iSizeArray = 0;
            int iSmallest = 99999999;
            int iLargest = -1;
            int iCountLess50 = 0;
            int iIndexLargest = 99999;
            int iIndexSmallest = 99999;
            int iSumofArray = 0;
            Random random = new Random();
            int[] intArray;    // create array

            Console.CursorLeft = (Console.WindowWidth - sTitle.Length) / 2;
            Console.WriteLine(sTitle);

            do
            {
                iSmallest = 99999;
                iLargest = -1;
                iCountLess50 = 0;
                iSumofArray = 0;

                GetValue(out iSizeArray, "Please enter the size of the array: ");
                intArray = new int[iSizeArray];             // initialize Array of size iSizeArray
                Console.WriteLine("");

                for (int i = 0; i<iSizeArray; i++)              // loop to get array values and display
                {
                    intArray[i] = random.Next(0,101);           // get number between 0-100

                    if (i == iSizeArray - 1)
                        Console.WriteLine($"{intArray[i]}");    // if last one do not do ","
                    else
                        Console.Write($"{intArray[i]}, ");      

                    if (intArray[i] >= iLargest)                // find largest
                    {
                        iLargest = intArray[i];
                        iIndexLargest = i;
                    }

                    if (intArray[i] <= iSmallest)               // find smallest
                    {
                        iSmallest = intArray[i];
                        iIndexSmallest = i;
                    }

                    if (intArray[i] < 50)                       // count how many < 50
                        iCountLess50++;

                    iSumofArray += intArray[i];
                }

                Console.WriteLine($"\nThe Largest Number is {iLargest} at index {iIndexLargest}.");
                Console.WriteLine($"The Smallest Number is {iSmallest} at index {iIndexSmallest}.");
                Console.WriteLine($"The number of values < 50 is {iCountLess50}.");
                Console.WriteLine($"The sum of the array values is {iSumofArray}.");
                Console.WriteLine($"The average of the array values is {iSumofArray / iSizeArray}.\n");

                for( int i = iSizeArray - 1;i >= 0; i--)            // reverse order
                {
                    if (i == 0)
                        Console.WriteLine($"{intArray[i]}");
                    else
                        Console.Write($"{intArray[i]}, ");
                }



                Console.Write("\nDo you want to try again (y/n): ");
                sChoice = Console.ReadLine().ToLower();
            }
            while (sChoice == "y");
        }

        static void GetValue(out int iValue, string sMessage)
        {
            bool bValid = true;
            do
            {
                Console.Write(sMessage);
                bValid = true;
                if (!int.TryParse(Console.ReadLine(), out iValue))
                {
                    Console.WriteLine("An invalid number was entered. Please try again.");
                    bValid = false;
                }
            }
            while (!bValid);

            return;
        }
    }
}
