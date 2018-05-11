using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBasura.Classes;
using LibreriaBasura.Enums;

namespace LibreriaBasura
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            UVendedor vend1 = new UVendedor("Juan", 200f);

            inventario.AddLibro("Kill a Mockingbird", "Lee", 400f, new LCarac(Genero.NoFiccion), vend1);
            inventario.AddLibro("Viaje mas largo", "Nicholas Sparks", 150f, new LCarac(Genero.Romance), vend1);
            inventario.AddLibro("Harry Potter", "J.K.Rowling", 169f, new LCarac(Genero.Aventura), vend1);
        }
    }
}
