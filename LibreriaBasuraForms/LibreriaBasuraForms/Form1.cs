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
    public partial class Form1 : Form
    {
        UVendedor vendedor;
        Inventario inventario;

        public Form1()
        {
            InitializeComponent();

            vendedor = new UVendedor("Juan", 200f);
            inventario = new Inventario();

            
        }

        private void bttnAlta_Click(object sender, EventArgs e)
        {
            vendedor.AddLibro(inventario.Catalogo, txtTitulo.Text, txtAutor.Text,
                                float.Parse(txtPrecio.Text), new LCarac(Genero.NoFiccion));

            dataGridView1.DataSource = inventario.Catalogo;
            //dataGridView2.DataSource = vendedor.MisLibros;
            //listBox2.Text. = inventario.Catalogo;

            //foreach (Libro l in vendedor.MisLibros)
            //{
            //    dataGridView2.DataSource = vendedor.MisLibros;
            //}
        }
    }
}
