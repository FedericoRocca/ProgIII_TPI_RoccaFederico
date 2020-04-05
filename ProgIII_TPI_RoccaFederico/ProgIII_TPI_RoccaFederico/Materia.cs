using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII_TPI_RoccaFederico
{
    class Materia
    {
        public List<Profesor> profesores { get; set; }
        public List<Alumno> alumnos { get; set; }
        public List<Evaluacion> evaluaciones { get; set; }
    }
}
