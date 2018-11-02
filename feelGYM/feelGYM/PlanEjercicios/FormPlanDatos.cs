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
            ////txt_fechaActualPlan.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //picker_fechaInicio.Text =  DateTime.Now.ToString("dd/MM/yyyy");
            //picker_fechaFin.Text = DateTime.Now.AddDays(30).ToString("dd/MM/yyyy");
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
            Clases.Metodos cb = new Clases.Metodos();

            //CARGA PROFESORES
            string query = "SELECT * FROM profesores";
            string atributo = "nombreApe";
            cb.LlenarCombo(cmb_profesor, query, atributo);
            txt_dniSocio.MaxLength = 8;

            picker_fechaInicio.MinDate = DateTime.Today;
            picker_fechaFin.MinDate = DateTime.Today.AddDays(1);
            picker_fechaInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

            if (txt_dniSocio.Text == "DNI")
            {
                errorProvider1.SetError(txt_dniSocio, "Ingrese DNI");
                valida = false;
            }
            else
            {
                errorProvider1.Clear();
                if (txt_apellidoClientePlan.Text == "APELLIDO")
                {
                    valida = false;
                    errorProvider1.SetError(txt_apellidoClientePlan, "Ingrese APELLIDO");
                }
                else
                {
                    errorProvider1.Clear();
                    if (txt_NombreClientePlan.Text == "NOMBRE")
                    {
                        valida = false;
                        errorProvider1.SetError(txt_NombreClientePlan, "Ingrese NOMBRE");
                    }
                    else
                    {
                        errorProvider1.Clear();
                        if (cmb_profesor.SelectedIndex < 0)
                        {
                            errorProvider1.SetError(cmb_profesor, "Seleccione un PROFESOR");
                            valida = false;
                        }
                        else
                        {
                            errorProvider1.Clear();
                            if (cmb_sesionesPlan.Value < 1 || cmb_sesionesPlan.Value > 6)
                            {
                                errorProvider1.SetError(cmb_sesionesPlan, "El número de sesiones debe ser entre 1 y 6");
                                valida = false;
                            }
                        }
                    }
                }
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
            txt_dniSocio.Text = "DNI";
            txt_dniSocio.ForeColor = Color.DimGray;

            txt_apellidoClientePlan.Text = "APELLIDO";
            txt_apellidoClientePlan.ForeColor = Color.DimGray;

            txt_NombreClientePlan.Text = "NOMBRE";
            txt_NombreClientePlan.ForeColor = Color.DimGray;

            cmb_sesionesPlan.Value = 1;

            txt_obj.Text = "";
            txt_obs.Text = "";

            cmb_profesor.SelectedIndex = -1;

            picker_fechaInicio.MinDate = DateTime.Today;
            picker_fechaFin.MinDate = DateTime.Today.AddDays(1);
            picker_fechaInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            picker_fechaFin.Text = DateTime.Now.AddDays(30).ToString("dd/MM/yyyy");

        }

        private void btn_armarPlan_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                #region agrega Socio

                //Negrada
                //int dni = Clases.Metodos.ObtenerDniSocio(txt_NombreClientePlan.Text, txt_apellidoClientePlan.Text);

                int dni = Clases.Metodos.ValidarSocio(Convert.ToInt32(txt_dniSocio.Text));

                if (dni > 0)
                {
                    //si existe, actualiza los datos
                    Clases.Socio socio = new Clases.Socio();
                    string query = "UPDATE socio SET socio.nombre = '" + txt_NombreClientePlan.Text.ToString() + "' , socio.apellido = '" + txt_apellidoClientePlan.Text.ToString() + "' WHERE socio.dni = " + Convert.ToInt32(txt_dniSocio.Text);
                    socio.Dni = Convert.ToInt32(txt_dniSocio.Text);
                    socio.Nombre = txt_NombreClientePlan.Text;
                    socio.Apellido = txt_apellidoClientePlan.Text;
                    int retorno = Clases.Metodos.AgregarSocio(socio, query);
                }
                else
                {
                    //si no existe, lo AGREGA
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

        

        private void picker_fechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_dniSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BUSCAR SOCIO
            List<Clases.Socio> socio = new List<Clases.Socio>();
            if (txt_dniSocio.Text == "DNI")
            {
                MessageBox.Show("Debe ingresar un DNI para buscar sus datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                socio = Clases.Metodos.BuscarSocio(Convert.ToInt32(txt_dniSocio.Text));
                if (socio.Count > 0)
                {
                    foreach (Clases.Socio item in socio)
                    {
                        txt_apellidoClientePlan.Text = item.Apellido;
                        txt_apellidoClientePlan.ForeColor = Color.Black;
                        txt_NombreClientePlan.Text = item.Nombre;
                        txt_NombreClientePlan.ForeColor = Color.Black;

                    }
                }
                else { MessageBox.Show("No existe un SOCIO con ese DNI, complete los campos.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            

            
            
        }
    }
}
