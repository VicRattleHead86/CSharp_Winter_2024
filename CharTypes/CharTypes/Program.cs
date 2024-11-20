using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iDigit = 0;
            string sString = "This 12  #^*^:>'  sds";

            foreach (char ch in sString) 
            {
                if (char.IsLetter(ch))          // change to see types
                {
                    iDigit++;
                }
            }
            Console.WriteLine(iDigit);
            Console.ReadKey();
        }
    }
}
