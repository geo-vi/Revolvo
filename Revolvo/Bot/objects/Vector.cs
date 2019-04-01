using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Bot.objects
{
    public class Vector
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Vector point)
        {
            return Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));
        }

        public static Vector Parse(string x, string y)
        {
            var intX = int.Parse(x);
            var intY = int.Parse(y);
            return new Vector(intX, intY);
        }

        public Point ToMapPoint()
        {
            var newX = X / 54;
            var newY = (int)(Y / 47.58364312267658);
            return new Point(newX, newY);
        }
    }
}
