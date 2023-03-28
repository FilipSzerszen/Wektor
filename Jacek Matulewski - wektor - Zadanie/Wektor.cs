using System;

namespace WektorBiblioteka
{
    public struct Wektor
    {
        private double wx, wy, wz;
        public Wektor(double wx, double wy, double wz)
        {
            this.wx = wx;
            this.wy = wy;
            this.wz = wz;
        }
        public static readonly Wektor Zerowy = new Wektor(0, 0, 0);
        public static readonly Wektor Jednostkowy = new Wektor(1, 1, 1);

        public static string Info()
        {
            return "Struktura Wektor";
        }

        public override string ToString()
        {
            return ("("+wx + ", "+wy +", "+wz+")").ToString();
        }
        public double DługośćWektora()
        {
            double WX = wx;
            double WY = wy;
            double WZ = wz;
            return Math.Sqrt(WX *WX + WY * WY + WZ * WZ);
        }

        #region Własności
        public double Wx { get => wx; set => wx = value; }
        public double Wy
        {
            get { return wy; }
            set { wy = value; }
        }
        public double Wz
        {
            get { return wz; }
            set { wz = value; }
        }

        
        #endregion
    }

}
