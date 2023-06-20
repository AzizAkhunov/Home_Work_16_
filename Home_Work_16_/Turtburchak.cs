using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_16_
{
    internal class Turtburchak : Shape
    {
        private double width;
        private double balandlik;

        public Turtburchak(double n, double m)
        {
            width = n;
            balandlik = m;
        }

        public override void Yuzani_topish()
        {
            var S = width * balandlik;
            Console.WriteLine($"Kvadratni yuzasi : {S}");
        }
    }
}
