using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII_TPI_RoccaFederico
{
    class Inscripcion
    {
        public Materia materia { get; set; }
        public Alumno alumno { get; set; }
        public DateTime fecha { get; set; }
        public int cuatrimestre { get; set; }
        public Sede sede { get; set; }
    }
}
