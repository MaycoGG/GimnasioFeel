using System;
using System.Collections.Generic;
using System.Data;
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
                //cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);

            }

        }


        public static int AgregarEjercicioNuevo(Ejercicio ejer, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, ejer.Nombre, ejer.Tipo), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        public void Insertar( String query)
        {
         
            MySqlCommand cmd = new MySqlCommand(query, Clases.Conexion.obtenerConexion());
            

        }

        public void LlenarGrid(DataGridView grid, String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Clases.Conexion.obtenerConexion());

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;

            //tamaño columna
            grid.Columns[1].Width = 300;
            grid.Columns[2].Width = 170;

            //
            grid.Columns[3].Visible = false;
            


            //pone falso a todos los check box de la tabla.
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[0].Value = false;

            }
               

        }

        public void LlenarGridConGrid(DataGridView grid, String nombre, String tipo)
        {

            DataTable dt = new DataTable();

            grid.Rows.Add(nombre, tipo);
            grid.DataSource = dt;


            //tamaño columna
            grid.Columns[0].Width = 300;
            grid.Columns[1].Width = 170;

            //
            grid.Columns[2].Visible = false;



            //pone falso a todos los check box de la tabla.
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[3].Value = false;

            }


        }
    }
}
