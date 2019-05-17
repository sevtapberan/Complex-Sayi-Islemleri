using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL24022017
{
    class Complex
    {
        double re;
        double im;
        

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public Complex()
        { }

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }
        }


        public static Complex ComplexFromCartesian(double re, double im)
        {
            return new Complex(re, im);
        }
        public static Complex ComplexFromPolar(double dist, double angle)
        {
            double re = dist * Math.Cos(Math.PI/(180.0/angle));
            double im = dist * Math.Sin(Math.PI / (180.0 / angle));
            return new Complex(re,im);
        }

        public void Add(Complex num2)
        {
            Re += num2.Re;
            Im += num2.Im;
        }

        public void Substract(Complex num2)
        {
            Re -= num2.Re;
            Im -= num2.Im;
        }

        public void Multiply(Complex num2)
        {
            double tempRe = Re * num2.Re - Im * num2.Im;
            Im = Re * num2.Im + Im * num2.Re;
            Re = tempRe;
        }

        public static Complex Multiply(Complex num1, Complex num2)
        {
            double tempRe = num1.Re * num2.Re - num1.Im * num2.Im;
            return new Complex(num1.Re * num2.Re - num1.Im * num2.Im,
               num1.Re * num2.Im + num1.Im * num2.Re);
        }

    }
}
