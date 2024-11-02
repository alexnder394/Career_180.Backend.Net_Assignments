using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFourthAssignment
{
    public class Triangle
    {
        Point p1;
        Point p2;
        Point p3;

        public Point P1
        {
            get
            {
                return p1;
            }

            set
            {
                p1 = value;
            }
        }

        public Point P2
        {
            get
            {
                return p2;
            }

            set
            {
                p2 = value;
            }
        }

        public Point P3
        {
            get
            {
                return p3;
            }

            set
            {
                p3 = value;
            }
        }

        public Triangle()
        {
            p1 = null;
            p2 = null;
            p3 = null;
        }
        public Triangle(Point _p1, Point _p2, Point _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
        }

        public string Print()
        {
            return $"Triangle p1:{p1.Print()}, p2:{p2.Print()}, p3:{p3.Print()}";
        }
    }
}
