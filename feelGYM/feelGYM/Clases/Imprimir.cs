using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class Imprimir
    {
        public string NombreSocio { get; set; }
        public string ApellidoSocio { get; set; }
        public int NroPlan { get; set; }
        public string NombreApeProfe { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public string objetivo { get; set; }
        public string observacionPlan { get; set; }
        public int nroSesion { get; set; }
        public string observacionDetalle { get; set; }
        public string intesidad { get; set; }
        public int series { get; set; }
        public string repeticiones { get; set; }
        public string ejercicio { get; set; }
        public string tipoEjercicio { get; set; }
        public string tipoDetalle { get; set; }

        public Imprimir(string nombreSocio, string apellidoSocio, int nroPlan, string nombreApeProfe, string fechaInicio, string fechaFin, string objetivo, string observacionPlan, int nroSesion, string observacionDetalle, string intesidad, int series, string repeticiones, string ejercicio, string tipoEjercicio, string tipoDetalle)
        {
            NombreSocio = nombreSocio;
            ApellidoSocio = apellidoSocio;
            NroPlan = nroPlan;
            NombreApeProfe = nombreApeProfe;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.objetivo = objetivo;
            this.observacionPlan = observacionPlan;
            this.nroSesion = nroSesion;
            this.observacionDetalle = observacionDetalle;
            this.intesidad = intesidad;
            this.series = series;
            this.repeticiones = repeticiones;
            this.ejercicio = ejercicio;
            this.tipoEjercicio = tipoEjercicio;
            this.tipoDetalle = tipoDetalle;
        }

        public Imprimir()
        {
        }
    }
}
