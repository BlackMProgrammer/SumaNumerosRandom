using System;
using System.Xml.Schema;

namespace SumaNumerosRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valorr;
            string valnumero;
            double numero;
            double total1;

            Console.WriteLine("Desea Sumar un numero ? y/n");
            string yon = Console.ReadLine();
            total1 = 0;
            if (yon == "y")
            {
                do
                {
                    Console.WriteLine("Digite un numero");
                    valnumero = Console.ReadLine();
                    numero = Convert.ToDouble(valnumero);

                    if (numero != 0)
                    {
                        total1 = total1 + numero;
                        Console.WriteLine("La suma es de {0}", total1);
                    }

                } while (numero != 0);
            }
            else {
                Console.WriteLine("Intentelo nuevamente");
            }
            
        }
    }
}
