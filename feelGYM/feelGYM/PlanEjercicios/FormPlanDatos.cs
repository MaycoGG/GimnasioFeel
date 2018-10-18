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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txt_fechaActualPlan.Text = DateTime.Now.ToString("dd/MM/yyyy");
            picker_fechaInicio.Text =  DateTime.Now.ToString("dd/MM/yyyy");
            picker_fechaFin.Text = DateTime.Now.AddDays(30).ToString("dd/MM/yyyy");
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



        private void FormPlanDatos_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM profesores";
            string atributo = "nombreApe";
            Clases.Metodos cb = new Clases.Metodos();
            cb.LlenarCombo(cmb_profesor, query, atributo);
            txt_dniSocio.MaxLength = 8;

            picker_fechaInicio.MinDate = DateTime.Today;
            picker_fechaInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");

            picker_fechaFin.MinDate = DateTime.Today.AddDays(1);
            picker_fechaFin.Text = DateTime.Now.AddDays(30).ToString("dd/MM/yyyy");

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

            }

        }

        public Boolean ValidarDatos()
        {
            Boolean valida = true;
            
            if (txt_NombreClientePlan.Text == "NOMBRE")
            {
                MessageBox.Show("Campo 'NOMBRE' vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }

            if (txt_apellidoClientePlan.Text == "APELLIDO")
            {
                MessageBox.Show("Campo 'APELLIDO' vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }

            if (txt_dniSocio.Text == "DNI")
            {
                MessageBox.Show("Campo 'DNI' vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }
            

            if (cmb_sesionesPlan.Value < 1 || cmb_sesionesPlan.Value > 6)
            {
                MessageBox.Show("El número de sesiones acepta valores entre 1 y 6 inclusive", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }

            if (cmb_profesor.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un PROFESOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }

            return valida;
        }

        private void txt_dniSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txt_NombreClientePlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txt_apellidoClientePlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btn_registrarProfe_Click(object sender, EventArgs e)
        {

        }

        private void btn_armarPlan_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                #region agrega Socio

                string queryValidar = "select COUNT(socio.dni) FROM socio where socio.dni = " + Convert.ToInt32(txt_dniSocio.Text);

                int dniExiste = Clases.Metodos.ObtenerDniSocio(txt_NombreClientePlan.Text, txt_apellidoClientePlan.Text);
                int dniValidar = Clases.Metodos.ValidarSocio(Convert.ToInt32(txt_dniSocio.Text), queryValidar);
                if (dniExiste == 0 && dniValidar != 0)
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
                tab.dniSocio = plan.dniSocio;
                tab.numPlan = plan.numPlan;
                tab.Show();
                Decimal cantsesiones = cmb_sesionesPlan.Value;

                for (int i = 0; i < cantsesiones; i++)
                {
                    int sesion = i + 1;
                    tab.tabControl1.TabPages.Add(new MyTabPage(new FormPlanEjercicios(), sesion, plan.numPlan, plan.dniSocio));
                }
            }
            
        }

        private void btn_agregarProf_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProfesor_AGREGAR form = new FormProfesor_AGREGAR();
            form.Show();
        }

        private void picker_fechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
