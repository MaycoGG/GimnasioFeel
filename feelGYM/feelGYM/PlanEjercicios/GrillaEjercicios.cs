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
    public partial class GrillaEjercicios : Form
    {
        Clases.Metodos m = new Clases.Metodos();

        public GrillaEjercicios()
        {
            InitializeComponent();
        }

        private void GrillaEjercicios_Load(object sender, EventArgs e)
        {
            FormPlanEjercicios plan = new FormPlanEjercicios();
            String query = ""; 

            if (checkBoxAero.Checked == true)
            {
                query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7)";
            }
            else
            {
                if (checkBoxZona.Checked == true)
                {
                    query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (8)";
                }
                else
                {
                    if (checkBoxAero.Checked == true && checkBoxZona.Checked == true)
                    {
                        query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7, 8)";
                    }
                    else
                    {
                        query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7, 8)";
                    }
                }
            }

            //String query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio' FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id";

            m.LlenarGrid(dataGridEjercicios, query);

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow item in dataGridEjercicios.Rows)
            {
                FormPlanEjercicios plan = new FormPlanEjercicios();
                Clases.Metodos m = new Clases.Metodos();

                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Selected Rows: " + item.Cells[0].RowIndex.ToString());

                    MessageBox.Show("NOmbre Rows: " + item.Cells[1].Value.ToString());

                    m.LlenarGridConGrid(plan.dgv_EntradaCalor, item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString());

                    
                }
            }
            //int cantselec = 0;

            //for (int i = 0; i < dataGridEjercicios.Rows.Count; i++)
            //{
            //    if (dataGridEjercicios.Rows[i].Cells[0].Value.ToString() == null)
            //    {

            //    }
            //    else
            //    {
            //        bool isCellChecked = bool.Parse(dataGridEjercicios.Rows[i].Cells[0].Value.ToString());
            //        if (isCellChecked == true)
            //        {
            //            MessageBox.Show("Is Checked");
            //            cantselec++;
            //        }
            //    }



            //}
            //MessageBox.Show("Is Checked: " + cantselec);


        }
    }
}
