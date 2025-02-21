using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.views
{
    class CoordinadorMenu
    {

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Bienvenido coordinador");
                Console.WriteLine();
                Console.WriteLine("1. Probar campers inscritos");
                Console.WriteLine("2. Contratar trainers");
                Console.WriteLine("3. Contratar coordinadores");
                Console.WriteLine("4. Crear salones");
                Console.WriteLine("5. Crear rutas de entrenamiento");
                Console.WriteLine("6. Crear modulos");
                Console.WriteLine("7. Crear cursos");
                Console.WriteLine("8. Gestion de campers cursando");
                Console.WriteLine("0. Salir");

                if(!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue;
                }

                if(input == 0)
                {
                    Console.WriteLine("Saliendo...");
                    break;
                }
            }
        }
    }
}
