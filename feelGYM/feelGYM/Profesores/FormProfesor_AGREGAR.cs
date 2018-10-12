using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections;

namespace feelGYM
{
    public partial class FormProfesor_AGREGAR : Form
    {
        public FormProfesor_AGREGAR()
        {
            InitializeComponent();
        }

        private void txt_nombreProfe_Enter(object sender, EventArgs e)
        {
            if (txt_nombreProfe.Text == "NOMBRE")
            {
                txt_nombreProfe.Text = "";
                txt_nombreProfe.ForeColor = Color.LightGray;
            }
        }

        private void txt_nombreProfe_Leave(object sender, EventArgs e)
        {
            if (txt_nombreProfe.Text == "")
            {
                txt_nombreProfe.Text = "NOMBRE";
                txt_nombreProfe.ForeColor = Color.DimGray;
            }
        }

        private void txt_apellidoProfe_Enter(object sender, EventArgs e)
        {
            if (txt_apellidoProfe.Text == "APELLIDO")
            {
                txt_apellidoProfe.Text = "";
                txt_apellidoProfe.ForeColor = Color.LightGray;
            }
        }

        private void txt_apellidoProfe_Leave(object sender, EventArgs e)
        {
            if (txt_apellidoProfe.Text == "")
            {
                txt_apellidoProfe.Text = "APELLIDO";
                txt_apellidoProfe.ForeColor = Color.DimGray;
            }
        }

        private void txt_docProfe_Enter(object sender, EventArgs e)
        {
            if (txt_docProfe.Text == "NRO DOCUMENTO")
            {
                txt_docProfe.Text = "";
                txt_docProfe.ForeColor = Color.LightGray;
            }
        }

        private void txt_docProfe_Leave(object sender, EventArgs e)
        {
            if (txt_docProfe.Text == "")
            {
                txt_docProfe.Text = "NRO DOCUMENTO";
                txt_docProfe.ForeColor = Color.DimGray;
            }
        }

        private void txt_celProfe_Enter(object sender, EventArgs e)
        {
            if (txt_celProfe.Text == "CELULAR")
            {
                txt_celProfe.Text = "";
                txt_celProfe.ForeColor = Color.LightGray;
            }
        }

        private void txt_celProfe_Leave(object sender, EventArgs e)
        {
            if (txt_celProfe.Text == "")
            {
                txt_celProfe.Text = "CELULAR";
                txt_celProfe.ForeColor = Color.DimGray;
            }
        }

        private void txt_cerEmergenciaProfe_Enter(object sender, EventArgs e)
        {
            if (txt_cerEmergenciaProfe.Text == "CEL EMERGENCIA")
            {
                txt_cerEmergenciaProfe.Text = "";
                txt_cerEmergenciaProfe.ForeColor = Color.LightGray;
            }
        }

        private void txt_cerEmergenciaProfe_Leave(object sender, EventArgs e)
        {
            if (txt_cerEmergenciaProfe.Text == "")
            {
                txt_cerEmergenciaProfe.Text = "CEL EMERGENCIA";
                txt_cerEmergenciaProfe.ForeColor = Color.DimGray;
            }
        }

        private void txt_buscarPorNombre_Enter(object sender, EventArgs e)
        {
            if (txt_buscarPorNombre.Text == "BUSCAR POR NOMBRE/APELLIDO")
            {
                txt_buscarPorNombre.Text = "";
                txt_buscarPorNombre.ForeColor = Color.LightGray;
            }
        }

        private void txt_buscarPorNombre_Leave(object sender, EventArgs e)
        {
            if (txt_buscarPorNombre.Text == "")
            {
                txt_buscarPorNombre.Text = "BUSCAR POR NOMBRE/APELLIDO";
                txt_buscarPorNombre.ForeColor = Color.DimGray;
            }
        }


        private void txt_registrarProfe_Click(object sender, EventArgs e)
        {
            Clases.Profesores ejer = new Clases.Profesores();

            //si el TXT_DOCUMENTO esta vacio lo agrega, de lo contrario lo modifica.
            if (string.IsNullOrEmpty(txt_docProfe.Text))
            {
                //consulta para guardar el ejercicio
                string query = "insert into profesores (dniProfe, nombreApe, celular, celEmergencia, tipoSangre) values ('{0}', '{1}', '{2}', '{3}', '{4}')";

                ejer.Nombre = txt_nombreProfe.Text;
                ejer.Apellido = txt_apellidoProfe.Text;
                ejer.Dni = Convert.ToInt32(txt_docProfe.Text);
                ejer.Celular = Convert.ToDouble(txt_celProfe.Text);
                ejer.CelEmergencia = Convert.ToDouble(txt_cerEmergenciaProfe.Text);
                ejer.TipoSangre = cmb_sangreProfe.SelectedIndex + 1;


                //llamo al metodo de la clase "Metodos" y le paso por parametro el profesor creado y la consulta
                int retorno = Clases.Metodos.AgregarProfesor(ejer, query);
                if (retorno > 0)
                {
                    MessageBox.Show("Se agrego correctamente!", "Profesor Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nombreProfe.Clear();
                    txt_apellidoProfe.Clear();
                    txt_docProfe.Clear();
                    txt_celProfe.Clear();
                    txt_cerEmergenciaProfe.Clear();
                    cmb_sangreProfe.SelectedItem = null;

                    //actualizo el data grid view
                    #region
                    Clases.Metodos m = new Clases.Metodos();
                    string query2 = "SELECT profesores.nombreApe as 'Profesor', profesores.dniProfe as 'DNI', profesores.celular as 'Celular', " +
                    "profesores.celEmergencia as 'Cel Emergencia', tiposangre.nombre as 'Grupo Sanguineo' " +
                    "FROM profesores JOIN tiposangre ON profesores.tipoSangre = tiposangre.id ORDER BY 1";

                    //llena de grilla con todos los ejercicios
                    m.LlenarGridEjercicios(dgv_todosLosProfes, query2);
                    #endregion

                    //cierro el FORM
                    this.Close();
                }
                else { MessageBox.Show("Ocurrió un error"); }

            }
            else
            {
               
                //consulta para actualizar el ejercicio
                string query = "UPDATE profesores set nombreApe = '{1}', celular = '{2}', celEmergencia = '{3}', tipoSangre = '{4}' where dniProfe = '{0}'";

                //ejer.Nombre = txt_nombreProfe.Text;
                ejer.Apellido = txt_apellidoProfe.Text;
                String nomApe = ejer.Nombre + " " + ejer.Apellido;
                ejer.Celular = Convert.ToDouble(txt_celProfe.Text);
                ejer.CelEmergencia = Convert.ToDouble(txt_cerEmergenciaProfe.Text);
                ejer.TipoSangre = cmb_sangreProfe.SelectedIndex + 1;
                ejer.Dni = Convert.ToInt32(txt_docProfe.Text);
                


                //llamo al metodo de la clase "Metodos" y le paso por parametro el ejercicio creado y la consulta
                int retorno = Clases.Metodos.ModificarProfe(ejer, query);
                if (retorno > 0)
                {
                    MessageBox.Show("Profesor modificado correctamente!", "Profesor Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nombreProfe.Visible = true;
                    txt_nombreProfe.Clear();
                    txt_apellidoProfe.Clear();
                    txt_docProfe.Clear();
                    txt_celProfe.Clear();
                    txt_cerEmergenciaProfe.Clear();
                    cmb_sangreProfe.SelectedItem = null;

                    //actualizo el data grid view
                    #region
                    Clases.Metodos m = new Clases.Metodos();
                    string query2 = "SELECT profesores.nombreApe as 'Profesor', profesores.dniProfe as 'DNI', profesores.celular as 'Celular', " +
                    "profesores.celEmergencia as 'Cel Emergencia', tiposangre.nombre as 'Grupo Sanguineo' " +
                    "FROM profesores JOIN tiposangre ON profesores.tipoSangre = tiposangre.id ORDER BY 1";

                    //llena de grilla con todos los ejercicios
                    m.LlenarGridEjercicios(dgv_todosLosProfes, query2);
                    #endregion
                }
                else { MessageBox.Show("Ocurrió un error"); }

            }

            

        }

      

        private void cmb_sangreProfe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenarItems(ComboBox cb, String query, String atributo)
        {
            try
            {
                
                MySqlCommand cmd = new MySqlCommand(query, Clases.Conexion.obtenerConexion());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[atributo].ToString());
                }
                dr.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }

        private void FormProfesor_AGREGAR_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tiposangre";
            string atributo = "nombre";
            llenarItems(cmb_sangreProfe, query, atributo);
        }

        private void btn_cerrarPlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrarProfe_Click(object sender, EventArgs e)
        {
            //si esta invisible, lo despliega
            if (gb_profesores.Visible == false)
            {
                gb_profesores.Visible = true;

                Clases.Metodos m = new Clases.Metodos();
                string query = "SELECT profesores.nombreApe as 'Profesor', profesores.dniProfe as 'DNI', profesores.celular as 'Celular', " +
                    "profesores.celEmergencia as 'Cel Emergencia', tiposangre.nombre as 'Grupo Sanguineo' " +
                    "FROM profesores JOIN tiposangre ON profesores.tipoSangre = tiposangre.id ORDER BY 1";

                //llena de grilla con todos los ejercicios
                m.LlenarGridProfesores(dgv_todosLosProfes, query);
            }
            else
            {
                //cuando esta vacio, lo pone invisible. Borra los datos de la grilla.
                gb_profesores.Visible = false;
                dgv_todosLosProfes.DataSource = null;
                dgv_todosLosProfes.Refresh();
            }
        }

        private void txt_buscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            //dgv_todosLosProfes.DataSource = Clases.Metodos.BuscarProfe(txt_buscarPorNombre.Text);
        }

        //crea un objeto de tipo PROFESOR.
        public Clases.Profesores profeSeleccionado { get; set; }

        private void btn_modificarEjercicio_Click(object sender, EventArgs e)
        {
            if (dgv_todosLosProfes.SelectedRows.Count == 1)
            {
                //obtiene el DNI del Profe que se selecciono
                int dni = Convert.ToInt32(dgv_todosLosProfes.CurrentRow.Cells[1].Value);
                //busca el ejercicio con el id encontrado recien
                profeSeleccionado = Clases.Metodos.ObtenerProfe(dni);
            }

            //si encontro el ejercicio, lo busca y lo muestra en los campos correspondientes
            if (profeSeleccionado != null)
            {
                txt_docProfe.Enabled = false;
                txt_nombreProfe.Visible = false;
                txt_apellidoProfe.Text = profeSeleccionado.Apellido;
                txt_docProfe.Text = Convert.ToString(profeSeleccionado.Dni);
                txt_celProfe.Text = profeSeleccionado.Celular.ToString();
                txt_cerEmergenciaProfe.Text = Convert.ToString(profeSeleccionado.CelEmergencia);
            }

            //Metodos que controlan de que tipo es para cargar el comboBox
            #region
            if (dgv_todosLosProfes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (profeSeleccionado.TipoSangre == 1)
                {
                    cmb_sangreProfe.SelectedIndex = 0;
                }
                if (profeSeleccionado.TipoSangre == 2)
                {
                    cmb_sangreProfe.SelectedIndex = 1;
                }
                if (profeSeleccionado.TipoSangre == 3)
                {
                    cmb_sangreProfe.SelectedIndex = 2;
                }
                if (profeSeleccionado.TipoSangre == 4)
                {
                    cmb_sangreProfe.SelectedIndex = 3;
                }
                if (profeSeleccionado.TipoSangre == 5)
                {
                    cmb_sangreProfe.SelectedIndex = 4;
                }
                if (profeSeleccionado.TipoSangre == 6)
                {
                    cmb_sangreProfe.SelectedIndex = 5;
                }
                if (profeSeleccionado.TipoSangre == 7)
                {
                    cmb_sangreProfe.SelectedIndex = 6;
                }
                if (profeSeleccionado.TipoSangre == 8)
                {
                    cmb_sangreProfe.SelectedIndex = 7;
                }
            }
            #endregion
        }

        private void btn_borrarEjercicio_Click(object sender, EventArgs e)
        {

        }
    }
}
