﻿using System;
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

        public  MyTabPage (MyFormPage frm_contenido, int i)
        {
            this.frm = frm_contenido;
            this.Controls.Add(frm_contenido.pnl);
            this.Text = "Sesion " + i;
            this.AutoScroll = true;
            frm_contenido.labelPag.Text = i.ToString();

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
    }
}
