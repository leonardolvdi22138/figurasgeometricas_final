using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    class Rectangulo:Figura
    {
        //esta clase requiere de dos lados para funcionar
        //creamos el lado2
        private float lado2;
        //crear un constructor para rectangulo

        public float Lado2
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0;
                }
                else
                {
                    lado2 = value;
                }


            }
            get
            {
                return lado2; //regresa o cacha el valor de la variable local
            }
        }
        //usamos el constructor de la clase padre

        public Rectangulo (float lado1, float lado2)
        {
            //radio se va a leer de la caja de texto con 
            //usando el boton guardar 
            this.Lado1 = lado1;  //hace que unicamente el valor la
                                 // cantidad del lado sea disponible para la clase rectangulo 
            this.Lado2 = lado2;
        }

        public override float area()
        {
            return Lado1 * Lado2;
        }
        public override float perimetro()
        {
            return (2 * Lado1) + (2 * Lado2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA 
        }
    }
}
