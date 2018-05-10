using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasura.Classes
{
    class Inventario
    {
        List<Libro> catalogo;

        public Inventario()
        {
             catalogo = new List<Libro>();
        }
        
        public void addLibro(string titulo, string autor, float precio, LCarac caracteristicas)
        {
            Libro libro = new Libro(titulo, autor, precio, caracteristicas);
            catalogo.Add(libro);
        }

        public Libro getLibro(string nombreABuscar)
        {
            foreach (Libro libros in catalogo)
            {
                if (libros.Titulo == nombreABuscar)
                {
                    return libros;
                }
            }
            return null;
        }
        

    }
}
