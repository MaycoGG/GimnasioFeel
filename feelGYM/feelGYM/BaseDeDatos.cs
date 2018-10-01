using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feelGYM
{
    class BaseDeDatos
    {

        public ArrayList getColumnas()
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost; Uid=mayco; password=1234; Database=feelgym; SslMode=none");
            MySqlCommand cm = new MySqlCommand("select nombre from 'tiposangre';", cn);
            cm.CommandType = CommandType.StoredProcedure;
            cn.Open();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cm);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            ArrayList columnas = new ArrayList();
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                columnas.Add(ds.Tables[0].Columns[i].ColumnName);
            }
            return columnas;
        }
    }
}
