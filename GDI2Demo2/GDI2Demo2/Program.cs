/* CMPE 1300- Fundamentals of Programming
 * 
 * Lecture7B- GDI2-Demo2 -- Some more features of GDIDrawer
 * 
 * Author: Oveeyen Moonian
 * Date: February 26,2024
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Threading;


namespace GDI2Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {  CDrawer  drawer = new CDrawer(400, 300);//Width is 400, height is 300

            drawer.ContinuousUpdate = false;//This will prevent automatic update

            //Working with Color.FromArgb()--Getting the color to change in a loop
            for (int col = 255; col >= 0; col--)
            {
                drawer.AddCenteredEllipse(200, 100, 50, 50, Color.FromArgb(255, 255, col));
                drawer.Render();//When continuous update is off we need to use render to draw the shape
                Thread.Sleep(10);// This will cause the program to sleep for 20 ms between iterations

            }

            Console.WriteLine("Press Any Key to see the moving ellipse");
            Console.ReadKey();


            //A moving Shape- We want the shape to move in the x-direction
            int xposn = 100;
            int xvel = 1;

            while (true)
            {
                drawer.AddCenteredEllipse(xposn, 150, 100, 100, Color.Red);
                drawer.Render();//Again we use Render since Continuous update is false 
                Thread.Sleep(20);
                drawer.Clear();
                xposn += xvel;

                int width = drawer.m_ciWidth;
                if ((xposn >= (width-50)) || (xposn<50))
                    xvel = -xvel;
                
            }

            Console.WriteLine("Press Any key to Continue");
            Console.ReadKey();

        }
    }
}
