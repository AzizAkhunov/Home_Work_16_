using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_16_
{
    internal class Uchburchak : Shape
    {
        private double width;
        private double balandlik;

        public Uchburchak(double n, double m)
        {
            width = n;
            balandlik = m;
        }

        public override void Yuzani_topish()
        {
            var S = width * balandlik / 2;
            Console.WriteLine($"Kvadratni yuzasi : {S}");
        }
    }
}
