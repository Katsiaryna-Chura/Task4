using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Point p = obj as Point;
            if ((System.Object)p == null)
            {
                return false;
            }

            return (this.X == p.X) && (this.Y == p.Y);
        }

        public override string ToString()
        {
            return $"Point: x={this.X}, y={this.Y}";
        }
    }
}

