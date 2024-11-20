/*
 * Reg Westly
 * Demo 04
 * Jan 19, 2024
 * If then else and Console colouring
 * 
 * 
 * 
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
using System.Threading;
using System.Threading.Tasks;

namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bValid = false;
            bool bPasswordCorrect = false;
            string sPassword = "";
            string sSecret = "Password";
            string sTitle = $"Reg Westly Demo 04\n\n";
            string sName = "Name";
            char cLetter = 'A';
            char cJunk = ' ';
            double dAnswer = 0.0;
            int iNum = 23432;
            
            Console.CursorLeft = (Console.WindowWidth - sTitle.Length)/2;
            Console.WriteLine(sTitle);

            Console.Write("Please enter the password: ");
            sPassword = Console.ReadLine();
            if (sPassword == sSecret)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Your have entered the Password - Top Secret Security allowed");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("\rYour have entered the Password - Top Secret Security allowed");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\rYour have entered the Password - Top Secret Security allowed");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\rYour have entered the Password - Top Secret Security allowed");
                Thread.Sleep(500);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("You have not guessed the password - Low security level allowed");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("\rYou have not guessed the password - Low security level allowed");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\rYou have not guessed the password - Low security level allowed");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\rYou have not guessed the password - Low security level allowed");
                Thread.Sleep(500);
            }
            Console.ResetColor();

            Console.Write("Thank you!\n\nType Y or y to continue: ");
            cLetter = (char)Console.Read();                             // Reading a single character is 2 byte... so the first value read is the ASCII for 'y', but it also reads in two more bytes for the 'enter key'
            cJunk = (char)Console.Read();                               // Reads in the "enter" /r and /n key and tosses it away :)
            cJunk = (char)Console.Read();                               // So this makes it difficult to use Read()

            if (char.ToLower(cLetter) == 'y')
            {
                Console.Clear();
                Console.WriteLine("You want to continue!! Yeah.\n\nLet's look at some number formating");

                Console.Write("Please enter your name: ");
                sName = Console.ReadLine();                             // does not read??  see note above
                Console.WriteLine("I read your name as {0} in Uppercase and {1} in Lowercase", sName.ToUpper(), sName.ToLower());
                Console.Write("Please enter a double number: ");
                bValid = double.TryParse(Console.ReadLine(), out dAnswer);

                if (bValid)
                {
                    dAnswer /= 1.3333333;
                    Console.WriteLine("Let's write out dAnswer in various formats");
                    Console.WriteLine($"Writing out dAnswer without formating: {dAnswer}");
                    Console.WriteLine($"Writing out dAnswer with G5 formating: {dAnswer:G5}");
                    Console.WriteLine($"Writing out dAnswer with F2 formating: {dAnswer:F2}");
                    Console.WriteLine($"Writing out dAnswer with N3 formating: {dAnswer:N3}");
                    Console.WriteLine($"Writing out dAnswer with E formating: {dAnswer:E}");
                    Console.WriteLine($"Writing out dAnswer with C2 formating: {dAnswer:C2}");
                    Console.WriteLine("\nNow ones for Integer type");
                    Console.WriteLine($"Writing out iNum without formating: {iNum}");
                    Console.WriteLine($"Writing out iNum with D6 formating: {iNum:D6}");
                    Console.WriteLine($"Writing out iNum with X formating: {iNum:X}");
                    Console.WriteLine($"Writing out iNum with x6 formating: {iNum:x6}");
                }

            }

            Console.WriteLine("\nPress <any> key to quit: ");
            Console.ReadKey();
        }
    }
}
