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

        //metodo para agregar ejercicios
        public static int AgregarEjercicioNuevo(Ejercicio ejer, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, ejer.Nombre, ejer.Tipo), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para modificar ejercicios
        public static int ModificarEjercicio(Ejercicio ejer, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, ejer.Nombre, ejer.Tipo, ejer.Id), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para eliminar ejercicios
        public static int EliminarEjercicio(Ejercicio ejer, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, ejer.Id), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para buscar un ejercicio
        public static List<Ejercicio> BuscarEjercicio(string nombre)
        {
            List<Ejercicio> _lista = new List<Ejercicio>();

            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT ejercicio.id, ejercicio.nombre, tipoejercicio.nombre " +
                "FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id " +
                "where nombre LIKE '%{0}%'", nombre), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Ejercicio ejer = new Ejercicio();
                ejer.Nombre = reader.GetString(1);
                ejer.Tipo = reader.GetInt32(2);
                ejer.Id = reader.GetInt32(0);

                _lista.Add(ejer);
            }
            return _lista;
        }

        //metodo para obtener un ejercicio
        public static Ejercicio ObtenerEjercicio(int id)
        {
            Ejercicio ejer = new Ejercicio();

            MySqlCommand cmd = new MySqlCommand(String.Format("select id, nombre, tipoEjercicio from ejercicios where id = '{0}'", id), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ejer.Nombre = reader.GetString(1);
                ejer.Tipo = reader.GetInt32(2);
                ejer.Id = reader.GetInt32(0);
            }

            return ejer;
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


        public void LlenarGridEjercicios(DataGridView grid, String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Clases.Conexion.obtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            grid.DataSource = dt;

            //tamaño columna
            grid.Columns[0].Width = 200;
            grid.Columns[1].Width = 170;
            grid.Columns[2].Visible = false;

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
