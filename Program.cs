using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL24022017
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3, 3);
            Complex c2 = new Complex();
            Console.WriteLine(c1.Re+"+"+c1.Im+"i");
            Console.WriteLine(c2.Re + "+" + c2.Im+"i");
            Complex c3 = Complex.ComplexFromCartesian(3,5);
            Complex c4 = Complex.ComplexFromPolar(3*Math.Sqrt(2),45);
            Console.WriteLine(c4.Re + "+" + c4.Im + "i");

            c1.Add(c4);
            Console.WriteLine(c1.Re + "+" + c1.Im + "i");
            c4.Add(c1);
            Console.WriteLine(c4.Re + "+" + c4.Im + "i");
           // c1.Multiply(c3);//carpim sonucu c1in uzerine yazilir.
            Complex c5 = Complex.Multiply(c1,c3); // carpim sonucu olarak yeni bir complex sayi dondurulur
        }
    }
}
