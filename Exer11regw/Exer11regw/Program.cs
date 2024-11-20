using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer11regw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sTitle = "String Encoder - Reg Westly\n";
            string sUserString = "";
            string sEncodedString = "";
            string sChoice = "";
            int iUnicode = 0;

            do
            {
                Console.Clear();
                Console.CursorLeft = (Console.WindowWidth - sTitle.Length) / 2;
                Console.WriteLine(sTitle);

                Console.Write("Enter the string to encode: ");
                sUserString = Console.ReadLine();

                foreach(char ch in sUserString)
                {
                    if (char.IsDigit(ch))  // add 10 to unicode
                    {
                        iUnicode = (int)ch + 10;
                        sEncodedString += (char)iUnicode;
                    }
                    else if (char.IsUpper(ch))  // add 1 to unicode
                    {
                        iUnicode = (int)ch + 1;
                        sEncodedString += (char)iUnicode;
                    }
                    else if (char.IsLower(ch))  // subtract 1 from unicode
                    {
                        iUnicode = (int)ch - 1;
                        sEncodedString += (char)iUnicode;
                    }
                    else if (char.IsWhiteSpace(ch))  // Change to *
                    {
                        sEncodedString += '*';
                    }
                    else  // copy original to encoded
                    {
                        sEncodedString += ch;
                    }
                }

                Console.WriteLine($"\nEncoded string: {sEncodedString}\n"); 

                Console.Write("Encode another string? yes or no: ");
                sChoice = Console.ReadLine().ToLower();
            }
            while (sChoice == "yes");
        }
    }
}
