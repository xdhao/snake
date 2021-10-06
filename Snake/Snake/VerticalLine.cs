using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yLow, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yLow; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
