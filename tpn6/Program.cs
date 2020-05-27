using System;
using static System.Console;
using System.ComponentModel.DataAnnotations;
using static System.Math;
using System.Timers;
using System.Linq;

namespace tpn6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            Ejercicio4();
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
            string respuesta = "La ";
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
                        respuesta += $"suma de {a} y {b} es {resultado}";
                        break;
                    case 2:
                        resultado = a - b;
                        respuesta += $"resta de {a} y {b} es {resultado}";
                        break;
                    case 3:
                        resultado = a * b;
                        respuesta += $"multiplicación de {a} y {b} es {resultado}";
                        break;
                    case 4:
                        if (b != 0)
                        {
                            resultado = a / b;
                            respuesta += $"división de {a} y {b} es {resultado}";
                        }
                        else
                            WriteLine("ERROR: No se puede dividir por 0");
                        break;
                    default:
                        resultado = 0;
                        break;
                }
                WriteLine(respuesta);
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
        public static void Ejercicio4()
        {
            WriteLine("Ingrese lo que sea");
            string cadena1 = ReadLine();
            var rnd = new Random();
            int rndInt;
            WriteLine($"Algunas letras que forman parte de la cadena {cadena1} son: ");
            for (int i = 0; i < 5; i++)
            {
                rndInt = rnd.Next(0, cadena1.Length);
                WriteLine($"{cadena1.Substring(rndInt, 1)}");
            }
            WriteLine("La longitud de la cadena es : " + cadena1.Length);
            WriteLine("Ingrese lo que sea again");
            string cadena2 = ReadLine();
            WriteLine($"La unión de las cadenas {cadena1} y {cadena2} es {cadena1 + cadena2}");
            rndInt = rnd.Next(0, cadena2.Length);
            WriteLine($"Una subcadena de {cadena2} es {cadena2.Substring(rndInt)}");
            foreach (char c in cadena2)
            {
                WriteLine(c);
            }
            WriteLine($"Ingrese subcadena a buscar en la cadena {cadena2}");
            string aBuscar = ReadLine();
            if(cadena2.Contains(aBuscar))
            {
                WriteLine($"La cadena {aBuscar} ocurre en la posición {cadena2.IndexOf(aBuscar)}");
            }
            else
            {
                WriteLine($"La cadena {aBuscar} no ocurre en {cadena2}");
            }
            WriteLine($"Cadena en mayúsculas: {cadena2.ToUpper()}");
            WriteLine($"Cadena en minúsuculas: {cadena2.ToLower()}");
            WriteLine("Ingrese lo que sea una vez más");
            string cadena3 = ReadLine();
            WriteLine($"Las cadenas {cadena3} y {cadena2} son {(cadena3.Equals(cadena2) ? "iguales":"distintas")}");
            WriteLine("Ingrese lo que sea pero con espacios");
            string cadena4 = ReadLine();
            string[] cadena4rota = cadena4.Split(' ');
            foreach (string parte in cadena4rota)
            {
                WriteLine(parte);
            }
            int opcion;
            do
            {
                opcion = 2;
                WriteLine("Ingrese una operación simple (Ejemplo: 582 + 2)");
                string operacion = ReadLine();
                string respuesta = "La ";
                string[] operandos;
                int a, b;
                if (operacion.Contains('+'))
                {
                    operandos = operacion.Split('+');
                    a = Convert.ToInt32(operandos[0]);
                    b = Convert.ToInt32(operandos[1]);
                    respuesta += $"suma de {a} y {b} es {a + b}";
                }
                else if (operacion.Contains('-'))
                {
                    operandos = operacion.Split('-');
                    a = Convert.ToInt32(operandos[0]);
                    b = Convert.ToInt32(operandos[1]);
                    respuesta += $"resta de {a} y {b} es {a - b}";
                }
                else if (operacion.Contains('*'))
                {
                    operandos = operacion.Split('*');
                    a = Convert.ToInt32(operandos[0]);
                    b = Convert.ToInt32(operandos[1]);
                    respuesta += $"multiplicación de {a} y {b} es {a * b}";
                }
                else if (operacion.Contains('/'))
                {
                    operandos = operacion.Split('/');
                    a = Convert.ToInt32(operandos[0]);
                    b = Convert.ToInt32(operandos[1]);
                    if (b != 0) respuesta += $"división de {a} y {b} es {a / b}";
                    else respuesta = "No se puede dividir por cero";
                }
                else respuesta = "La operación ingresada es incorrecta.";
                WriteLine(respuesta);
                WriteLine("¿Desea realizar otra operación?\n1.Si\n2.No");
                opcion = Convert.ToInt32(ReadLine());
            } while (opcion != 2); 
        }
    }
}
