using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace feelGYM.Clases
{
    public class Metodos
    {
        public void LlenarCombo(ComboBox cb, String query, String atributo)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, Clases.Conexion.obtenerConexion());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[atributo].ToString());
                   
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);

            }

        }

        public void Insertar( String query)
        {
         
            MySqlCommand cmd = new MySqlCommand(query, Clases.Conexion.obtenerConexion());
            

        }
    }
}
