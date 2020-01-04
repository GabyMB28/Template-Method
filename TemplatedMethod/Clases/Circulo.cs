using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatedMethod.Clases
{
    class Circulo: Figura //hereda los atributos y metodo de la clase figura
    {
        private double radio;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public override double CalculoArea() //sobreescribimos el metodo para el calculo del area del circulo
        {
            return 2* Math.PI *Radio;
        }
    }
}
