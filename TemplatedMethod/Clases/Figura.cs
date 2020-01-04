using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatedMethod.Clases
{
    public abstract class Figura // definimos abtracta para que no se repita el mismo atributo en cada clase
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       private double area;

        public double Area
        {
            get { return area; }
           // set { area = value; }
        }
        
        public virtual double CalculoArea() //crearmos un metodo para luego sobreesribirlo en cada figura
        {

            return area;
        }
    }
}
