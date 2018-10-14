using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class PlanEjercicio
    {
        public int id { get; set; }
        public int numPlan { get; set; }
        public int dniSocio { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public int numSesiones { get; set; }
        public int dniProfe { get; set; }
        public string objetivo { get; set; }
        public string obserb { get; set; }

        public PlanEjercicio(int id,int numPlan, int dniSocio, string fechaInicio, string fechaFin, int numSesiones, int dniProfe, string objetivo, string obserb)
        {
            this.id = id;
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
