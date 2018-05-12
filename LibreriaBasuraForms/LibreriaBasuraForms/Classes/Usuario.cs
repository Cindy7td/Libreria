using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasuraForms.Classes
{
    abstract class Usuario
    {
        string email, nombre, contrasenia;
        float dinero;

        public Usuario(string email, string nombre, string contrasenia, float dinero)
        {
            this.email = email;
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.dinero = dinero;
        }

        public float Dinero { get => dinero; set => dinero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Email { get => email; set => email = value; }
    }
}
