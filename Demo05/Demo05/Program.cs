/*
 * Reg Westly 
 * Demo 05
 * 
 * Jan 22, 2024
 * Branching Demo
 * 
 * Pseudo
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

namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string sCarInput = "";              // For entering car type
            const string car = "car";           // Constants for the types
            const string truck = "truck";
            const string suv = "suv";
            const string minivan = "minivan";
            const string electric = "electric";
            int iAge = 0;                       // for entering age
            int iUpperRange = 600;              // upper range for conditional check
            int iLowerRange = 0;                // lower range for conditional check
            int iNumber = 0;                    // number to get and check

            // If
            Console.Write("Please enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out iAge))
            {
                Console.WriteLine("Invalid Age");
            }

            // if (then) else
            if (iAge < 18)
            {
                Console.WriteLine("Too young");
            }
            else
            {
                Console.WriteLine("You are old enough");
            }

            // else if
            Console.Write("What type of vehicle do you want (car, truck, suv, minivan, or electric): ");
            sCarInput = Console.ReadLine().ToLower();
            
            if (sCarInput == car)
            {
                Console.WriteLine("You want to buy a Car");
            }
            else if(sCarInput == truck)
            {
                Console.WriteLine("You want to buy a Truck");
            }
            else if (sCarInput == suv)
            {
                Console.WriteLine("You want to buy a SUV");
            }
            else if (sCarInput == minivan)
            {
                Console.WriteLine("You want to buy a Minivan");
            }
            else if (sCarInput == electric)
            {
                Console.WriteLine("You want to buy a Electric");
            }
            else
            {
                Console.WriteLine("Your selection is not one of the allowed");
            }

            // Switch
            switch (sCarInput)
            {
                case car:
                    Console.WriteLine("Switch Car");
                    break;
                case truck:
                    Console.WriteLine("Switch Truck");
                    break;
                case suv:
                    Console.WriteLine("Switch SUV");
                    break;
                case minivan:
                    Console.WriteLine("Switch Minivan");
                    break;
                case electric:
                    Console.WriteLine("Switch Electric");
                    break;
                default:
                    Console.WriteLine("Switch Invalid Choice");
                    break;
            }

            // Conditional check - to keep inputs in a range
            Console.Write($"Please enter your number between {iLowerRange} and {iUpperRange}: ");
            int.TryParse( Console.ReadLine(), out iNumber);
            iNumber = (iNumber < iLowerRange) ? iLowerRange : iNumber;              // check lower range
            iNumber = (iNumber > iUpperRange) ? iUpperRange : iNumber;              // Check upper range
            Console.WriteLine($"The value is now {iNumber}");




            Console.WriteLine("Press <any> key to quit");
            Console.ReadKey();

        }
    }
}
