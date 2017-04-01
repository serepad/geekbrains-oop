using System;
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
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(5, 6, '@');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            foreach(Point p in pList)
            {
                p.Draw();
            }

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Draw();


            Console.ReadLine();

        }
    }
}