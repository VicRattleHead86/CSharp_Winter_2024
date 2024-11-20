using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Add these for using GDIDrawer - Add to project references as well
using System.Drawing;
using GDIDrawer;
using System.Threading;

namespace DemoGDIDrawer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iScreenXSize = 1500;
            int iScreenYSize = 1000;
            CDrawer Canvas = new CDrawer(iScreenXSize,iScreenYSize,false,true);  // Continous update is off
            Point point = new Point();
            Random random = new Random();
            int iBallSizeX = 5;
            int iBallSizeY = 5;
            int iScale = 5;
            double dRotate = 0;

            
            Canvas.BBColour = Color.White;


            Canvas.Clear();
            Canvas.Scale = iScale;
            for(int iStar = 0; iStar < 500; ++iStar)
            {
                Canvas.SetBBScaledPixel(random.Next(iScreenXSize/iScale), random.Next(iScreenYSize/iScale),Color.SlateBlue);
            }



            point.X = iScreenXSize/iScale / 2;
            point.Y = iScreenYSize/iScale / 2;
            Canvas.AddCenteredEllipse(point, iBallSizeX, iBallSizeY, Color.Firebrick);

            point.X = 20;
            point.Y = 20;
            Canvas.AddCenteredRectangle(point, 15, 5, Color.Cyan);
            Canvas.AddRectangle(point.X, point.Y, 15, 5, Color.CornflowerBlue);

            point.X = 120;
            point.Y = 20;

            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI/180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);
            dRotate += 10 * Math.PI / 180;
            Canvas.AddLine(point, 100.0, dRotate, Color.FromArgb(random.Next()), 1);

            Canvas.Render();            // Draws the screen
            Thread.Sleep(20);           // need this for it not to jitter






            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
