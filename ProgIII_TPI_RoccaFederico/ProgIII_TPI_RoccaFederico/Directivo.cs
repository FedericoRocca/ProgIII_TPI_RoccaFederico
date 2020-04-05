using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII_TPI_RoccaFederico
{
    class Directivo : Persona
    {
        public Cargo cargo { get; set; }
        public List<Materia> materias { get; set; }
        public int nivel { get; set; }
    }
}
