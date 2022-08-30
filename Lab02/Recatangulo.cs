using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Recatangulo
    {
        public Vertice v1 { get; set; }
        public Vertice v2 { get; set; }
        public Vertice v3 { get; set; }
        public Vertice v4 { get; set; }


        public double getArea()
        {

            double baseRectangulo = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
            double alturaRectangulo = Math.Sqrt(Math.Pow(v4.x - v1.x, 2) + Math.Pow(v4.y - v1.y, 2));

            return baseRectangulo * alturaRectangulo;
        }
        public double getPerimetro()
        {
            double baseRectangulo = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
            double alturaRectangulo = Math.Sqrt(Math.Pow(v4.x - v1.x, 2) + Math.Pow(v4.y - v1.y, 2));

            return (baseRectangulo + alturaRectangulo) * 2;
        }
    }
}
