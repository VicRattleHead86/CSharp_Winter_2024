using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Exer10regwA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iLowValue = 1;
            int iHighValue = 200;
            int iNum = iLowValue - 1;
            string sTitle = "Checkerboard Draw - Reg Westly\n";
            int iWidth = 800;
            int iHeight = 600;
            bool bWorks = false;
            Color oddcolor = Color.Red;
            Color evencolor = Color.Blue;

            Console.CursorLeft = (Console.WindowWidth - sTitle.Length) / 2 ;
            Console.WriteLine(sTitle);
            CDrawer Canvas = new CDrawer(iWidth,iHeight,true);

            do
            {
                Console.Write("Enter the size of the square: ");
                if(!int.TryParse(Console.ReadLine(),out iNum))
                {
                    Console.WriteLine("An incorrect number was entered.");
                }
                else if (iNum < iLowValue || iNum > iHighValue)
                {
                    Console.WriteLine("The value is out of range.");
                }
                else if (iWidth % iNum != 0 || iHeight % iNum != 0)
                {
                    Console.WriteLine("The value us not evenly divisible.");
                }
                else
                {
                    bWorks = true;
                }
            }
            while (!bWorks);

            Canvas.Scale = iNum;

            for(int y = 0;  y < iHeight / iNum; y++)    // Rows
            {
                for (int x = 0; x < iWidth / iNum; x++)   // columns
                {
                    Canvas.AddRectangle(x, y, 1, 1, ((x+y) % 2 == 0 ? evencolor : oddcolor));
                    //if (x % 2 == 0 && y % 2 == 0 || x % 2 == 1 && y % 2 == 1)
                    //{
                    //    Canvas.AddRectangle(x, y, 1, 1, Color.Red);
                    //}
                    //else
                    //{
                    //    Canvas.AddRectangle(x, y, 1, 1, Color.Blue);
                    //}
                }
            }




            Console.WriteLine("Press any key to quit");
            Console.ReadKey(true);
        }
    }
}
