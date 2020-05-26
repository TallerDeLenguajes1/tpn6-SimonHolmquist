using System;
using System.ComponentModel.DataAnnotations;

namespace tpn6
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            do
            {
                Console.WriteLine("Ingrese el número que desea invertir");
                entrada = Console.ReadLine();

            } while (Convert.ToInt32(entrada)<=0);
            Console.WriteLine("El número invertido es: " + Invertir(entrada));
        }

        public static string Invertir(string entrada)
        {
            string salida = "";
            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                salida += entrada[i];
            }
            return salida;
        }

    }
}
