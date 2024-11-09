using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpThirdAssignment
{
    public class Complex
    {
        #region Data Fields
        int real;
        int img;
        #endregion

        public Complex()
        {
            img = real = 0;
        }
        public Complex(int _real = 0, int _img = 0)
        {
            img = _img;
            real = _real;
        }
        #region Setters & Getters [Data Gates]
        public int Real
        {
            set
            {
                real = value;
            }
            get
            {
                return real;
            }
        }
        public int Img
        {
            set
            {
                img = value;
            }
            get
            {
                return img;
            }
        }
        #endregion
        public string print()
        {
            switch (img)
            {
                case -1:
                    if (real == 0)
                    {
                        return $"-i";
                    }
                    else
                    {
                        return $"{real}-i";
                    }
                case < 0:
                    if (real == 0)
                    {
                        return $"{img}i";
                    }
                    return $"{real}{img}i";
                case 0:
                    return $"{real}";
                case 1:
                    if (real == 0)
                    {
                        return "i";
                    }
                    return $"{real}+i";
                default:

                    break;
            }
            return $"{real}+{img}i";
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
