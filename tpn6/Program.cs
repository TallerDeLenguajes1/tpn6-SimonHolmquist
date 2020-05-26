using System;
using System.ComponentModel.DataAnnotations;

namespace tpn6
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirTítutlo("Ejercicio 1");
            string entrada;
            int opcion, a, b, resultado = 0;
            do
            {
                Console.WriteLine("Ingrese el número que desea invertir");
                entrada = Console.ReadLine();

            } while (Convert.ToInt32(entrada)<=0);
            Console.WriteLine("El número invertido es: " + Invertir(entrada));
            ImprimirTítutlo("Ejercicio 2");
            do
            {
                opcion = 0;
                do
                {
                    Console.WriteLine("Ingrese la operación que desea realizar:\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if(opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4)
                        Console.WriteLine("La opción ingresada es incorrecta. Ingrese nuevamente.");
                } while (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4);
                Console.WriteLine("Ingrese primer valor");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese segundo valor");
                b = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        resultado = a + b;
                        break;
                    case 2:
                        resultado = a - b;
                        break;
                    case 3:
                        resultado = a * b;
                        break;
                    case 4:
                        if (b != 0)
                            resultado = a / b;
                        else
                            Console.WriteLine("ERROR: No se puede dividir por 0");
                        break;
                    default:
                        resultado = 0;
                        break;
                }
                Console.WriteLine("El resultado de la operación es: " + resultado);
                Console.WriteLine("¿Desea realizar otra operación?\n1.Si\n2.No");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 2)
                    opcion = 0;
            } while (opcion != 0);
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

        public static void ImprimirTítutlo(string titulo)
        {
            Console.WriteLine("".PadLeft(titulo.Length + 4, '*'));
            Console.WriteLine($"* {titulo} *");
            Console.WriteLine("".PadLeft(titulo.Length + 4, '*'));
        }
    }
}
