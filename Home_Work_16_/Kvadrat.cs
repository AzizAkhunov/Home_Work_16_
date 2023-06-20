using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_16_
{
    internal class Kvadrat : Shape
    {
        private double width;

        public Kvadrat(double n)
        {
            width = n;
        }

        public override void Yuzani_topish()
        {
            var S = width * width;
            Console.WriteLine($"Kvadratni yuzasi : {S}");
        }
    }
}

