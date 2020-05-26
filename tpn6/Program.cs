using System;
using static System.Console;
using System.ComponentModel.DataAnnotations;
using static System.Math;

namespace tpn6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
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
            WriteLine("".PadLeft(titulo.Length + 4, '*'));
            WriteLine($"* {titulo} *");
            WriteLine("".PadLeft(titulo.Length + 4, '*'));
        }

        public static void Ejercicio1()
        {
            ImprimirTítutlo("Ejercicio 1");
            string entrada;
            do
            {
                WriteLine("Ingrese el número que desea invertir");
                entrada = ReadLine();

            } while (Convert.ToInt32(entrada) <= 0);
            WriteLine("El número invertido es: " + Invertir(entrada));
        }
        public static void Ejercicio2()
        {
            int opcion, a, b, resultado = 0;
            ImprimirTítutlo("Ejercicio 2");
            do
            {
                opcion = 0;
                do
                {
                    WriteLine("Ingrese la operación que desea realizar:\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
                    opcion = Convert.ToInt32(ReadLine());
                    if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4)
                        WriteLine("La opción ingresada es incorrecta. Ingrese nuevamente.");
                } while (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4);
                WriteLine("Ingrese primer valor");
                a = Convert.ToInt32(ReadLine());
                WriteLine("Ingrese segundo valor");
                b = Convert.ToInt32(ReadLine());
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
                            WriteLine("ERROR: No se puede dividir por 0");
                        break;
                    default:
                        resultado = 0;
                        break;
                }
                WriteLine("El resultado de la operación es: " + resultado);
                WriteLine("¿Desea realizar otra operación?\n1.Si\n2.No");
                opcion = Convert.ToInt32(ReadLine());
                if (opcion == 2)
                    opcion = 0;
            } while (opcion != 0);
        }
        public static void Ejercicio3()
        {
            ImprimirTítutlo("Ejercicio 3");
            WriteLine("Ingrese un número");
            int num = Convert.ToInt32(ReadLine());
            //El valor absoluto de un número
            //● El cuadrado
            //● La raíz cuadrada
            //● El seno
            //● El Coseno
            //● La parte entera de un tipo float.
            //Luego de esto, solicite dos números al usuario y determine:
            //● El Máximo entre los dos números
            //● El Mínimo entre los dos números
            WriteLine($"El cuadrado de {num} es {Math.Pow(num, 2)}");
            WriteLine($"La raiz cuadrada de {num} es {Math.Sqrt(num)}");
            WriteLine($"El seno de {num} es {Math.Sin(num)}");
            WriteLine($"El coseno de {num} es {Math.Cos(num)}");
            WriteLine("Ingrese un número con , flotante");
            double numF = Convert.ToDouble(ReadLine());
            WriteLine($"La parte entera de {numF} es {Math.Floor(numF)}");
            WriteLine("Intrese un número");
            int num1 = Convert.ToInt32(ReadLine());
            WriteLine("Intrese otro número");
            int num2 = Convert.ToInt32(ReadLine());
            WriteLine($"El máximo entre {num1} y {num2} es: {Math.Max(num1, num2)}");
            WriteLine($"El mínimo entre {num1} y {num2} es: {Math.Min(num1, num2)}");
        }
    }
}
