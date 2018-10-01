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

        Clases.Conexion conexion = new Clases.Conexion();

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

        private void txt_mailProfe_Enter(object sender, EventArgs e)
        {
            if (txt_mailProfe.Text == "MAIL")
            {
                txt_mailProfe.Text = "";
                txt_mailProfe.ForeColor = Color.LightGray;
            }
        }

        private void txt_mailProfe_Leave(object sender, EventArgs e)
        {
            if (txt_mailProfe.Text == "")
            {
                txt_mailProfe.Text = "MAIL";
                txt_mailProfe.ForeColor = Color.DimGray;
            }
        }

        private void txt_registrarProfe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void cmb_sangreProfe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Clases.Conexion.obtenerConexion();
            try
            {
                string selectQuery = "SELECT * FROM tiposangre";
                MySqlCommand command = new MySqlCommand(selectQuery);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                cmb_sangreProfe.ValueMember = "id";
                cmb_sangreProfe.DisplayMember = "nombre";
                cmb_sangreProfe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
