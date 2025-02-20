using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class Usuario
    {
        public long Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Contraseña { get; set; }

        public Usuario(long id, string nombre, string apellido, string email, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contraseña = contraseña;
        }
    }
}
