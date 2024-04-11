using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaRevisao
{
    internal class Circulo
    {
        public double raio = 0;
        public double area = 0;
        public double Area()
        {
            area = 3.14 * (raio * raio);
            return area;
        }
    }
}
