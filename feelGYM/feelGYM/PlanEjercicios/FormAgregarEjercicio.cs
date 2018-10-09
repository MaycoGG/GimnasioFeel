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
            Ejercicios ejer = new Ejercicios();
            ejer.Id = 1;
            ejer.Nombre = txt_nombreEjercicio.Text;
            ejer.Tipo = cmb_tipoEjercicioAgregar.SelectedIndex;

            string query = "INSERT into ejercicios (id, nombre, tipoEjercicio) Values ('ejer.Id', 'ejer.Nombre', 'ejer.Tipo') ";
            Clases.Metodos cb = new Clases.Metodos();
            cb.Insertar(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregarEjercicio_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tipoejercicio";
            string atributo = "nombre";
            Clases.Metodos cb = new Clases.Metodos();
            cb.LlenarCombo(cmb_tipoEjercicioAgregar, query, atributo);
        }
    }
}
