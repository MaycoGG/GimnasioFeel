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


        //metodos para EJERCICIOS
        #region Ejercicios

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
            MySqlCommand cmd = new MySqlCommand(String.Format(
               "SELECT ejercicios.id, ejercicios.nombre, ejercicios.tipoEjercicio " +
               "FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id " +
               "where ejercicios.nombre LIKE '%{0}%' ORDER BY ejercicios.nombre", nombre), Conexion.obtenerConexion());


            //SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id " +
            //        "FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id ORDER BY tipoejercicio.id

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Ejercicio ejer = new Ejercicio();
                ejer.Id = reader.GetInt32(0);
                ejer.Nombre = reader.GetString(1);
                ejer.Tipo = reader.GetInt32(2);
                _lista.Add(ejer);
            }
            return _lista;
        }

        //metodo para obtener un ejercicio
        public static Ejercicio ObtenerEjercicio(int id)
        {
            Ejercicio ejer = new Ejercicio();

            MySqlCommand cmd = new MySqlCommand(String.Format("select nombre, tipoEjercicio, id from ejercicios where id = '{0}'", id), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ejer.Nombre = reader.GetString(0);
                ejer.Tipo = reader.GetInt32(1);
                ejer.Id = reader.GetInt32(2);
            }

            return ejer;
        }

        #endregion 





        //metodos para PROFESORES
        #region Profesores

        //metodo para agregar profesores
        public static int AgregarProfesor(Profesores profe, String query)
        {
            int retorno = 0;
            string nombreApe = profe.Apellido + " " + profe.Nombre;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, profe.Dni ,nombreApe, profe.Celular, profe.CelEmergencia, profe.TipoSangre), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para modificar datos profesor
        public static int ModificarProfe(Profesores profe, String query)
        {
            int retorno = 0;
            string nombreApe = profe.Apellido + " " + profe.Nombre;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, profe.Dni, nombreApe, profe.Celular, profe.CelEmergencia, profe.TipoSangre), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para eliminar ejercicios
        public static int EliminarProfe(Profesores ejer, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, ejer.Dni), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para buscar un profesor
        public static List<Profesores> BuscarProfe(string nombre)
        {
            List<Profesores> _lista = new List<Profesores>();

            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT profesores.nombreApe as 'Profesor', profesores.dniProfe as 'DNI', " +
                "profesores.celular as 'Celular', profesores.celEmergencia as 'Cel Emergencia', tiposangre.nombre as 'Grupo Sanguíneo' " +
                "FROM profesores JOIN tiposangre ON profesores.tipoSangre = tiposangre.id " +
                "where profesores.nombreApe LIKE '%{0}%' ORDER BY 1 ", nombre), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Profesores ejer = new Profesores();
                ejer.Nombre = reader.GetString(0);
                ejer.Apellido = reader.GetString(0);
                ejer.Dni = reader.GetInt32(1);
                ejer.Celular = reader.GetDouble(2);
                ejer.CelEmergencia = reader.GetDouble(3);
                

                _lista.Add(ejer);
            }
            return _lista;
        }

        //metodo para obtener un profesor
        public static Profesores ObtenerProfe(int dni)
        {
            Profesores ejer = new Profesores();

            MySqlCommand cmd = new MySqlCommand(String.Format("select dniProfe, nombreApe, celular, celEmergencia, tipoSangre from profesores where dniProfe = '{0}'", dni), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ejer.Apellido = reader.GetString(1);
                ejer.Celular= reader.GetDouble(2);
                ejer.CelEmergencia = reader.GetDouble(3);
                ejer.TipoSangre = reader.GetInt32(4);
                ejer.Dni = reader.GetInt32(0);
            }

            return ejer;
        }



        #endregion

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
            //grid.Columns[2].Width = 50;

        }

        public void LlenarGridProfesores(DataGridView grid, String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Clases.Conexion.obtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            grid.DataSource = dt;

            //tamaño columna
            grid.Columns[0].Width = 200;
            grid.Columns[1].Width = 100;
            grid.Columns[2].Width = 100;
            grid.Columns[3].Width = 100;
            grid.Columns[4].Width = 100;

        }

    }
}
