﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.sym = point.sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.DOWN: y += offset;
                    break;
                case Direction.LEFT: x -= offset;
                    break;
                case Direction.RIGHT: x += offset;
                    break;
                case Direction.UP: y -= offset;
                    break;
            }
        }

        public void Move (int dx, int dy)
        {
            x += dx;
            y += dy;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        internal bool IsHit(Point point)
        {
            return this.x == point.x && y == point.y;
        }
    }
}
