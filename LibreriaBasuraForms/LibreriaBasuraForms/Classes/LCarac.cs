using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBasuraForms.Enums;

namespace LibreriaBasuraForms.Classes
{
    class LCarac
    {
        Genero genero;

        public LCarac()
        {

        }

        public LCarac(Genero genero)
        {
            this.genero = genero;
        }

        public Genero Genero { get => genero; set => genero = value; }

        public bool matches(LCarac specs)
        {
            if (specs.Genero != genero)
                return false;

            return true;
        }
    }
}
