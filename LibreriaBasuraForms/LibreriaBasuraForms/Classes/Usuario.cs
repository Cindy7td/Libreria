using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasuraForms.Classes
{
    abstract class Usuario
    {
        string id = new Random().Next(0, 10000).ToString("D6");
        string nombre, contrasenia;
        float dinero;

        public Usuario(string nombre, string contrasenia, float dinero)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.dinero = dinero;
        }

        public float Dinero { get => dinero; set => dinero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Id { get => id; set => id = value; }
    }
}
