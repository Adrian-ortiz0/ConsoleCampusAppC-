using System;
using System.Collections.Generic;
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

        public Camper(long id, string nombre, string apellido, 
            string email, string contraseña, string direccion, 
            string acudiente, int telefono, Estado estado, bool riesgo) : base(id, nombre, apellido, email, contraseña)
        {
            this.Estado = estado;
            this.Telefono = telefono;
            this.Riesgo = riesgo;
            this.Direccion = direccion;
            this.Acudiente = acudiente;
        }

    }
}
