/* CMPE 1300- Fundamentals of Programming
 * Lecture7B-Demo1- More GDI Drawer
 * 
 * Author: Oveeyen Moonian
 * Date: February 26, 2024
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace GDI2Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Create a Drawer Window
            CDrawer Canvas = new CDrawer();


            //Changing the background Color of the window - use BBColor
            Canvas.BBColour = Color.Azure;


            //displaying Text at the default position and using a default color
            //The text will be displayed in the center of the drawing window
            Canvas.AddText("Meat", 20);

            //Displaying a text at a selected position on the screen
            //We also wish to select the color for the display
            Canvas.AddText("New Text", 20, 200, 100, 250, 100, Color.Red);

            //Setting the BackBuffer Color for pixels with
            // a number of selected x and y values
            for (int x=50; x<75;x+=5)
            {
                for (int y=100; y<125;y+=5)
                     Canvas.SetBBPixel(x, y, Color.Red);
            }
           

            //Setting a bigger scale
            Canvas.Scale = 10;

            //Using SetBBScaledPixel - This gives us pixels of larger sizes
            //in both x and y directions => the width and height of the window are now 
            //of smaller values (since they represent less pixels)
            Canvas.SetBBScaledPixel(40, 5, Color.Blue);
            Console.WriteLine("Press Any Key To clear the window");
            Console.ReadKey();

            Canvas.Clear();//Note that Canvas.Clear() does not clear the bacck buffer

           

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}
