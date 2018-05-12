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
    public partial class FormComprador : Form
    {
        UComprador comprador;
        Inventario inventario;
        UVendedor vendedor;
        DataTable dt;
        List<Libro> lLibros;

        public FormComprador(Inventario inventario, UVendedor vendedor)
        {
            InitializeComponent();

            comprador = new UComprador("Juana", 0f);
            this.inventario = inventario;
            this.vendedor = vendedor;
            cbGenero.DataSource = Enum.GetValues(typeof(Genero));
            lLibros = inventario.Catalogo;
            ShowData();
        }

        private void bttnComprar_Click(object sender, EventArgs e)
        {
            string tTitulo = string.Empty;
            foreach(DataGridViewCell item in this.dataGridView1.SelectedCells)
            {
                tTitulo = item.Value.ToString();
            }

            Libro tLibro = inventario.GetLibro(tTitulo);
            comprador.ComprarLibro(inventario.Catalogo, vendedor.MisLibros, tLibro);
            
            if (comprador.ValidarSaldo(tLibro))
            {
                inventario.Catalogo.Remove(tLibro);
                vendedor.MisLibros.Remove(tLibro);
            }

            lLibros = inventario.Catalogo;
            ShowData();
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            lLibros = new List<Libro>();
            lLibros.Add(inventario.GetLibro(txtBTitulo.Text));

            ShowData();

            
        }

        private void bttnBuscarG_Click(object sender, EventArgs e)
        {
            Genero tGenero;
            try
            {
               tGenero = (Genero)Enum.Parse(typeof(Genero), cbGenero.SelectedValue.ToString());
            }
            catch (NullReferenceException)
            {
                return;
            }
            lLibros = inventario.Buscar(new LCarac(tGenero));

            ShowData();
        }

        public void ShowData()
        {
            dt = new DataTable();
            dt.Columns.Add("");
            dt.Rows.Add(new object[] { "" });

            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = lLibros;
        }

        private void bttnAddDinero_Click(object sender, EventArgs e)
        {
            comprador.AgregarSaldo();
        }
    }
}
