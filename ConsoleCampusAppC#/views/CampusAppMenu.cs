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

                int input = Convert.ToInt32(Console.ReadLine());
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

        public static void MenuRegistro()
        {
            Console.WriteLine("Ingresa tu nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu apellido: ");
            String apellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu email: ");
            String email = Console.ReadLine();

            Console.WriteLine("Ingresa una contraseña: ");
            String contraseña = Console.ReadLine();

            Console.WriteLine("Ingresa tu identificacion: ");
            int identificacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu direccion de residencia: ");
            String direccion = Console.ReadLine();

            Console.WriteLine("Ingresa el nombre de un acudiente o familair: ");
            String acudiente = Console.ReadLine();

            Console.WriteLine("Ingresa tu telefono: ");
            int telefono = Convert.ToInt32(Console.ReadLine());

            List<Modulo> modulos = new List<Modulo>();

            Camper camperIncrito = new Camper(nombre, apellido, email, 
                contraseña, identificacion, direccion, 
                acudiente, telefono, Estado.INSCRITO, false, null, modulos);

            CamperController.CrearCamper(camperIncrito);
            Console.WriteLine("Camper inscrito exitosamente!");
            
        }
    }
}
