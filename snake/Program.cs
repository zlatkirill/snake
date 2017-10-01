﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Draw();
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Draw();
            VerticalLine leftline = new VerticalLine(0, 24, 0 , '+');
            leftline.Draw();
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Draw();

            Point p = new Point(4, 5, '@');
            Snake snake = new Snake(p, 4, Directions.RIGHT);
            snake.Draw();


            snake.Move();
            Console.ReadLine();      
         }
    }
}
