using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace feelGYM.Conexion
{
    class Conexion
    {
        public static MySqlConnection obtenerConexion() {
            MySqlConnection conexion = new MySqlConnection("datasource=192.168.0.16; Uid=mayco; password=1234; Database=feelgym; SslMode=none");
            //MySqlConnection conexion = new MySqlConnection("datasource=localhost; Uid=mayco; password=1234; Database=feelgym; SslMode=none");
            conexion.Open();
            return conexion;
        }
    }
}
