using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class Camper : Usuario
    {
        

        public String Direccion {  get; set; }
        public String Acudiente { get; set; }
        public int Telefono { get; set; }
        public Estado Estado { get; set; }
        public bool Riesgo { get; set; }
        public Curso Curso { get; set; }
        public List<Modulo> ModulosCursados { get; set; }

        public Camper(string nombre, string apellido, string email, 
            string contraseña, int identificacion, String direccion, String acudiente, 
            int telefono, Estado estado, bool riesgo, Curso curso, List<Modulo> modulosCursados) : base(nombre, apellido, email, contraseña, identificacion)
        {
            this.Telefono = telefono;
            this.Estado = estado;
            this.Acudiente = acudiente;
            this.Curso = curso;
            this.Direccion = direccion;
            this.Riesgo = riesgo;
            this.ModulosCursados = modulosCursados;
        }
    }
}
