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

            geometria.MiColor UnColor;
            UnColor = geometria.MiColor.Rojo;
            UnColor = (geometria.MiColor)22;

            Console.WriteLine(UnColor);
            Console.ReadLine();

        }
    }
}
