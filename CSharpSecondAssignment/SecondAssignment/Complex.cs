using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class Complex
    {
        int real;
        int img;
        
        public void SetReal(int _real) { real = _real; }
        public void SetImg(int _img) { img = _img; }
        public int GetReal() { return real; }
        public int GetImg() { return img; }
        
        public string Print()
        {
            if (real == 0 && img == 0)
                return "0";

            if (real == 0)
            {
                if (img == 1) return "i";
                if (img == -1) return "-i";
                return $"{img}i";
            }

            if (img == 0)
                return $"{real}";

            string sign = img > 0 ? "+" : "-";
            int absImg = Math.Abs(img); 

            if (absImg == 1)
                return $"{real}{sign}i";
            else
                return $"{real}{sign}{absImg}i";
        }
    
        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real = real + right.real;
            result.img = img + right.img;
            return result;
        }
    
    }
}
