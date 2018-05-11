using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBasuraForms.Utilities.IO
{
    class Lectura
    {
        public static string[] leer()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Temp\Log_in.txt");

            return lines;
        }
    }
}
