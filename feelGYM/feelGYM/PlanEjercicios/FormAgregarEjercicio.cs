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

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio ejer = new Ejercicio();
            ejer.Nombre = txt_nombreEjercicioNuevo.Text;
            ejer.Tipo = cmb_tipoEjercicioAgregar.SelectedIndex + 1;

            //consulta para guardar el ejercicio
            string query = "insert into ejercicios (nombre, tipoEjercicio) values ('{0}', '{1}')";

            //llamo al metodo de la clase "Metodos" y le paso por parametro el ejercicio creado y la consulta
            int retorno = Metodos.AgregarEjercicioNuevo(ejer, query);
            if (retorno > 0)
            {
                MessageBox.Show("Se agregó correctamente");
                txt_nombreEjercicioNuevo.Clear();
            }
            else { MessageBox.Show("Ocurrió un error"); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregarEjercicio_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tipoejercicio";
            string atributo = "nombre";
            Clases.Metodos cb = new Clases.Metodos();
            cb.LlenarCombo(cmb_tipoEjercicioAgregar, query, atributo);
        }

        private void btn_cerrarPlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gb_listaEjercicios.Visible = true;
        }
    }
}
