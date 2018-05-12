using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProyectoFinal.Classes
{
    public class Libro
    {
        string titulo, autor;
        float precio;
        LCarac caract;

        public Libro(string titulo, string autor, float precio, LCarac caracteristicas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.precio = precio;
            caract = new LCarac();
            caract.Genero = caracteristicas.Genero;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public float Precio { get => precio; set => precio = value; }
        internal LCarac Caract { get => caract; set => caract = value; }

        public override string ToString()
        {
            return titulo;
        }
    }
}
