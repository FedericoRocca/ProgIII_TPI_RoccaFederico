using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII_TPI_RoccaFederico
{
    class Cursada
    {
        public Inscripcion inscripcion { get; set; }
        public bool resultado { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public List<Evaluacion> evaluaciones { get; set; }
    }
}
