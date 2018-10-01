using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace feelGYM.Clases
{
    public class TipoSangre
    {
        public int id_tipoSangre { get; set; }
        public String nombre_tipoSangre { get; set; }

        public TipoSangre()
        {

        }

        public TipoSangre(int id, String nombre)
        {
            this.id_tipoSangre = id;
            this.nombre_tipoSangre = nombre;
        }

        //public static IList<TipoSangre> Buscar(MySqlConnection conexion, String nombre)
        //{

        //}
    }
}
