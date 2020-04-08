using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII_TPI_RoccaFederico
{
    class Horario
    {
        public DateTime hora { get; set; }
        public Dictionary <int, string> dias { get; set; } = new Dictionary<int, string>();
    }
}
