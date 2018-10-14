using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class DetallePlan
    {
        public int nroPlan { get; set; }
        public int dniSocio { get; set; }
        public int nroSesion { get; set; }
        public int tipoDetalle { get; set; }
        public int idEjercicio { get; set; }
        public string obsEC { get; set; }
        public string intensidad { get; set; }
        public int series { get; set; }
        public string repe { get; set; }
        public string obsD { get; set; }

        public DetallePlan(int nroPlan, int dniSocio, int nroSesion, int tipoDetalle, int idEje, string obsEC, string inten, int series ,string repe, string obsD)
        {
            this.nroPlan = nroPlan;
            this.dniSocio = dniSocio;
            this.nroSesion = nroSesion;
            this.tipoDetalle = tipoDetalle;
            this.idEjercicio = idEje;
            this.obsEC = obsEC;
            this.intensidad = intensidad;
            this.series = series;
            this.repe = repe;
            this.obsD = obsD;
        }

        public DetallePlan(int nroPlan, int dniSocio, int nroSesion, int idEje)
        {
            this.nroPlan = nroPlan;
            this.dniSocio = dniSocio;
            this.nroSesion = nroSesion;
            this.idEjercicio = idEje;
        }

        public DetallePlan()
        {
        }

    }
}
