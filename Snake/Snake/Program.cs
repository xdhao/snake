using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 5, '+');
            line.Draw();

            VerticalLine linia = new VerticalLine(0, 5, 5, '+');
            linia.Draw();

            Console.ReadLine();
        }

    }
}