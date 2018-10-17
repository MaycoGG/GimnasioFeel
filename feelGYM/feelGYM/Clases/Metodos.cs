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
            grid.Columns[1].ReadOnly = true;
            grid.Columns[2].Width = 170;
            grid.Columns[2].ReadOnly = true;
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

        public void LlenarGridReporte(DataGridView grid, String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Clases.Conexion.obtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            grid.DataSource = dt;

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

        //metodo para agregar Socio
        public static int AgregarSocio(Socio s, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, s.Dni, s.Nombre, s.Apellido), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        public static int ValidarSocio(int dniSocio, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, dniSocio), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        public static int ValidarProfe(int dniProfe, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, dniProfe), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para agregar DatosPlan
        public static int AgregarDatosPlan(PlanEjercicio plan, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, plan.numPlan, plan.dniSocio, plan.fechaInicio, plan.fechaFin, 
                plan.numSesiones, plan.dniProfe, plan.objetivo, plan.obserb), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }


        //metodo para agregar Detalle ENTRADA EN CALOR
        public static int AgregarDatosDetallePlanEC(DetallePlan plan, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, plan.nroPlan, plan.dniSocio, plan.nroSesion, plan.tipoDetalle, plan.idEjercicio,
                plan.obsEC), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para agregar Detalle PLAN DESARROLLO
        public static int AgregarDatosDetallePlanDesarrollo(DetallePlan plan, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, plan.nroPlan, plan.dniSocio, plan.nroSesion, plan.tipoDetalle, plan.idEjercicio,
                plan.intensidad, plan.series, plan.repe, plan.obsD), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para eliminar DETALLE DE PLAN
        public static int EliminarDetallePlan(DetallePlan plan, String query)
        {
            int retorno = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format(query, plan.nroPlan, plan.dniSocio, plan.nroSesion, plan.idEjercicio), Conexion.obtenerConexion());
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        //metodo para obtener un DETALLEPLAB
        public static DetallePlan ObtenerDetallePlan(int nroPlan, int dniSocio, int sesion, int idEjer)
        {
            DetallePlan plan = new DetallePlan();

            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT detalleplanejercicios.nroPlan, detalleplanejercicios.dniSocio, " +
                "detalleplanejercicios.nroSesion, detalleplanejercicios.idEjercicio from detalleplanejercicios " +
                "where detalleplanejercicios.nroPlan = '{0}' AND detalleplanejercicios.dniSocio = '{1}'" +
                "and detalleplanejercicios.nroSesion  = '{2}' and detalleplanejercicios.idEjercicio = '{3}'", nroPlan, dniSocio, sesion, idEjer), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                plan.nroPlan = reader.GetInt32(0);
                plan.dniSocio = reader.GetInt32(1);
                plan.nroSesion = reader.GetInt32(2);
                plan.idEjercicio = reader.GetInt32(3);
            }

            return plan;
        }

        //metodo para obtener un dni profesor
        public static int ObtenerDniProfe(string nombre)
        {
            int doc = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format("select dniProfe from profesores where nombreApe = '{0}'", nombre), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                doc = reader.GetInt32(0);
            }
            return doc;
        }

        //metodo para obtener un dni socio
        public static int ObtenerDniSocio(string nombre, string apellido)
        {
            int doc = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format("select dni from socio where nombre = '{0}' " +
                "and apellido = '{1}'", nombre, apellido), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                doc = reader.GetInt32(0);
            }
            return doc;
        }

        //metodo para obtener numero de PLAN de un SOCIO
        public static int ObtenerNroPlanSocio(int dniSocio)
        {
            
            int contador = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT COUNT(planejercicios.dniSocio) from planejercicios where planejercicios.dniSocio = '{0}'", dniSocio), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contador = reader.GetInt32(0);
            }
            return contador;
        }

        //metodo para comparar si existe detalle
        public static int compararDetalle(int nroPlan, int dniSocio, int numSesion, int id_eje)
        {
            int contador = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT COUNT(*) from detalleplanejercicios where detalleplanejercicios.nroPlan='{0}' " +
                "AND detalleplanejercicios.dniSocio='{1}' AND detalleplanejercicios.nroSesion='{2}' AND detalleplanejercicios.idTipoDetalle IN (1,2) " +
                "AND detalleplanejercicios.idEjercicio='{3}'", nroPlan, dniSocio, numSesion, id_eje), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contador = reader.GetInt32(0);
            }
            return contador;
        }


        //metodo para obtener numero de SESIONES DE UN PLAN
        public static int ObtenerNroSesiones(int nroPlan,int dniSocio)
        {
            int contador = 0;
            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT planejercicios.numSesiones from planejercicios where planejercicios.nroPlan = '{0}' AND planejercicios.dniSocio = '{1}'", nroPlan ,dniSocio), Conexion.obtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contador = reader.GetInt32(0);
            }
            return contador;
        }

        

    }
}
