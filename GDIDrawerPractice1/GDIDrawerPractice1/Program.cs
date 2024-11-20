using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Threading;

namespace GDIDrawerPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BouncyBall();
            DisplayBall();
            //BouncyBall2();
            //PingPong();
            //MovingLine();
        }

        static void BouncyBall()
        {

            // Initialization
            int iCanvasWidth = 400;                             // Canvas Width
            int iCanvasHeight = 300;                            // Canvas Height
            int iScale = 5;


            CDrawer canvas = new CDrawer(iCanvasWidth, iCanvasHeight, true);
            //canvas.Scale = iScale;
            // canvas.ContinuousUpdate = false;//This will prevent automatic update

            //A moving Shape- We want the shape to move in the x-direction
            int xposn = 50;
            int xvel = 5;

            while (true)
            {
                canvas.AddCenteredEllipse(xposn, 150, 50, 50, Color.Red);
                canvas.Render();//Again we use Render since Continuous update is false 
                Thread.Sleep(20);
                canvas.Clear();
                xposn += xvel;

                int width = canvas.m_ciWidth;
                int height = canvas.m_ciHeight;

                // Check if the ball reached the right most part of the screen
                //    when reached rightmost side bounce to left                        when reached leftmost side bounce to right
                if ((xposn >= (width - 25)) || (xposn < 25))

                    // To make the ball bounce back to left
                    xvel = -xvel;

            }


            Console.WriteLine("Press Any key to Continue");
            Console.ReadKey();
        }

        static void BouncyBall2()
        {

            // Initialization
            int iCanvasWidth = 400;                             // Canvas Width
            int iCanvasHeight = 300;                            // Canvas Height
            int iScale = 5;


            CDrawer canvas = new CDrawer(iCanvasWidth, iCanvasHeight, true);
            //canvas.Scale = iScale;
            // canvas.ContinuousUpdate = false;//This will prevent automatic update

            //A moving Shape- We want the shape to move in the x-direction
            int xposn = 50;
            int yposn = 50;
            int xvel = 5;

            while (true)
            {
                canvas.AddCenteredEllipse(200, yposn, 50, 50, Color.Red);
                canvas.Render();//Again we use Render since Continuous update is false 
                Thread.Sleep(20);
                canvas.Clear();
                yposn += xvel;

                int width = canvas.m_ciWidth;
                int height = canvas.m_ciHeight;

                // Check if the ball reached the right most part of the screen
                //    when reached rightmost side bounce to left                        when reached leftmost side bounce to right
                if ((yposn >= (height - 25)) || (yposn < 25))
                {
                    // To make the ball bounce back to left
                    xvel = -xvel;
                }

            }


            Console.WriteLine("Press Any key to Continue");
            Console.ReadKey();
        }

        static void DisplayBall()
        {

            // Initialization
            int iCanvasWidth = 400;                             // Canvas Width
            int iCanvasHeight = 300;                            // Canvas Height
            int iScale = 5;


            CDrawer canvas = new CDrawer(iCanvasWidth, iCanvasHeight, true, true);
            //canvas.Scale = iScale;
            // canvas.ContinuousUpdate = false;//This will prevent automatic update

            int width = canvas.m_ciWidth;
            // Console.Write(width);

            int xposn = 25;

            canvas.AddCenteredEllipse(200, 25, 50, 50, Color.Red);
            Thread.Sleep(100);
            canvas.Clear();

            canvas.AddCenteredEllipse(200, 275, 50, 50, Color.Red);
            Thread.Sleep(100);
            //canvas.Clear();


            Console.Read();
        }

        static void ColorChangingBall()
        {

            // Initialization
            int iCanvasWidth = 400;                             // Canvas Width
            int iCanvasHeight = 300;                            // Canvas Height
            int iScale = 5;

            CDrawer canvas = new CDrawer(iCanvasWidth, iCanvasHeight);
            //canvas.Scale = iScale;
            canvas.ContinuousUpdate = false;//This will prevent automatic update


            // Working with Color.FromArgb()--Getting the color to change in a loop
            for (int col = 255; col >= 0; col--)
            {
                canvas.AddCenteredEllipse(200, 100, 50, 50, Color.FromArgb(255, 255, col));
                canvas.Render();//When continuous update is off we need to use render to draw the shape
                Thread.Sleep(10);// This will cause the program to sleep for 20 ms between iterations

            }
        }
        static void PingPong()
        {
            int iScreenXSize = 600;                                                     // Set Width size of GDIDrawer          
            int iScreenYSize = 600;                                                     // Set Height size of GDIDrawer
            int iScale = 5;                                                             // Set Scale size
            int iScaledWidth = iScreenXSize / iScale;                                   // the pixels of window width / Scale size    160
            int iScaledHeight = iScreenYSize / iScale;                                  // the pixels of window height / Scale size   120
            int iBallX = 0;                                                             // Set the initial position of the ball in X
            int iBallY = 0;                                                             // Set the initial position of the ball in Y
            int iBallVelocityX = 0;                                                     // Set Velocity of the ball in X
            int iBallVelocityY = 0;                                                     // Set Velocity of the ball in Y
            int iBallSize = 2;                                                          // Set the size of ball
            int iScore = 0;                                                             // initialize the score to 0
            int iPaddleSize = 10;                                                       // Set the size of paddle
            bool bValidClick = false;                                                   // Set the game click value
            bool bQuit = false;                                                         // Set the game quit value
            bool bPlayGame = false;                                                     // Set the game play
            bool bNotContinous = true;                                                  // Set var for Canvas to load the window                                      
            bool bNotLogging = true;                                                    // Set var for Canvas for logging
            bool bNotDone = true;                                                       // Set the not done to continue the sub loop
            Point point = new Point();                                                  // to get the position of mouse click
            Random random = new Random();

            // Body

            // Create an new instance of GDIDrawer
            //CDrawer Canvas = new CDrawer(iScreenXSize, iScreenYSize, bNotContinous, bNotLogging);       // Create a GIDDrawer window
            //Canvas.Scale = iScale;                                                                      // assign vlaue for the scale
            //
            //point.X = random.Next(0, iScaledWidth);
            //point.Y = random.Next(0, iScaledHeight);
            //
            //Canvas.AddRectangle(point.X, point.Y, 10, 10, Color.LimeGreen);


            // Borders
            // for (int i = 0; i < 160; i++)
            // {
            //    // Top 
            //    Canvas.SetBBScaledPixel(i, 0, Color.Cyan);                                                   // top border
            //    
            //    Canvas.SetBBScaledPixel(i, 119, Color.Cyan);                                                 // bottom border
            //
            // }
            //
            //for (int i = 0; i < 120; i++)
            //{
            //    Canvas.SetBBScaledPixel(159, i, Color.Cyan);                                             // right side border
            //}


            //Canvas.AddCenteredEllipse(147, 107, 20, 20, Color.LimeGreen, 20);
            //Canvas.AddCenteredEllipse(124, 107, 20, 20, Color.LimeGreen, 20);
            //Canvas.AddCenteredEllipse(101, 107, 20, 20, Color.LimeGreen, 20);
            //Canvas.AddCenteredEllipse(12, 12, 20, 20, Color.LimeGreen, 20);




            Console.ReadLine();

        }

        static void MovingLine()
        {
            int iWindowWidth = 600;
            int iWindowHeight = 600;
            int iScale = 5;
            int iScaledWidth = iWindowWidth / iScale;
            int iScaledHeight = iWindowHeight / iScale;
            int iPaddleSize = 15;

            bool bValidClick = false;
            Point point = new Point();

            bool bNotContinous = true;


            CDrawer Canvas = new CDrawer(iWindowWidth, iWindowHeight, bNotContinous);
            Canvas.Scale = iScale;
            for (int i = 0; i < 120; i++)
            {
                // Ground
                Canvas.SetBBScaledPixel(i, 119, Color.Cyan);
                // left
                // Canvas.SetBBScaledPixel(0, i, Color.Yellow);
                // Right
                Canvas.SetBBScaledPixel(119, i, Color.Cyan);
                // Top
                Canvas.SetBBScaledPixel(i, 0, Color.Cyan);
            }

            do
            {
                Canvas.Clear();
                Canvas.GetLastMousePositionScaled(out point);

                if (point.Y < iPaddleSize-1)
                {
                    point.Y = 1 + iPaddleSize / 2;
                }
                else if (point.Y + iPaddleSize / 2 > iScaledHeight-1)
                {
                    point.Y = iScaledHeight - 2 - iPaddleSize / 2;
                }

                Canvas.AddCenteredRectangle(0, point.Y, 1, iPaddleSize, Color.Yellow);
                Thread.Sleep(20);

            }
            while (!bValidClick);
            Console.ReadLine();
        }

    }
}
