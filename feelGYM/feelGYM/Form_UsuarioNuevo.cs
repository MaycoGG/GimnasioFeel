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
    public partial class Form_UsuarioNuevo : Form
    {
        public Form_UsuarioNuevo()
        {
            InitializeComponent();
        }

        private void btn_nuevoProfe_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormProfesor_AGREGAR form2 = new FormProfesor_AGREGAR();
            form2.Show();
        }
    }
}
