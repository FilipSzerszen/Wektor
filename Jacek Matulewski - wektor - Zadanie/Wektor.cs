using System;

namespace WektorBiblioteka
{
    public struct Wektor : IComparable<Wektor>
    {
        public Wektor(double wx, double wy, double wz)
        {
            this.Wx = wx;
            this.Wy = wy;
            this.Wz = wz;
        }
        #region Własności
        public double Wx { get; set; }
        public double Wy { get; set; }
        public double Wz { get; set; }
        #endregion

        public static readonly Wektor Zerowy = new Wektor(0, 0, 0);
        public static readonly Wektor Jednostkowy = new Wektor(1, 1, 1);

        #region Funkcje
        public static string Info()
        {
            return "Struktura Wektor";
        }
        public static Wektor RandomWektor()
        {
            Random r = new Random();
            return new Wektor(r.Next(10), r.Next(10), r.Next(10));
        }
        public int CompareTo(Wektor A)
        {
            return Math.Sign(this.DługośćWektora() - A.DługośćWektora());
        }
        public override string ToString()
        {
            return ("(" + Wx + ", " + Wy + ", " + Wz + ")").ToString();
        }
        public readonly double DługośćWektora()
        {
            return Math.Sqrt(Wx * Wx + Wy * Wy + Wz * Wz);
        }
        public static double Dot(Wektor A, Wektor B) //iloczyn skalarny
        {
            return (A.Wx * B.Wx + A.Wy * B.Wy + A.Wz * B.Wz);
        }
        public static double Dot(Wektor A, Wektor B, double kąt) //iloczyn skalarny
        {
            return (A.DługośćWektora() * B.DługośćWektora() * Math.Cos(kąt * Math.PI / 180));
        }
        public static Wektor Cross(Wektor A, Wektor B) //iloczyn wektorowy
        {
            return new Wektor(B.Wy * A.Wz - B.Wz * A.Wy, B.Wz * A.Wx - B.Wx * A.Wz, B.Wx * A.Wy - B.Wy * A.Wx);
        }
        public static double DługośćIloczynuWektorów(Wektor A, Wektor B, double kąt) //iloczyn wektorowy
        {
            return (A.DługośćWektora() * B.DługośćWektora() * Math.Sin(kąt * Math.PI / 180));
        }
        public static bool JestProstopadły(Wektor A, Wektor B)
        {
            if (A == Zerowy || B == Zerowy) throw new Exception("Jeden z wektorów jest zerowy!");
            return ((Math.Acos((Dot(A, B)) / (A.DługośćWektora() * B.DługośćWektora()))) == Math.PI / 2) ? true : false;
        }
        public override bool Equals(object Obj)
        {
            if (!(Obj is Wektor)) return false;
            Wektor A = (Wektor)Obj;
            return (this == A);
        }
        public override int GetHashCode()
        {
            return (int)Wx ^ (int)Wy ^ (int)Wz;
        }



        #endregion
        #region Operatory
        public static Wektor operator +(Wektor A)
        {
            return A;
        }
        public static Wektor operator +(Wektor A, Wektor B)
        {
            return new Wektor(A.Wx + B.Wx, A.Wy + B.Wy, A.Wz + B.Wz);
        }
        public static Wektor operator -(Wektor A)
        {
            return new Wektor(-A.Wx, -A.Wy, -A.Wz);
        }
        public static Wektor operator -(Wektor A, Wektor B)
        {
            return new Wektor(A.Wx - B.Wx, A.Wy - B.Wy, A.Wz - B.Wz);
        }
        public static double operator *(Wektor A, double B)
        {
            return (A.Wx * B + A.Wy * B + A.Wz * B);
        }
        public static double operator *(double B, Wektor A)
        {
            return (A.Wx * B + A.Wy * B + A.Wz * B);
        }
        public static double operator /(Wektor A, double B)
        {
            if (B == 0) throw new Exception("Nie można podzielić wektora przez zero!");
            return (A.Wx / B + A.Wy / B + A.Wz / B);
        }
        public static double operator *(Wektor A, Wektor B) //iloczyn skalarny
        {
            return (A.Wx * B.Wx + A.Wy * B.Wy + A.Wz * B.Wz);
        }
        public static Wektor operator ^(Wektor A, Wektor B) //iloczyn wektorowy
        {
            return new Wektor(B.Wy * A.Wz - B.Wz * A.Wy, B.Wz * A.Wx - B.Wx * A.Wz, B.Wx * A.Wy - B.Wy * A.Wx);
        }
        public static bool operator !=(Wektor A, Wektor B)
        {
            return (A.Wx == B.Wx && A.Wy == B.Wy && A.Wz == B.Wz) ? false : true;
        }
        public static bool operator ==(Wektor A, Wektor B)
        {
            return (A.Wx == B.Wx && A.Wy == B.Wy && A.Wz == B.Wz) ? true : false;
        }
        #endregion

    }



}
