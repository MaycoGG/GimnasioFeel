using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class Socio
    {
        public  int Dni { get; set; }
        public  string Nombre { get; set; }
        public  string Apellido { get; set; }

        public Socio()
        {

        }

        public Socio (int dni, string n, string a)
        {
            this.Dni = dni;
            this.Nombre = n;
            this.Apellido = a;
        }

        public Socio(string n, string a)
        {
            this.Nombre = n;
            this.Apellido = a;
        }
    }
}
