using feelGYM.Clases;
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

            //GrillaEjercicios g = new GrillaEjercicios();
            //List<Ejercicio> listEjer = g.retornarLista();

            ////List<Ejercicio> listEjer = new List<Ejercicio>();
            ////listEjer.Add(new Ejercicio(1, "Mauri"));

            //DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();

            //dgv_EntradaCalor.Columns.Add(c1);
            //dgv_EntradaCalor.Columns.Add(c2);

            //foreach (Ejercicio item in listEjer)
            //{
            //    dgv_EntradaCalor.Rows.Add(item.Id, item.Nombre);
            //}
        }

        private void FormPlanEjercicios_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            panel3.Height = 188;
            panel4.Location = new Point(88, 385);
           


            Metodos m = new Metodos();
            String query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7, 8)";

            if (ckb_AeroEC.Checked == true && ckb_ZonaEC.Checked == true)
            {
                query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7, 8)";

            }
            else
            {
                if (ckb_AeroEC.Checked == true)
                {
                    query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7)";
                }
                else
                {
                    if (ckb_ZonaEC.Checked == true)
                    {
                        query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (8)";
                    }

                }
            }
            

            //String query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio' FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id";

            m.LlenarGrid(dgv_EjerciciosEC, query);

        }
    

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_EntradaCalor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_EntradaCalor_Load(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void aceptar_Ejer_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dgv_EjerciciosEC.Rows)
            {

                Clases.Metodos m = new Clases.Metodos();

                if (bool.Parse(item.Cells[0].Value.ToString()))
                {

                    dgv_EntradaCalor.Rows.Add(item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString());
   
                }
            }
            for (int i = 0; i < dgv_EjerciciosEC.Rows.Count; i++)
            {
                dgv_EjerciciosEC.Rows[i].Cells[0].Value = false;

            }

            panel3.Height = 0;
            panel4.Location = new Point(88, 194);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgv_EntradaCalor.CurrentRow == null)
            {
                return;
            }
            else
            {
                dgv_EntradaCalor.Rows.Remove(dgv_EntradaCalor.CurrentRow);
            }
            
        }

        private void btn_ejerDesarrollo_Click(object sender, EventArgs e)
        {

        }
    }
}
