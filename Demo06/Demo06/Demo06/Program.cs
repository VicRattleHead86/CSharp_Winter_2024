using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
            int iNum = 999;                                                                 // intentionally outside range
            double dNum = -999.99;                                                          // intentionally outside range
            string sName = "";
            bool bTry = true;

            int iLowValue = 10;                                                             // Acceptable range
            int iHighValue = 20;
            string sImessage = $"\nEnter a whole number between {iLowValue} and {iHighValue} ";

            double dLowValue = 0.0;                                                         // Aceeptable range
            double dHighValue = 100.0;
            string sDmessage = $"\nEnter a number between {dLowValue:N2} AND {dHighValue:N2} ";

            while (bTry)
            {
                // Input validation

                //Integer Number
                while ((iNum < iLowValue) || iNum > iHighValue)
                {
                    Console.Write(sImessage);
                    if (!int.TryParse(Console.ReadLine(), out iNum)) 
                        {
                            Console.WriteLine("This is not a valid whole number:");
                        }
                    else
                    {
                        Console.WriteLine("It's a whole number");
                    }
                }



                Console.WriteLine("\nWould you like to try again (y): ");
                sName += Console.ReadLine().ToLower();
                if (sName != "y")
                {
                    bTry = false;
                    Console.WriteLine("\n\nProgram quiting now");
                }
            }
 
        
        }
    }
}
