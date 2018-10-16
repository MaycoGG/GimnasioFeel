using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class Class1
    {
        public string NombreSocio { get; set; }
        public string ApellidoSocio { get; set; }
        public int NroPlan { get; set; }
        public string NombreApeProfe { get; set; }
        public string NombreDetalle { get; set; }

        public Class1(string nombreSocio, string apellidoSocio, int nroPlan, string nombreApeProfe, string nombreDetalle)
        {
            NombreSocio = nombreSocio;
            ApellidoSocio = apellidoSocio;
            NroPlan = nroPlan;
            NombreApeProfe = nombreApeProfe;
            NombreDetalle = nombreDetalle;
        }

        public Class1()
        {
        }
    }
}
