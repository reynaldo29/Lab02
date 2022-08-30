using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese valore para x1: ");
            string x1v1s = Console.ReadLine();
            int x1v1i=Int32.Parse(x1v1s);
            
            Console.WriteLine("Ingrese valore para y1: ");
            string y1v1s = Console.ReadLine();
            int y1v1i = Int32.Parse(y1v1s);

            Console.WriteLine("Ingrese valore para x2: ");
            string x2v2s = Console.ReadLine();
            int x2v2i = Int32.Parse(x2v2s);

            Console.WriteLine("Ingrese valore para y2: ");
            string y2v2s = Console.ReadLine();
            int y2v2i = Int32.Parse(y2v2s);

            Console.WriteLine("Ingrese valore para x3: ");
            string x3v3s = Console.ReadLine();
            int x3v3i = Int32.Parse(x3v3s);

            Console.WriteLine("Ingrese valore para y3: ");
            string y3v3s = Console.ReadLine();
            int y3v3i = Int32.Parse(y3v3s);

            Console.WriteLine("Ingrese valore para x4: ");
            string x4v4s = Console.ReadLine();
            int x4v4i = Int32.Parse(x4v4s);

            Console.WriteLine("Ingrese valore para y4: ");
            string y4v4s = Console.ReadLine();
            int y4v4i = Int32.Parse(y4v4s);





            Recatangulo recatangulo = new Recatangulo();

            Vertice v1 = new Vertice
            {
                x = x1v1i,
                y = y1v1i
            };

            Vertice v2 = new Vertice
            {
                x = x2v2i,
                y = y2v2i
            };

            Vertice v4 = new Vertice
            {
                x = x4v4i,
                y = y4v4i
            };

            recatangulo.v1 = v1;
            recatangulo.v2 = v2;
            recatangulo.v4 = v4;

            Console.WriteLine("Area de rectangulo: " + recatangulo.getArea());
            Console.WriteLine("Perimetro de rectangulo: " + recatangulo.getPerimetro());


            Console.Read();

        }
    }
}
