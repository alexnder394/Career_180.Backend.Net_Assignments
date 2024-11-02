using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFourthAssignment
{
    public class Line
    {
        Point start = new Point();
        Point end = new Point();

        public Point Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public Point End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        public Line()
        {

            start.X = 0; start.Y = 0;
            end.X = 0; end.Y = 0;
        }
        public Line(int x1, int y1, int x2, int y2)
        {
            start.X = x1; start.Y = y1;
            end.X = x2; end.Y = y2;
        }

        public string Print()
        {
            return $"Line start {start.Print()} , End {end.Print()}";
        }
    }

}
