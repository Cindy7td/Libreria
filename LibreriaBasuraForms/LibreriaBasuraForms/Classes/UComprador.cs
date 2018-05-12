using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasuraForms.Classes
{
    class UComprador: Usuario
    {
        public UComprador(string email, string nombre, string contrasenia, float dinero): base(email, nombre, contrasenia, dinero)
        {

        }
    }
}
