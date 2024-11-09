using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecondAssignment
{
    public abstract class GeoShape
    {
        double dim1;
        double dim2;

        protected void setDim1(double _dim1)
        {
            dim1 = _dim1;
        }
        protected double getDim1()
        {
            return dim1;
        }
        protected void setDim2(double _dim2)
        {
            dim2 = _dim2;
        }
        protected double getDim2()
        {
            return dim2;
        }

        public GeoShape()
        {
            dim1 = dim2 = 0;
        }
        public GeoShape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
        public virtual double CalcArea() { return 0; }
    }

    public class Rect : GeoShape
    {
        public Rect(double _dim1, double _dim2) : base(_dim1, _dim2) { }

        public override double CalcArea()
        {
            return getDim1() * getDim2();
        }
    }

    public class Square : Rect
    {
        public Square(double _dim) : base(_dim, _dim) { }
    }

    public class Circle : GeoShape
    {
        public Circle(double _radius) : base(_radius, _radius) { }
        public override double  CalcArea()
        {
            return Math.PI * getDim1() * getDim1();
        }
    }
    public class Triangle : GeoShape
    {
        public Triangle(double _base, double _height) : base(_base, _height) { }
        public override double CalcArea()
        {
            return getDim1() * getDim2() * 0.5;
        }
    }
}
