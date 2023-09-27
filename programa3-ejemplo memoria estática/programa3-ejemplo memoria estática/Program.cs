using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa3_ejemplo_memoria_estática
{
    class Program
    {
        // creacion de a clase rectangulo:
        class rectangulo
        {
            public static double area(double a,double b) // metodo estatico
            {
                return a * b;
            }

            public static double perimetro(double c, double d, double e, double f) // metodo estatico
            {
                return c + d + e + f;
            }

            public static double volumen(double g, double h,double i) // metodo estatico
            {
                return g * h * i;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" El Area del Rectangulo es: " + rectangulo.area(2,3));
            Console.WriteLine(" El Perimetro del Rectangulo es: " + rectangulo.perimetro(1.3,5,6.7,10));
            Console.WriteLine(" El Volumen del Prisma es: " + rectangulo.volumen(4.5, 13, 6.2));
            Console.ReadKey();
        }
    }
}
