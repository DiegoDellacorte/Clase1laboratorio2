using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    class PUNTO
    {

        private int X;
        private int Y;


            public PUNTO (int valorX , int valorY)//y de un punto x del otro
            {

                this.X = valorX;
                this.Y = valorY;
            
            
            }
            public int DevolverX()
            {

                return this.X; 
            
            }
            public int DevolverY()
            {

                return this.Y;
            
            }


    }
}
