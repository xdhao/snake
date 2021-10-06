using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Draw();

            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Draw();

            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Draw();

            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Draw();

            Console.ReadLine();
        }

    }
}