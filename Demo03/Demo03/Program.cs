/*
 * Reg Westly
 * Demo 03
 * 
 * Jan 15,2024
 * Demo of Math 
 * 
 * pseudo Code:
 * 
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Section
            int iNum = 60;
            int iValue = 50;
            int iAnswer = 0;
            double dAnswer = 0.0;
            double dInch = 0.0;
            double dCm = 0.0;
            bool bConvertWorked = false;
            Random random = new Random();  
            

            Console.Clear();        // clear the console screen
            // Basic math
            iValue = 45;
            iValue = iValue + 10;  // add 10 to iValue
            iValue += 10;           // add 10 to iValue
            iValue++;               // pre or post does not matter if all you are doing is this
            ++iValue;               // pre or post does not matter if all you are doing is this
            iNum = iValue++;        // copy iValue into iNum, then add 1 to iValue
            Console.WriteLine(iValue + " " + iNum);

            iNum = random.Next(10);
            Console.WriteLine(iNum);

            dAnswer = random.NextDouble();
            //Console.WriteLine(Math.Round(dAnswer * 100.0,2));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"|{dAnswer,-20:P0}|iNum = {iNum,10}|");

            //interger answer divided by a double, producing a double...   Format Output\
            iAnswer = 343;
            Console.WriteLine("iAnswer/1.75: " + iAnswer / 1.75);
            Console.WriteLine("iAnswer/1.75: " + (iAnswer / 1.75).ToString("0.00")); //how to see results better
            Console.WriteLine($"Answer/1.75: {(iAnswer / 1.75):0.###} ");  // string formated
            Console.WriteLine($"Answer/1.75: {(iAnswer / 1.75):N2} ");  // string formated)


            Console.WriteLine("Press <enter> key to continue: ");
            Console.ReadLine();
        }
    }
}
