using System;
using Classes.Herança;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1= new Ponto(10, 20);
            //itens que p1 tem acesso

/*          p1.CalcularDistancia3();
            p1.Equals();
            p1.GetHashCode();
            p1.ToString();
            p1.x;
            p1.y; */

            Ponto p2 = new Ponto3D (10, 20, 30);
            //itens que p2 tem acesso

/*             p2.CalcularDistancia3();
            p2.Equals();
            p2.GetHashCode();
            p2.ToString();
            p2.x;
            p2.y;
            p2.z; */

            //para acessar o Calcular() que é static 
            //Ponto3D.Calcular();

        }
    }
}