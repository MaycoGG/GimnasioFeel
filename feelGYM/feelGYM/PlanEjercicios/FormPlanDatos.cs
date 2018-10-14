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
            //txt_fechaActualPlan.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txt_NombreClientePlan_Enter(object sender, EventArgs e)
        {
            if (txt_NombreClientePlan.Text == "NOMBRE")
            {
                txt_NombreClientePlan.Text = "";
                txt_NombreClientePlan.ForeColor = Color.Black;
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
                txt_apellidoClientePlan.ForeColor = Color.Black;
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

        private void txt_dniSocio_Enter(object sender, EventArgs e)
        {
            if (txt_dniSocio.Text == "DNI")
            {
                txt_dniSocio.Text = "";
                txt_dniSocio.ForeColor = Color.Black;
            }
        }

        private void txt_dniSocio_Leave(object sender, EventArgs e)
        {
            if (txt_dniSocio.Text == "")
            {
                txt_dniSocio.Text = "DNI";
                txt_dniSocio.ForeColor = Color.DimGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region agrega Socio

            int dniExiste = Clases.Metodos.ObtenerDniSocio(txt_NombreClientePlan.Text, txt_apellidoClientePlan.Text);
            if (dniExiste == 0)
            {
                Clases.Socio socio = new Clases.Socio();
                string query = "INSERT INTO socio (dni, nombre, apellido) values ('{0}', '{1}', '{2}')";
                socio.Dni = Convert.ToInt32(txt_dniSocio.Text);
                socio.Nombre = txt_NombreClientePlan.Text;
                socio.Apellido = txt_apellidoClientePlan.Text;
                int retorno = Clases.Metodos.AgregarSocio(socio, query);
            }

            #endregion

            #region agrega PlanEjercicios
            Clases.PlanEjercicio plan = new Clases.PlanEjercicio();
            string query2 = "INSERT INTO planejercicios (nroPlan, dniSocio, fechaInicio, fechaFin, numSesiones, dniProfe, objetivo, observacion) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";

            int nroPlan = Clases.Metodos.ObtenerNroPlanSocio(Convert.ToInt32(txt_dniSocio.Text));
            plan.numPlan = nroPlan + 1;
            plan.dniSocio = Convert.ToInt32(txt_dniSocio.Text);
            plan.fechaInicio = picker_fechaInicio.Text;
            plan.fechaFin = picker_fechaFin.Text;
            plan.numSesiones = Convert.ToInt32(cmb_sesionesPlan.Value);
            plan.dniProfe = Clases.Metodos.ObtenerDniProfe(cmb_profesor.Text);
            plan.objetivo = txt_obj.Text;
            plan.obserb = txt_obs.Text;
            int retorno2 = Clases.Metodos.AgregarDatosPlan(plan, query2);
            #endregion



            TabsSesiones tab = new TabsSesiones();
            tab.Show();
            Decimal cantsesiones = cmb_sesionesPlan.Value;

            for (int i = 0; i < cantsesiones; i++)
            {
                int sesion = i + 1;
                tab.tabControl1.TabPages.Add(new MyTabPage(new FormPlanEjercicios(), sesion, plan.numPlan, plan.dniSocio));
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

        private void cmb_profesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
