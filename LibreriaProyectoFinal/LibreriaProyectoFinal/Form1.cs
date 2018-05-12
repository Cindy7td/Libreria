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
            comboBox1.DataSource = Enum.GetValues(typeof(Genero));

        }

        private void bttnAlta_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("");
            dt.Rows.Add(new object[] {""});

            //Genero gen = comboBox1.SelectedValue;
            var cbgenero = (Genero)Enum.Parse(typeof(Genero), comboBox1.SelectedValue.ToString());
            
            vendedor.AddLibro(inventario.Catalogo, txtTitulo.Text, txtAutor.Text,
                                float.Parse(txtPrecio.Text), new LCarac(cbgenero));

            dataGridView2.DataSource = dt;
            dataGridView1.DataSource = dt;

            dataGridView1.DataSource = inventario.Catalogo;
            dataGridView2.DataSource = vendedor.MisLibros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new FormComprador(inventario, vendedor);
            myForm.Show();
        }
    }
}
