using System;
using TemplatedMethod.Clases;

namespace TemplatedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PATRON DE DISENIO TEMPLATE METHOD");

            Cuadrado cuadrado = new Cuadrado { Nombre = "primer cuadrado", Lado = 6 }; //instanciamos un cuadrado
            Rectangulo rectangulo = new Rectangulo { Nombre = "segundo rectangulo", Altura = 4, RBase = 9 };// instanciamos un rectangulo
            Circulo circulo = new Circulo { Nombre = "tercer circulo", Radio = 5 };//instanciamos un circulo

            Console.WriteLine(cuadrado.CalculoArea() ); //imprime el area del cuadrado

            Console.WriteLine(rectangulo.CalculoArea()); // imprime el area del rectangulo

            Console.WriteLine(circulo.CalculoArea()); //imprime el area del circulo
        }
    }
}
