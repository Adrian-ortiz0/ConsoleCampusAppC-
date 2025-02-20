using ConsoleCampusAppC_.views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_
{
    public class Operacion
    {
        public String Tipo {  get; set; }
        public double Resultado { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CampusAppMenu.Menu();
        }
    }
}
