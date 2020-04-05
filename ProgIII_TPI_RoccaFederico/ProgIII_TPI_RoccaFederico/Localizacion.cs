using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace ProgIII_TPI_RoccaFederico
{
    class Localizacion
    {
        public string direccion { get; set; }
        public string localidad { get; set; }
        public GeoCoordinate coordenadas { get; set; }
    }
}
