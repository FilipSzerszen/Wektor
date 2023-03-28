using System;
using WektorBiblioteka;

namespace WektorPrezentacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Wektor.Info());
            Wektor W0 = Wektor.Zerowy;
            Wektor W1 =  Wektor.Jednostkowy;
            Wektor W2 = new Wektor(3, 6, 6);
            Wektor W3 = new Wektor() { Wx = 3, Wy = 4, Wz = 5 };

            Console.WriteLine(W0);
            Console.WriteLine(W1);
            Console.WriteLine(W2);
            Console.WriteLine(W3);


            Console.WriteLine(W0.DługośćWektora());
            Console.WriteLine(W1.DługośćWektora());
            Console.WriteLine(W2.DługośćWektora());
            Console.WriteLine(W3.DługośćWektora());
        }
    }
}
