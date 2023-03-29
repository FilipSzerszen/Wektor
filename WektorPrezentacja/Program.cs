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
            Wektor W1 = Wektor.Jednostkowy;
            Wektor W2 = new Wektor(2, 1, 3);
            Wektor W3 = new Wektor() { Wx = 3, Wy = -3, Wz = -1 };

            Console.WriteLine(W0);
            Console.WriteLine(W1);
            Console.WriteLine(W2);
            Console.WriteLine(W3);

            Console.WriteLine();
            Console.WriteLine(Wektor.JestProstopadły(W2, W3));
            Console.WriteLine(W2 * W3);

            Console.WriteLine();
            Console.WriteLine(W0.DługośćWektora());
            Console.WriteLine(W1.DługośćWektora());
            Console.WriteLine(W2.DługośćWektora());
            Console.WriteLine(W3.DługośćWektora());

            Console.WriteLine();
            Wektor[] tab = new Wektor[10];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = Wektor.RandomWektor();
            }
            foreach (Wektor element in tab) Console.WriteLine(element + "  " + element.DługośćWektora());

            Console.WriteLine();
            Array.Sort(tab);
            foreach (Wektor element in tab) Console.WriteLine(element + "  " + element.DługośćWektora());



        }
    }
}
