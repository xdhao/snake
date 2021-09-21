using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yLow, int yUp, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yLow; y <= yUp; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
