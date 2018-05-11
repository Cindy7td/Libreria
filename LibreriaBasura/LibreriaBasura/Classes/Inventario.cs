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

        public void AddLibro(string titulo, string autor, float precio, LCarac caracteristicas, UVendedor vendedor)
        {
            Libro libro = new Libro(titulo, autor, precio, caracteristicas);
            catalogo.Add(libro);
            vendedor.MisLibros.Add(libro);
        }

        public Libro GetLibro(string nombreABuscar)
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

        public List<Libro> Buscar(LCarac libroToSearchByCaract)
        {
            List<Libro> LEncontrados = new List<Libro>();
            foreach (Libro libros in catalogo)
            {
                Libro libroToAdd = libros;
                if (libros.Caract.matches(libroToSearchByCaract))
                    LEncontrados.Add(libroToAdd);
            }
            return LEncontrados;
        }
        
    }
}
