using System;
using System.Globalization;

namespace Project
{
    class Progam
    {
        static void Main(string[] args)
        {
            //Variavel
            double X, Y;


            //Entrada
            string[] valor = Console.ReadLine().Split(' ');
            X = double.Parse(valor[0], CultureInfo.InvariantCulture);
            Y = double.Parse(valor[1], CultureInfo.InvariantCulture);

            //Processamento / Saida

            if (X == 0.0 || Y == 0.0)
                Console.WriteLine("Origem");

            else if (X == 0.0)
                Console.WriteLine("Eixo Y");

            else if (Y == 0.0)
                Console.WriteLine("Eixo X");

            else if (X > 0.0 && Y > 0.0)
                Console.WriteLine("Q1");

            else if (X < 0.0 && Y > 0.0)
                Console.WriteLine("Q2");

            else if (X < 0.0 && Y < 0.0)
                Console.WriteLine("Q3");

            else
                Console.WriteLine("Q4");

        }
    }
}