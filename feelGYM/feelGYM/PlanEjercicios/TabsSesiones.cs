using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feelGYM.PlanEjercicios
{
    public partial class TabsSesiones : Form
    {
        public int dniSocio;
        public int numPlan;

        public TabsSesiones()
        {
            InitializeComponent();
        }

        private void TabsSesiones_Load(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_imprimirPlan_Click(object sender, EventArgs e)
        {
            
            
            if (MessageBox.Show("¿Guardo todas las sesiones? Recuerde que en caso de proseguir ya no podrá modificar el plan actual.", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormVistaPrevia fvp = new FormVistaPrevia();
                fvp.numPlan = numPlan;
                fvp.dni_Socio = dniSocio;
                fvp.Show();
                this.Close();
            }
            else
            {
                //
            }
            
        }

        private void btn_cerrarPlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            string query = "DELETE FROM detalleplanejercicios WHERE detalleplanejercicios.nroPlan = '{0}' AND detalleplanejercicios.dniSocio = '{1}'";
            Clases.Metodos.EliminarDetallePlanFINAL(numPlan, dniSocio, query);

            string query2 = "DELETE FROM planejercicios WHERE planejercicios.nroPlan = '{0}' AND planejercicios.dniSocio = '{1}'";
            Clases.Metodos.EliminarPlanEjercicios(numPlan, dniSocio, query2);
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void cerrarForm() {
            this.Close();
        }
    }
}
