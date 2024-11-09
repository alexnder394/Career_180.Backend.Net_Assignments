using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecondAssignment
{

    public class Base
    {
        protected int x { set; get; }
        protected int y { set; get; }

        public Base()
        {
            x = y = 0;
        }

        public Base(int _x, int _y)
        {
            x = _x;
            y = _y;

        }
        public string Show()
        {
            return " Hi from base!";
        }
    }

    public class Derived : Base
    {
        int z;
        public Derived() { z = 0; }
        public Derived(int _x, int _y, int _z) : base(_x, _y)
        {
            z = _z;
        }
        public string Show()
        {
            return " Hi from derived!";
        }
    }
    public class Derived2 : Derived
    {
        int a;
        public Derived2() { a = 0; }

        public Derived2(int _x, int _y, int _z, int _a) : base(_x, _y, _z)
        {
            a = _a;
        }
        public string Show()
        {
            return " Hi from derived2!";
        }
    }

}
