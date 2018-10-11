using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM.Clases
{
    public class Ejercicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }

        public Ejercicio()
        {
        }

        public Ejercicio(int id, string nombre, int tipo)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
        }

        public Ejercicio(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
