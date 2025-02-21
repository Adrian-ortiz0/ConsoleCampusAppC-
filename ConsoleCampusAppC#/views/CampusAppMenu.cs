using ConsoleCampusAppC_.controllers;
using ConsoleCampusAppC_.models;
using ConsoleCampusAppC_.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.views
{
    class CampusAppMenu
    {
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("\r\n░█████╗░░█████╗░███╗░░░███╗██████╗░██╗░░░██╗░██████╗  ██╗░░░░░░█████╗░███╗░░██╗██████╗░░██████╗\r\n██╔══██╗██╔══██╗████╗░████║██╔══██╗██║░░░██║██╔════╝  ██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝\r\n██║░░╚═╝███████║██╔████╔██║██████╔╝██║░░░██║╚█████╗░  ██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░\r\n██║░░██╗██╔══██║██║╚██╔╝██║██╔═══╝░██║░░░██║░╚═══██╗  ██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗\r\n╚█████╔╝██║░░██║██║░╚═╝░██║██║░░░░░╚██████╔╝██████╔╝  ███████╗██║░░██║██║░╚███║██████╔╝██████╔╝\r\n░╚════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░░╚═════╝░╚═════╝░  ╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═════╝░");
                Console.WriteLine();
                Console.WriteLine("                                         Bienvenido a CampusLands               ");
                Console.WriteLine();
                Console.WriteLine("1. Registrate");
                Console.WriteLine("2. Camper Login");
                Console.WriteLine("3. Trainer Login");
                Console.WriteLine("4. Coordinador Login");
                Console.WriteLine("0. Salir");

                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue;
                }

                if (input == 0)
                {
                    Console.WriteLine("Saliendo...");
                    break;
                }

                switch (input)
                {
                    case 1:
                        MenuRegistro();
                        break;
                    case 2:
                        Console.WriteLine("Camper login");
                        break;
                    case 3:
                        Console.WriteLine("Trainer Login");
                        break;
                    case 4:
                        Console.WriteLine("Coordinador Login");
                            break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
            }
        }

        public static void LoginCoordinador()
        {
            Console.WriteLine("Ingresa tu email");
            String email = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            String contraseña = Console.ReadLine();


        }

        public static void MenuRegistro()
        {
            Console.Write("\nIngresa tu nombre: ");
            string nombre = Console.ReadLine()?.Trim();

            Console.Write("Ingresa tu apellido: ");
            string apellido = Console.ReadLine()?.Trim();

            Console.Write("Ingresa tu email: ");
            string email = Console.ReadLine()?.Trim();

            Console.Write("Ingresa una contraseña: ");
            string contraseña = Console.ReadLine();

            int identificacion;
            while (true)
            {
                Console.Write("Ingresa tu identificación (solo números): ");
                if (int.TryParse(Console.ReadLine(), out identificacion)) break;
                Console.WriteLine("Identificación inválida, intenta de nuevo.");
            }

            Console.Write("Ingresa tu dirección de residencia: ");
            string direccion = Console.ReadLine()?.Trim();

            Console.Write("Ingresa el nombre de un acudiente o familiar: ");
            string acudiente = Console.ReadLine()?.Trim();

            int telefono;
            while (true)
            {
                Console.Write("Ingresa tu teléfono (solo números): ");
                if (int.TryParse(Console.ReadLine(), out telefono)) break;
                Console.WriteLine("Teléfono inválido, intenta de nuevo.");
            }

            List<Modulo> modulos = new List<Modulo>();

            Camper camperIncrito = new Camper(nombre, apellido, email,
                contraseña, identificacion, direccion,
                acudiente, telefono, Estado.INSCRITO, false, null, modulos);

            CamperController.CrearCamper(camperIncrito);
            Console.WriteLine("\n¡Camper inscrito exitosamente!\n");

        }
    }
}
