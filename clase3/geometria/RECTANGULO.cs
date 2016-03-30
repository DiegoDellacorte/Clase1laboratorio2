using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    class RECTANGULO
    {

        private PUNTO vertice1;
        private PUNTO vertice2;
        private PUNTO vertice3;
        private PUNTO vertice4;
        private MiColor ColorDelRectangulo;
        private float Superficie; 

        public RECTANGULO(PUNTO verticeUno , PUNTO verticeTres , MiColor ColorDelRectangulo)
        {

            this.vertice1 = verticeUno;
            this.vertice3 = verticeTres;

            this.vertice2 = new PUNTO(this.vertice3.DevolverX() , this.vertice1.DevolverY());

            this.vertice4 = new PUNTO(this.vertice1.DevolverX(), this.vertice3.DevolverY());
        
        }
        private void CalcularSuperficie()
        {
        
        float Base =Math.Abs(this.vertice3.DevolverX() - this.vertice4.DevolverX());
        float Altura = this.vertice1.DevolverY() - this.vertice3.DevolverY();

        this.Superficie = Base * Altura;
            
        
        }
        public static void MostrarRectangulo(RECTANGULO Rectangulo)
        {
        
        Console.WriteLine(Rectangulo);

        }


    }

    public enum MiColor
    { 
    
        Rojo,Verde,Azul,Blanco

    }
}
