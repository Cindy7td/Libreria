using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasuraForms.Classes
{
    class UVendedor : Usuario
    {
        List<Libro> misLibros;

        public UVendedor(string nombre, float dinero): base(nombre, dinero)
        {
            misLibros = new List<Libro>();
        }

        internal List<Libro> MisLibros { get => misLibros; set => misLibros = value; }


    }
}
