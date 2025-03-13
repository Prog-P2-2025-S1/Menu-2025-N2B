using System.Threading.Channels;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            while(opcion != "0")
            {
                MostrarMenu();
                Console.Write("Ingrese una opcion -> ");
                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                        OpcionSuma();
                        PressToContinue();
                        break;
                    case "2":
                        OpcionResta();
                        PressToContinue();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        MostrarError("ERROR: Opcion inválida");
                        PressToContinue();
                        break;
                }
            }

        }


        static void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****** MENU ******");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("0 - Salir");
        }

        static void PressToContinue()
        {
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        static void OpcionSuma()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****** SUMA ******");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            int num1 = PedirNumeros("Ingrese primer numero para sumar: ");
            int num2 = PedirNumeros("Ingrese segundo numero para sumar: ");
            MostrarExito($"La suma de {num1}+{num2} = {Suma(num1, num2)}");
        }

        static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        static void OpcionResta()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****** RESTA ******");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            int num1 = PedirNumeros("Ingrese primer numero para restar: ");
            int num2 = PedirNumeros("Ingrese segundo numero para restar: ");
            MostrarExito($"La resta de {num1}-{num2} = {Resta(num1, num2)}");
        }

        static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        static string PedirPalabras(string mensaje)
        {
            Console.Write(mensaje);
            string dato = Console.ReadLine();
            return dato;
        }

        static int PedirNumeros(string mensaje)
        {
            bool exito = false;
            int numero = 0;
            while (!exito)
            {
                Console.Write(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);

                if (!exito) MostrarError("ERROR: Debe ingresar solo numeros");
            }

            return numero;
        }

        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void MostrarExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
