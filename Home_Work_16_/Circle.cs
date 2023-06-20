using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_16_
{
    internal class Yumaloq : Shape
    {
        private double R;

        public Yumaloq(double r) => R = r;

        public override void Yuzani_topish()
        {
            var S = Math.PI * R * R / R;
            Console.WriteLine($"Yumaloq yuzasi : {S}");
        }
    }
}
