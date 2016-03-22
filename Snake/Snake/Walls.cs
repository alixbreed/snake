using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls (int width, int height)
        {
            wallList = new List<Figure>();
            HorizontalLine topLine = new HorizontalLine(0, width - 2,  0, '+');
            HorizontalLine botLine = new HorizontalLine(0, width - 2, 24, '+');
            VerticalLine leftLine = new VerticalLine (0, height - 1,  0, '+');
            VerticalLine rightLine = new VerticalLine(0, height - 1, 78, '+');
            wallList.Add(topLine);
            wallList.Add(rightLine);
            wallList.Add(botLine);
            wallList.Add(leftLine);
        }

        internal bool IsHit (Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
