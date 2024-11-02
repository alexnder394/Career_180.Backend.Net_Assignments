using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFourthAssignment
{
    public class Point
    {
        int x;
        int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Point()
        {
            x = y = 0;
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public string Print()
        {
            return $"({x},{y})";
        }

    }
}
