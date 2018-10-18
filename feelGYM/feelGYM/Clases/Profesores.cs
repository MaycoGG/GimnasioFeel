using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class Profesores
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Celular { get; set; }
        public double CelEmergencia { get; set; }
        public int TipoSangre { get; set; }

        public Profesores() { }

        public Profesores(int dni, string nombre, string ape, double cel, double celEmer, int tiposangre) {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = Apellido;
            this.Celular = cel;
            this.CelEmergencia = celEmer;
            this.TipoSangre = tiposangre;
        }
        
       

    }
}
