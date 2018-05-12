using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProyectoFinal.Classes
{
    public abstract class Usuario
    {
        string nombre;
        float dinero;

        public Usuario(string nombre, float dinero)
        {
            this.nombre = nombre;
            this.dinero = dinero;
        }

        public float Dinero { get => dinero; set => dinero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
