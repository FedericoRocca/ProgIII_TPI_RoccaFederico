using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII_TPI_RoccaFederico
{
    class Alumno : Persona
    {
        public Carrera carrera { get; set; }
        public int legajo { get; set; }
    }
}
