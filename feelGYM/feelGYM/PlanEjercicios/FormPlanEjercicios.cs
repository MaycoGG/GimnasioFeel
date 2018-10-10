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
    public partial class FormPlanEjercicios : MyFormPage
    {
        

        public FormPlanEjercicios()
        {
            InitializeComponent();
            this.pnl = panel1;
            
        }

        private void FormPlanEjercicios_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean valor = ckb_AeroEC.Checked;
            GrillaEjercicios tab = new GrillaEjercicios();
            if (ckb_AeroEC.Checked)
            {
                tab.checkBoxAero.Checked = true;
            }
            if (ckb_ZonaEC.Checked)
            {
                tab.checkBoxZona.Checked = true;
            }

            tab.Show();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
