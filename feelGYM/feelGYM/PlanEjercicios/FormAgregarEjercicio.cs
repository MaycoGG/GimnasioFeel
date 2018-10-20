using feelGYM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feelGYM
{
    public partial class FormAgregarEjercicio : Form
    {
        public FormAgregarEjercicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //metodo que carga el comboBox del tipo de ejercicio
        private void FormAgregarEjercicio_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tipoejercicio";
            string atributo = "nombre";
            Clases.Metodos cb = new Clases.Metodos();
            cb.LlenarCombo(cmb_tipoEjercicioAgregar, query, atributo);
        }

      

        //metedo que cierra el formulario
        private void btn_cerrarPlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_buscarNombre_Click(object sender, EventArgs e)
        {
            dgv_todosLosEjercicios.DataSource = Metodos.BuscarEjercicio(txt_buscar.Text);
        }

        //metodo que busca ejercicios mientras vas escribiendo te va cargando los nombres que van coincidiendo
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            
        }


        //crea un objeto de tipo Ejercicio.
        public Ejercicio ejercicioSeleccionado { get; set; }
       

       

        private void btn_registrarEjercicio_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Ejercicio ejer = new Ejercicio();

                //si el txt_id (INVISIBLE) esta vacio, va a agregar
                if (string.IsNullOrEmpty(txt_idEjercicioModificar.Text))
                {
                    //consulta para guardar el ejercicio
                    string query = "insert into ejercicios (nombre, tipoEjercicio) values ('{0}', '{1}')";

                    ejer.Nombre = txt_nombreEjercicioNuevo.Text;
                    ejer.Tipo = cmb_tipoEjercicioAgregar.SelectedIndex + 1;

                    //llamo al metodo de la clase "Metodos" y le paso por parametro el ejercicio creado y la consulta
                    int retorno = Metodos.AgregarEjercicioNuevo(ejer, query);
                    if (retorno > 0)
                    {
                        MessageBox.Show("Se agrego correctamente!", "Ejercicio Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_nombreEjercicioNuevo.Clear();
                        cmb_tipoEjercicioAgregar.SelectedItem = null;

                        //actualizo el data grid view
                        #region
                        Clases.Metodos m = new Clases.Metodos();
                        string query2 = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id " +
                            "FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id ORDER BY tipoejercicio.id";

                        //llena de grilla con todos los ejercicios
                        m.LlenarGridEjercicios(dgv_todosLosEjercicios, query2);
                        #endregion
                    }
                    else { MessageBox.Show("Ocurrió un error"); }
                }
                else
                {
                    //consulta para actualizar el ejercicio
                    string query = "UPDATE ejercicios set nombre ='{0}', tipoEjercicio = '{1}' where id = '{2}'";

                    ejer.Nombre = txt_nombreEjercicioNuevo.Text;
                    ejer.Tipo = cmb_tipoEjercicioAgregar.SelectedIndex + 1;
                    ejer.Id = Convert.ToInt32(txt_idEjercicioModificar.Text);

                    //llamo al metodo de la clase "Metodos" y le paso por parametro el ejercicio creado y la consulta
                    int retorno = Metodos.ModificarEjercicio(ejer, query);
                    if (retorno > 0)
                    {
                        MessageBox.Show("Ejercicio modificado correctamente!", "Ejercicio Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_nombreEjercicioNuevo.Clear();
                        txt_idEjercicioModificar.Clear();
                        cmb_tipoEjercicioAgregar.SelectedItem = null;

                        //actualizo el data grid view
                        #region
                        Clases.Metodos m = new Clases.Metodos();
                        string query2 = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id " +
                            "FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id ORDER BY tipoejercicio.id";

                        //llena de grilla con todos los ejercicios
                        m.LlenarGridEjercicios(dgv_todosLosEjercicios, query2);
                        #endregion
                    }
                    else { MessageBox.Show("Ocurrió un error"); }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_cancelarEjer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_mostrarEj_Click(object sender, EventArgs e)
        {
            //si esta invisible, lo despliega
            if (gb_listaEjercicios.Visible == false)
            {
                gb_listaEjercicios.Visible = true;

                Clases.Metodos m = new Clases.Metodos();
                string query = "SELECT ejercicios.nombre AS 'NOMBRE', tipoejercicio.nombre AS 'TIPO EJERCICIO', ejercicios.id " +
                    "FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id ORDER BY tipoejercicio.id";

                //llena de grilla con todos los ejercicios
                m.LlenarGridEjercicios(dgv_todosLosEjercicios, query);
            }
            else
            {
                //cuando esta vacio, lo pone invisible. Borra los datos de la grilla.
                gb_listaEjercicios.Visible = false;
                dgv_todosLosEjercicios.DataSource = null;
                dgv_todosLosEjercicios.Refresh();
            }
        }


        private void txt_nombreEjercicioNuevo_Leave_1(object sender, EventArgs e)
        {
            if (txt_nombreEjercicioNuevo.Text == "")
            {
                txt_nombreEjercicioNuevo.Text = "NOMBRE";
                txt_nombreEjercicioNuevo.ForeColor = Color.DimGray;
            }
        }

        private void txt_nombreEjercicioNuevo_Enter(object sender, EventArgs e)
        {
            if (txt_nombreEjercicioNuevo.Text == "NOMBRE")
            {
                txt_nombreEjercicioNuevo.Text = "";
                txt_nombreEjercicioNuevo.ForeColor = Color.Black;
            }
        }

        private void txt_buscar_TextChanged_1(object sender, EventArgs e)
        {
            dgv_todosLosEjercicios.DataSource = Metodos.BuscarEjercicio(txt_buscar.Text);
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_nombreEjercicioNuevo.Text == "")
            {
                txt_nombreEjercicioNuevo.Text = "BUSCAR EJERCICIO";
                txt_nombreEjercicioNuevo.ForeColor = Color.DimGray;
            }
        }

        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "BUSCAR EJERCICIO")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.Black;
            }
        }


        //BTN MODIFICAR EJERCICIO
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_todosLosEjercicios.SelectedRows.Count == 1)
            {
                //obtiene el id del ejercicio que se selecciono
                int id = Convert.ToInt32(dgv_todosLosEjercicios.CurrentRow.Cells["id"].Value);
                //busca el ejercicio con el id encontrado recien
                ejercicioSeleccionado = Metodos.ObtenerEjercicio(id);
            }

            //si encontro el ejercicio, lo busca y lo muestra en los campos correspondientes
            if (ejercicioSeleccionado != null)
            {
                txt_nombreEjercicioNuevo.Text = ejercicioSeleccionado.Nombre;
                txt_nombreEjercicioNuevo.ForeColor = Color.Black;
                txt_idEjercicioModificar.Text = Convert.ToString(ejercicioSeleccionado.Id);
                gb_listaEjercicios.Visible = false;
            }

            //Metodos que controlan de que tipo es para cargar el comboBox
            #region
            if (dgv_todosLosEjercicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ejercicioSeleccionado.Tipo == 1)
                {
                    cmb_tipoEjercicioAgregar.SelectedIndex = 0;
                }
                if (ejercicioSeleccionado.Tipo == 2)
                {
                    cmb_tipoEjercicioAgregar.SelectedIndex = 1;
                }
                if (ejercicioSeleccionado.Tipo == 3)
                {
                    cmb_tipoEjercicioAgregar.SelectedIndex = 2;
                }
                if (ejercicioSeleccionado.Tipo == 4)
                {
                    cmb_tipoEjercicioAgregar.SelectedIndex = 3;
                }
                if (ejercicioSeleccionado.Tipo == 5)
                {
                    cmb_tipoEjercicioAgregar.SelectedIndex = 4;
                }
                if (ejercicioSeleccionado.Tipo == 6)
                {
                    cmb_tipoEjercicioAgregar.SelectedIndex = 5;
                }
                if (ejercicioSeleccionado.Tipo == 7)
                {
                    cmb_tipoEjercicioAgregar.SelectedIndex = 6;
                }
                if (ejercicioSeleccionado.Tipo == 8)
                {
                    cmb_tipoEjercicioAgregar.SelectedIndex = 7;
                }
            }
            #endregion

            //actualizo el data grid view
            #region
            Clases.Metodos m = new Clases.Metodos();
            string query2 = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id " +
                "FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id ORDER BY tipoejercicio.id";

            //llena de grilla con todos los ejercicios
            m.LlenarGridEjercicios(dgv_todosLosEjercicios, query2);
            #endregion
        }


        //BTN BORRAR EJERCICIO
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_todosLosEjercicios.SelectedRows.Count == 1)
            {
                //obtiene el id del ejercicio que se selecciono
                int id = Convert.ToInt32(dgv_todosLosEjercicios.CurrentRow.Cells[2].Value);
                //busca el ejercicio con el id encontrado recien
                ejercicioSeleccionado = Metodos.ObtenerEjercicio(id);

                string query = "DELETE FROM ejercicios where id = '{0}'";

                if (MessageBox.Show("Esta Seguro que desea eliminar el Ejercicio Actual", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Metodos.EliminarEjercicio(ejercicioSeleccionado, query) > 0)
                    {
                        txt_nombreEjercicioNuevo.Clear();
                        cmb_tipoEjercicioAgregar.SelectedItem = null;
                        MessageBox.Show("Ejercicio Eliminado Correctamente!", "Ejercicio Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //actualizo el data grid view
                        #region
                        Clases.Metodos m = new Clases.Metodos();
                        string query2 = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id " +
                            "FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id ORDER BY tipoejercicio.id";

                        //llena de grilla con todos los ejercicios
                        m.LlenarGridEjercicios(dgv_todosLosEjercicios, query2);
                        #endregion
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Ejercicio", "Ejercicio No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public Boolean ValidarDatos()
        {
            bool valida = true;
            int tipo = 0;

            if (txt_nombreEjercicioNuevo.Text == "NOMBRE")
            {
                errorProvider1.SetError(txt_nombreEjercicioNuevo, "Ingrese NOMBRE del ejercicio");
                valida = false;
            }
            else
            {
                errorProvider1.Clear();
                if (cmb_tipoEjercicioAgregar.SelectedIndex < 0)
                {
                    valida = false;
                    errorProvider1.SetError(cmb_tipoEjercicioAgregar, "Seleccione un TIPO DE EJERCICIO");
                }
                else
                {
                    int devolveme = devolverTipoEjercicio();
                    int contValidacion = Clases.Metodos.ValidarEjercicio(devolveme, txt_nombreEjercicioNuevo.Text);
                    if (contValidacion > 0)
                    {
                        MessageBox.Show("Existe un ejercicio con mismo tipo e igual nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valida = false;
                    }
                }
            }




            //if (txt_nombreEjercicioNuevo.Text == "")
            //{
            //    MessageBox.Show("Campo 'NOMBRE' vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    valida = false;
            //}
            //if (cmb_tipoEjercicioAgregar.SelectedIndex < 0)
            //{
            //    MessageBox.Show("Seleccione un TIPO DE EJERCICIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    valida = false;
            //}

            


            return valida;
        }

        public int devolverTipoEjercicio()
        {
            int tipo = 0;

            if (cmb_tipoEjercicioAgregar.SelectedIndex == 0)
            {
                tipo = 1;
            }
            if (cmb_tipoEjercicioAgregar.SelectedIndex == 1)
            {
                tipo = 2;
            }
            if (cmb_tipoEjercicioAgregar.SelectedIndex == 2)
            {
                tipo = 3;
            }
            if (cmb_tipoEjercicioAgregar.SelectedIndex == 3)
            {
                tipo = 4;
            }
            if (cmb_tipoEjercicioAgregar.SelectedIndex == 4)
            {
                tipo = 5;
            }
            if (cmb_tipoEjercicioAgregar.SelectedIndex == 5)
            {
                tipo = 6;
            }
            if (cmb_tipoEjercicioAgregar.SelectedIndex == 6)
            {
                tipo = 7;
            }
            if (cmb_tipoEjercicioAgregar.SelectedIndex == 7)
            {
                tipo = 8;
            }


            return tipo;
        }
    }
}
