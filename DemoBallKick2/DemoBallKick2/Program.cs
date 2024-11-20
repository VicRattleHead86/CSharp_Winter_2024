/*
 * Reg Westly
 * DemoBallKick2
 * 
 * Jan 26, 2024
 * Demonstration of math and GDI drawer
 * 
 * 
 * 
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
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace DemoBallKick2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int iCanvasWidth = 1000;                            // Canvas Width
            int iCanvasHeight = 650;                            // Canvas Height
            int iX = 0;                                         // X Location
            int iY = 0;                                         // y Location
            int iScreenX = 0;                                   // x test
            int iScreenY = 0;                                   // y location
            int iDot = 4;                                       // diameter of the dot

            double dG = 9.80665;                                // Gravitational constant
            double dVelocity = 0.0;                             // velocity of the ball
            double dDegree = 0.0;                               // what angle in degrees to kick ball
            double dRadians = 0.0;                              // what angle in radians
            double dX = 0.0;
            double dY = 0.0;

            double dHighest = 0.0;                              // what is highest ball will go
            double dFarthest = 0.0;                             // how far will it go
            double dTime = 0.0;                                 // time to get to the peak
            
            double dMultiX = 0.0;                               // how to display on screen
            double dMultiY = 0.0;
            double dMultiplier = 0.0;
            
            // Body
            CDrawer canvas = new CDrawer(iCanvasWidth,iCanvasHeight,true,false);
            canvas.BBColour = Color.White;

            Console.Write("What is the initial velocity of the ball (m/s): ");
            double.TryParse(Console.ReadLine(), out dVelocity);
            Console.Write("Enter the angle you kicked the ball (in degrees): ");
            double.TryParse(Console.ReadLine(),out dDegree);
            dRadians = dDegree * Math.PI / 180;

            dHighest = Math.Pow(dVelocity * Math.Sin(dRadians), 2) / (2 * dG);          // Calculate how high
            dTime = dVelocity * Math.Sin(dRadians) / dG;                                // time to get to peak
            dFarthest = (dVelocity * Math.Cos(dRadians)) * dTime * 2;                   // how far will it go
            Console.WriteLine($"The Ball will take {dTime:N4} seconds to reach a maximum of {dHighest:N4}m with a total distance of {dFarthest:N4}m");

            dMultiX = iCanvasWidth / dFarthest;                                         // what is multiplier to get x to fit on screen
            dMultiY = iCanvasHeight / dHighest;                                         // what is multiplier to get y to fit on screen
            if(dMultiX <= dMultiY)
            {
                dMultiplier = dMultiX;
            }
            else
            {
                dMultiplier = dMultiY;
            }

            for (double dT = 0.0; dT < 200 && dY >=0; dT += 0.001) //testing for ball hit ground too
            {
                dX = dVelocity *Math.Cos(dRadians) * dT;
                dY = (-0.5 * dG * Math.Pow(dT, 2)) + (dVelocity * Math.Sin(dRadians) * dT);
                iScreenX = (int)(dX * dMultiplier);
                iScreenY = (int)(dY * dMultiplier);
                iScreenY = iCanvasHeight - iScreenY;
                // Console.WriteLine($"{dT:N4} , {dX:N4} , {dY:N4} , {iScreenX} , {iScreenY}");
                canvas.AddCenteredEllipse(iScreenX, iScreenY, iDot, iDot,Color.Green);
                //if (dY < 0)
                //{
                //    break;                                      // Reg Bad
                //}
               // System.Threading.Thread.Sleep(2);
            }

            canvas.AddText($"Height of Ball = {dHighest:N2}", 12, 700, 50, 299, 30, Color.DarkBlue);
            canvas.AddText($"Total distance = {dFarthest:N2}", 12, 700, 100, 299, 30, Color.DarkBlue);
            canvas.AddText($"Total flight time = {dTime * 2:N2}", 12, 700, 150, 299, 30, Color.DarkBlue);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
