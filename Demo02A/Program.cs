/*
 * Reg Westly
 * Demo 02
 * 
 * Jan 12, 2024
 * Demonstration of math, visual studio, inputs, outputs, formating
 * 
 * Pseudo Code
 *      Display titles
 *      prompt for number of eggs
 *      read number of eggs
 *      prompt for cost of each pack and save costs
 *      
 *      calculate how many of each pack using integer math
 *      calculate cost for the number of packs
 *      calculate the gst cost
 *      
 *      Display the total costs per pack, total cost, and total with GST
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            int iNumberOfEggs = 0;              // number of eggs needed
            int i30Cartons = 0;                 // how many 30 cartions needed
            int i12Cartons = 0;                 // how many 12 cartions needed
            int i6Cartons = 0;                  // how many 6 cartions needed
            int iLeft = 0;                      // how many eggs left over
            double dCost30 = 0.0;               // Cost per 30 Pack
            double dCost12 = 0.0;               // Cost per 12 Pack
            double dCost6 = 0.0;                // Cost per 6 Pack
            double dCost30Amount = 0.0;         // Cost of 30 packs needed
            double dCost12Amount = 0.0;         // Cost of 12 packs needed
            double dCost6Amount = 0.0;          // Cost of 6 packs needed
            double dGST = 0.05;                 // GST Value
            double dGSTAmount = 0.0;            // GST amount due
            double dTotal = 0.0;                // Total before GST
            double dTotalWithGST = 0.0;         // Total with GST
            string sTitle = "Reg Westly Demo02\n\n";  // Title message

            // Main program body
            Console.CursorLeft = (Console.WindowWidth - sTitle.Length) / 2;     // display the title in the middle
            Console.WriteLine(sTitle);

            // Prompt user for data
            Console.Write("How many eggs would you like to buy: ");
            iNumberOfEggs = int.Parse(Console.ReadLine());                      // Read string of number of eggs convert to int

            Console.Write("How much does a carton of 30 eggs cost: $");
            dCost30 = double.Parse(Console.ReadLine());                         // read in cost of 30 eggs
            Console.Write("How much does a carton of 12 eggs cost: $");
            dCost12 = double.Parse(Console.ReadLine());                         // read in cost of 12 eggs
            Console.Write("How much does a carton of 6 eggs cost: $");
            dCost6 = double.Parse(Console.ReadLine());                          // read in cost of 6 eggs

            // Caculate how many of each type of carton using Integer Math
            iLeft = iNumberOfEggs;
            i30Cartons = iLeft / 30;                                            // how many 30cartons
            iLeft %= 30;                                                        // how many left
            i12Cartons = iLeft / 12;                                            // how many 12cartons
            iLeft %= 12;                                                        // how many left
            i6Cartons = iLeft / 6;                                              // how many 6cartons
            iLeft %= 6;                                                         // how many left

            if (iLeft > 0)                                                      // branch if there are left overs and add 1 to 6Carton
                i6Cartons++;

            // Calculate how much for the different Carton
            dCost30Amount = i30Cartons * dCost30;               // calculate how much Cartons Cost
            dCost12Amount = i12Cartons * dCost12;
            dCost6Amount = i6Cartons * dCost6;
            dTotal = dCost30Amount + dCost12Amount + dCost6Amount; // Cost before GST
            dGSTAmount = dGST * dTotal;                             // how much GST to pay
            dTotalWithGST = dGSTAmount + dTotal;                    // grand total

            // Display Results
            Console.WriteLine($"\n\nThe total number of 30 carton packs is {i30Cartons} at a cost of {dCost30:C2} each for a total of {dCost30Amount:C2}");
            Console.WriteLine($"The total number of 12 carton packs is {i12Cartons} at a cost of {dCost12:C2} each for a total of {dCost12Amount:C2}");
            Console.WriteLine($"The total number of 6 carton packs is {i6Cartons} at a cost of {dCost6:C2} each for a total of {dCost6Amount:C2}");
            Console.WriteLine($"\n\nThe total cost of the packs is:\t\t\t{dTotal,9:C2}");   // Right Justify the total
            Console.WriteLine($"The GST of {dGST:P} gives a total GST due of:\t{dGSTAmount,9:C2}\n");
            Console.WriteLine($"The total cost to buy at least {iNumberOfEggs} eggs is:\t{dTotalWithGST,9:C2}\n");

            Console.Write("Press <any> key to continue: ");
            Console.ReadKey();
        }
    }
}
