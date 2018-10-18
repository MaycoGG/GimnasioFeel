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

            FormVistaPrevia fvp = new FormVistaPrevia();
            fvp.numPlan = numPlan;
            fvp.dni_Socio = dniSocio;
            fvp.Show();
        }

        private void btn_cerrarPlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
