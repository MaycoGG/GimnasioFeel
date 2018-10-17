using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class ImpresionDetalle
    {
        public string observacionDetalle { get; set; }
        public string intesidad { get; set; }
        public string series { get; set; }
        public string repeticiones { get; set; }
        public string ejercicio { get; set; }

        public ImpresionDetalle(string observacionDetalle, string intesidad, string series, string repeticiones, string ejercicio)
        {
            this.observacionDetalle = observacionDetalle;
            this.intesidad = intesidad;
            this.series = series;
            this.repeticiones = repeticiones;
            this.ejercicio = ejercicio;
        }

        public ImpresionDetalle()
        {

        }

        public ImpresionDetalle(string ejercicio)
        {
            this.ejercicio = ejercicio;
        }
    }
}
