using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatedMethod.Clases
{
    class Rectangulo : Figura //hereda los atributos y metodo de la clase figura
    {
        private double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        private float rbase;

        public float RBase
        {
            get { return rbase; }
            set { rbase = value; }
        }
        public override double CalculoArea() //sobreescribimos el metodo para el calculo del area del rectangulo
        {
            return altura*rbase;
        }
    }
}
