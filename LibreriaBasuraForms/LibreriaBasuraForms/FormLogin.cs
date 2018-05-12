using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBasuraForms.Classes;
using LibreriaBasuraForms.Enums;
using LibreriaBasuraForms.Utilities;

namespace LibreriaBasuraForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();



            //Inventario inventario = new Inventario();
            UVendedor vend1 = new UVendedor("Juan", "pepito", 200f);

            //inventario.AddLibro("Kill a Mockingbird", "Lee", 400f, new LCarac(Genero.NoFiccion), vend1);
            //inventario.AddLibro("Viaje mas largo", "Nicholas Sparks", 150f, new LCarac(Genero.Romance), vend1);
            //inventario.AddLibro("Harry Potter", "J.K.Rowling", 169f, new LCarac(Genero.Aventura), vend1);
        }
    }
}
