﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Directions direction)
        {
            if (direction == Directions.LEFT)
            {
                x = x-offset;
            }
            if (direction == Directions.RIGHT)
            {
                x =x +offset;
            }
            if (direction == Directions.UP)
            {
                y = y-offset;
            }
            if (direction == Directions.DOWN)
            {
                y =y +offset;
            }

        }         





        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
