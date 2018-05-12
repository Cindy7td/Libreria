using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaProyectoFinal.Classes;

namespace LibreriaProyectoFinal.Classes
{
    class UComprador: Usuario
    {

        public UComprador(string nombre, float dinero):base(nombre, dinero)
        {

        }

        //quitarlo de ambas listas, quitar el dinero de su cuenta y agregarsela al vendedor
        public void ComprarLibro(List<Libro> lInventario, List<Libro> lVendedor, Libro clibro)
        {
            if (ValidarSaldo(clibro))
            {
                lInventario.Remove(clibro);
                lVendedor.Remove(clibro);
            }
            
        }

        public bool ValidarSaldo(Libro xLibro)
        {
            
            if (Dinero >= xLibro.Precio)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Fondos insuficientes");
                return false;
            }
        }

        public void AgregarSaldo()
        {
            Dinero += 1000f;
        }
    }
}
