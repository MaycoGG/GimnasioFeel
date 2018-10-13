using feelGYM.PlanEjercicios;
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
    public partial class FormPlanDatos : Form
    {
        public FormPlanDatos()
        {
            InitializeComponent();
        }

        private void btn_cerrarPlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //txt_fechaActualPlan.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_fechaActualPlan.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txt_NombreClientePlan_Enter(object sender, EventArgs e)
        {
            if (txt_NombreClientePlan.Text == "NOMBRE")
            {
                txt_NombreClientePlan.Text = "";
                txt_NombreClientePlan.ForeColor = Color.LightGray;
            }
        }

        private void txt_NombreClientePlan_Leave(object sender, EventArgs e)
        {
            if (txt_NombreClientePlan.Text == "")
            {
                txt_NombreClientePlan.Text = "NOMBRE";
                txt_NombreClientePlan.ForeColor = Color.DimGray;
            }
        }

        private void txt_apellidoClientePlan_Enter(object sender, EventArgs e)
        {
            if (txt_apellidoClientePlan.Text == "APELLIDO")
            {
                txt_apellidoClientePlan.Text = "";
                txt_apellidoClientePlan.ForeColor = Color.LightGray;
            }
        }

        private void txt_apellidoClientePlan_Leave(object sender, EventArgs e)
        {
            if (txt_apellidoClientePlan.Text == "")
            {
                txt_apellidoClientePlan.Text = "APELLIDO";
                txt_apellidoClientePlan.ForeColor = Color.DimGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormPlanEjercicios form = new FormPlanEjercicios();
            //form.Show();
            TabsSesiones tab = new TabsSesiones();
            tab.Show();
            Decimal cantsesiones = cmb_sesionesPlan.Value;

            for (int i = 0; i < cantsesiones; i++)
            {
                int sesion = i + 1;
                tab.tabControl1.TabPages.Add(new MyTabPage(new FormPlanEjercicios(), sesion));
            }


        }

        private void btn_agregarProfeEnPlan_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProfesor_AGREGAR form = new FormProfesor_AGREGAR();
            form.Show();
            
        }

        private void FormPlanDatos_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM profesores";
            string atributo = "nombreApe";
            Clases.Metodos cb = new Clases.Metodos();
            cb.LlenarCombo(cmb_profesor, query, atributo);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
