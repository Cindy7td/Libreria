﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasuraForms.Classes
{
    public class Inventario
    {
        List<Libro> catalogo;

        internal List<Libro> Catalogo { get => catalogo; set => catalogo = value; }

        public Inventario()
        {
            catalogo = new List<Libro>();
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

        public void ComprarLibro(List<Libro> lVendedor, Libro clibro)
        {
            catalogo.Remove(clibro);
            lVendedor.Remove(clibro);

        }

    }
}
