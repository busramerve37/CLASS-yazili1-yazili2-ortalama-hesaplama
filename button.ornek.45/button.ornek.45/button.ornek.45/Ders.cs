using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace button.ornek._45
{
    internal class Ders
    {
        double yazili1;
        double yazili2;

        public double Yazili1 { get => yazili1; set => yazili1 = value; }
        public double Yazili2 { get => yazili2; set => yazili2 = value; }

        public Ders(double yazili1, double yazili2)
        {
            Yazili1 = yazili1;
            Yazili2 = yazili2;
        }

        public double Ortalama()
        {
            double ortalama = (yazili1 + yazili2) / 2;
            return ortalama;
             
        }
    }
}
