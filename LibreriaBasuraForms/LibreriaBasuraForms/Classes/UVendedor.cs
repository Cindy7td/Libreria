using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasuraForms.Classes
{
    public class UVendedor : Usuario
    {
        List<Libro> misLibros;

        public UVendedor(string nombre, float dinero): base(nombre, dinero)
        {
            misLibros = new List<Libro>();
        }

        internal List<Libro> MisLibros { get => misLibros; set => misLibros = value; }

        public void AddLibro(List<Libro> lL, string titulo, string autor, float precio, LCarac caracteristicas)
        {
            Libro libro = new Libro(titulo, autor, precio, caracteristicas);
            misLibros.Add(libro);
            lL.Add(libro);
        }
    }
}
