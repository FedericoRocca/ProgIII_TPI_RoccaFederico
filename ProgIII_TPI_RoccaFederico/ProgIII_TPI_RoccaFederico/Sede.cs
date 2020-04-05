using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII_TPI_RoccaFederico
{
    class Sede
    {
        public Localizacion localizacion { get; set; }
        public List<Carrera> carreras { get; set; }
        public List<Directivo> directivos { get; set; }
        public List<Contacto> contactos { get; set; }
    }
}
