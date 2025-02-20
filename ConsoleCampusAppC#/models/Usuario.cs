using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class Usuario
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Contraseña { get; set; }
        public int Identificacion { get; set; }

        public Usuario(string nombre, string apellido, string email, string contraseña, int identificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contraseña = contraseña;
            Identificacion = identificacion;
        }
    }
}
