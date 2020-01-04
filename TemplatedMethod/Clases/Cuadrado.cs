using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatedMethod.Clases
{
    class Cuadrado : Figura //hereda los atributos y metodo de la clase figura
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        public override double CalculoArea() //sobreescribimos el metodo para el calculo del area del cuadrado
        {
            return lado*lado;
        }
    }
}
