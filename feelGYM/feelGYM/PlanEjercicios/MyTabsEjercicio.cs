using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feelGYM.PlanEjercicios
{
    public class MyTabPage : TabPage
    {
        private Form frm;

        public  MyTabPage (MyFormPage frm_contenido, int i, int numPag, int nroSocio)
        {
            this.frm = frm_contenido;
            this.Controls.Add(frm_contenido.pnl);
            this.Text = "SESIÓN " + i;
            this.AutoScroll = true;
            frm_contenido.labelPag.Text = i.ToString();
            frm_contenido.numPlan.Text = numPag.ToString();
            frm_contenido.dniSocio.Text = nroSocio.ToString();
        }


        protected override void Dispose (bool disposing)
        {
            if (disposing)
            {
                frm.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    public class MyFormPage : Form
    {
        public Panel pnl;
        public Label labelPag;
        public Label numPlan;
        public Label dniSocio;
    }
}
