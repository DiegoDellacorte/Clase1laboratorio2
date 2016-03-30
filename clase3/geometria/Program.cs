using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebageometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            geometria.RECTANGULO Rectangulo;
           

            geometria.MiColor UnColor;
            UnColor = geometria.MiColor.Rojo;
            // UnColor = (geometria.MiColor)22;

            
            Console.WriteLine(UnColor);
            switch (UnColor)

            {
                case geometria.MiColor.Rojo:
                    break;
                case geometria.MiColor.Verde:
                    break;
                case geometria.MiColor.Azul:
                    break;
                case geometria.MiColor.Blanco:
                    break;
                default:
                    break;
            }
            geometria.RECTANGULO.MostrarRectangulo(Rectangulo);
            Console.ReadKey();

        }
    }
}
