using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasuraForms.Enums
{
    public enum Genero { Terror, Misterio, Romance, CienciaFiccion, NoFiccion, Aventura}

    static class EGenero
    {
        public static string GeneroToString(this Genero gen)
        {
            switch (gen)
            {
                case Genero.Terror:
                    return "Terror";
                case Genero.Misterio:
                    return "Misterio";
                case Genero.Romance:
                    return "Misterio";
                case Genero.CienciaFiccion:
                    return "Ciencia Ficcion";
                case Genero.NoFiccion:
                    return "No Ficcion";
                case Genero.Aventura:
                    return "Aventura";
                default:
                    return "NA";

            }
        }
    }
}
