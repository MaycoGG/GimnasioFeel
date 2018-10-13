using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class PlanEjercicio
    {
        public int numPlan { get; set; }
        public int dniSocio { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int numSesiones { get; set; }
        public int dniProfe { get; set; }
        public string objetivo { get; set; }
        public string obserb { get; set; }

        public PlanEjercicio(int numPlan, int dniSocio, DateTime fechaInicio, DateTime fechaFin, int numSesiones, int dniProfe, string objetivo, string obserb)
        {
            this.numPlan = numPlan;
            this.dniSocio = dniSocio;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.numSesiones = numSesiones;
            this.dniProfe = dniProfe;
            this.objetivo = objetivo;
            this.obserb = obserb;
        }

        public PlanEjercicio()
        {
        }
    }
}
