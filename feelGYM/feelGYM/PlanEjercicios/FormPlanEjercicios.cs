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
            this.labelPag = lbl_numPag;
            this.numPlan = lbl_numPlan;
            this.dniSocio = lbl_dniSocio;
        }

        private void FormPlanEjercicios_Load(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel3.SendToBack();
            panel4.BringToFront();
            panel5.SendToBack();
        }


        private void aceptar_Ejer_Click(object sender, EventArgs e)
        {

            
        }

        //crea un objeto de tipo Ejercicio.
        public DetallePlan planSeleccionado { get; set; }


        //metodo que borra de la BD un ejercicio de la ENTRADA EN CALOR y actualiza la grilla.
        private void button5_Click(object sender, EventArgs e)
        {
            

        }



        private void btn_quitarEjerDes_Click(object sender, EventArgs e)
        {
            
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btn_aceptarPag_Click(object sender, EventArgs e)
        {
            

            
            
        }

        private void btn_aceptarPag_Click_1(object sender, EventArgs e)
        {
            Boolean flag = true;

            foreach (DataGridViewRow item in dgv_EntradaCalor.Rows)
            {
                Clases.DetallePlan detalle = new Clases.DetallePlan();
                string query = "INSERT into detalleplanejercicios (detalleplanejercicios.nroPlan, detalleplanejercicios.dniSocio, " +
                    "detalleplanejercicios.nroSesion, detalleplanejercicios.idTipoDetalle, detalleplanejercicios.idEjercicio, " +
                    "detalleplanejercicios.observacionesEC) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                detalle.nroPlan = Convert.ToInt32(lbl_numPlan.Text);
                detalle.dniSocio = Convert.ToInt32(lbl_dniSocio.Text);
                detalle.nroSesion = Convert.ToInt32(lbl_numPag.Text);
                detalle.tipoDetalle = 1;
                detalle.idEjercicio = Convert.ToInt32(item.Cells["Id"].Value);
                if (item.Cells["ObservacionEC"].Value == null)
                {
                    detalle.obsEC = "";

                }
                else
                {
                    detalle.obsEC = item.Cells["ObservacionEC"].Value.ToString();
                }
                

                int contador = Clases.Metodos.compararDetalle(detalle.nroPlan, detalle.dniSocio, detalle.nroSesion, detalle.idEjercicio);

                if (contador != 0)
                {
                    flag = false;
                    string queryDelete = "DELETE FROM detalleplanejercicios where detalleplanejercicios.nroPlan = '{0}' " +
                        "AND detalleplanejercicios.dniSocio = '{1}' and detalleplanejercicios.nroSesion = '{2}' " +
                        "AND detalleplanejercicios.idEjercicio = '{3}' AND detalleplanejercicios.idTipoDetalle = 1 ";
                    Metodos.EliminarDetallePlan(detalle, queryDelete);
                    int retorno = Clases.Metodos.AgregarDatosDetallePlanEC(detalle, query);
                }
                else
                {

                    int retorno = Clases.Metodos.AgregarDatosDetallePlanEC(detalle, query);
                }


            }

            foreach (DataGridViewRow item in dgv_Desarrollo.Rows)
            {
                Clases.DetallePlan detalle = new Clases.DetallePlan();
                string query = "INSERT into detalleplanejercicios (detalleplanejercicios.nroPlan, detalleplanejercicios.dniSocio, " +
                    "detalleplanejercicios.nroSesion, detalleplanejercicios.idTipoDetalle, detalleplanejercicios.idEjercicio, " +
                    "detalleplanejercicios.intensidad, detalleplanejercicios.series, detalleplanejercicios.repeticiones, detalleplanejercicios.observacionesEC) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')";
                detalle.nroPlan = Convert.ToInt32(lbl_numPlan.Text);
                detalle.dniSocio = Convert.ToInt32(lbl_dniSocio.Text);
                detalle.nroSesion = Convert.ToInt32(lbl_numPag.Text);
                detalle.tipoDetalle = 2;
                detalle.idEjercicio = Convert.ToInt32(item.Cells["IDD"].Value);

                #region ValidaCeldasVacias

                if (item.Cells["intensidad"].Value == null)
                {
                    detalle.intensidad = "";
                }
                else
                {
                    detalle.intensidad = item.Cells["intensidad"].Value.ToString();
                }

                if (item.Cells["series"].Value == null)
                {
                    detalle.series = "";
                }
                else
                {
                    detalle.series = item.Cells["series"].Value.ToString();
                }

                if (item.Cells["repeticiones"].Value == null)
                {
                    detalle.repe = "";
                }
                else
                {
                    detalle.repe = item.Cells["repeticiones"].Value.ToString();
                }

                if (item.Cells["observacionD"].Value == null)
                {
                    detalle.obsD = "";
                }
                else
                {
                    detalle.obsD = item.Cells["observacionD"].Value.ToString();
                }

                #endregion



                int contador = Clases.Metodos.compararDetalle(detalle.nroPlan, detalle.dniSocio, detalle.nroSesion, detalle.idEjercicio);

                if (contador != 0)
                {
                    flag = false;
                    string queryDelete = "DELETE FROM detalleplanejercicios where detalleplanejercicios.nroPlan = '{0}' " +
                        "AND detalleplanejercicios.dniSocio = '{1}' and detalleplanejercicios.nroSesion = '{2}' " +
                        "AND detalleplanejercicios.idEjercicio = '{3}' AND detalleplanejercicios.idTipoDetalle = 2 ";
                    Metodos.EliminarDetallePlan(detalle, queryDelete);
                    int retorno = Clases.Metodos.AgregarDatosDetallePlanDesarrollo(detalle, query);
                }
                else
                {
                    int retorno = Clases.Metodos.AgregarDatosDetallePlanDesarrollo(detalle, query);
                }


            }

            if (flag == false)
            {
                MessageBox.Show("Existen ejercicios repetidos, se guarda solo el último de ellos.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se guardo correctamente la sesión.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_EntradaCalor.SelectedRows.Count == 1)
            {
                int nroPlan = Convert.ToInt32(lbl_numPlan.Text);
                int dni = Convert.ToInt32(lbl_dniSocio.Text);
                int nroSesion = Convert.ToInt32(lbl_numPag.Text);
                int idEjercicio = Convert.ToInt32(dgv_EntradaCalor.CurrentRow.Cells["Id"].Value);
                planSeleccionado = Clases.Metodos.ObtenerDetallePlan(nroPlan, dni, nroSesion, idEjercicio);

                string query = "DELETE FROM detalleplanejercicios where detalleplanejercicios.nroPlan = '{0}' " +
                        "AND detalleplanejercicios.dniSocio = '{1}' and detalleplanejercicios.nroSesion = '{2}' " +
                        "AND detalleplanejercicios.idEjercicio = '{3}' AND detalleplanejercicios.idTipoDetalle = 1 ";
                Metodos.EliminarDetallePlan(planSeleccionado, query);

                //la borra de la tabla
                dgv_EntradaCalor.Rows.Remove(dgv_EntradaCalor.CurrentRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

            panel4.BringToFront();
            panel4.Visible = true;
            panel3.SendToBack();
            rb_aeroEC.Checked = false;
            rb_ZonaMediaEC.Checked = false;
        }

        private void rb_pectoralesD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pectoralesD.Checked == true)
            {
                String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (1)";
                Clases.Metodos m = new Clases.Metodos();
                m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);
                panel5.BringToFront();
                panel2.SendToBack();
            }
            
        }

        private void rb_aeroEC_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_aeroEC.Checked == true)
            {
                String query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7)";
                Metodos m = new Metodos();
                //llena grilla de busqueda.
                m.LlenarGrid(dgv_EjerciciosEC, query);

                panel3.BringToFront();
                panel4.SendToBack();
                panel4.Visible = false;
            }

            
        }

        private void rb_ZonaMediaEC_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ZonaMediaEC.Checked == true)
            {
                String query = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (8)";
                Metodos m = new Metodos();
                //llena grilla de busqueda.
                m.LlenarGrid(dgv_EjerciciosEC, query);

                panel3.BringToFront();
                panel4.SendToBack();
                panel4.Visible = false;
            }
        }

        private void rb_dorsalesD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_dorsalesD.Checked == true)
            {
                String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (2)";
                Clases.Metodos m = new Clases.Metodos();
                m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);

                panel5.BringToFront();
                panel2.SendToBack();
            }
        }

        private void rb_HombroD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_HombroD.Checked == true)
            {
                String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (3)";
                Clases.Metodos m = new Clases.Metodos();
                m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);

                panel5.BringToFront();
                panel2.SendToBack();
            }
        }

        private void rb_bicepsD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_bicepsD.Checked == true)
            {
                String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (4)";
                Clases.Metodos m = new Clases.Metodos();
                m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);

                panel5.BringToFront();
                panel2.SendToBack();
            }
        }

        private void rb_tricepsD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_tricepsD.Checked == true)
            {
                String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (5)";
                Clases.Metodos m = new Clases.Metodos();
                m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);

                panel5.BringToFront();
                panel2.SendToBack();
            }
        }

        private void rb_piernasD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_piernasD.Checked == true)
            {
                String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (6)";
                Clases.Metodos m = new Clases.Metodos();
                m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);

                panel5.BringToFront();
                panel2.SendToBack();
            }
        }

        private void rb_aeroD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_aeroD.Checked == true)
            {
                String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7)";
                Clases.Metodos m = new Clases.Metodos();
                m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);

                panel5.BringToFront();
                panel2.SendToBack();
            }
        }

        private void rb_zonaD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_zonaD.Checked == true)
            {
                String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (8)";
                Clases.Metodos m = new Clases.Metodos();
                m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);

                panel5.BringToFront();
                panel2.SendToBack();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_Desarrollo.SelectedRows.Count == 1)
            {
                int nroPlan = Convert.ToInt32(lbl_numPlan.Text);
                int dni = Convert.ToInt32(lbl_dniSocio.Text);
                int nroSesion = Convert.ToInt32(lbl_numPag.Text);
                int idEjercicio = Convert.ToInt32(dgv_Desarrollo.CurrentRow.Cells["IDD"].Value);
                planSeleccionado = Clases.Metodos.ObtenerDetallePlan(nroPlan, dni, nroSesion, idEjercicio);

                string query = "DELETE FROM detalleplanejercicios where detalleplanejercicios.nroPlan = '{0}' " +
                        "AND detalleplanejercicios.dniSocio = '{1}' and detalleplanejercicios.nroSesion = '{2}' " +
                        "AND detalleplanejercicios.idEjercicio = '{3}' AND detalleplanejercicios.idTipoDetalle = 2 ";
                Metodos.EliminarDetallePlan(planSeleccionado, query);

                //la borra de la tabla
                dgv_Desarrollo.Rows.Remove(dgv_Desarrollo.CurrentRow);
            }
        }


        //Agrega ejercicios a desarrollo.
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgv_ejerciciosDesarrollo.Rows)
            {

                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    dgv_Desarrollo.Rows.Add(item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString());
                }
            }
            for (int i = 0; i < dgv_ejerciciosDesarrollo.Rows.Count; i++)
            {
                dgv_ejerciciosDesarrollo.Rows[i].Cells[0].Value = false;

            }

            panel2.BringToFront();
            panel5.SendToBack();
            rb_pectoralesD.Checked = false;
            rb_dorsalesD.Checked = false;
            rb_HombroD.Checked = false;
            rb_bicepsD.Checked = false;
            rb_tricepsD.Checked = false;
            rb_piernasD.Checked = false;
            rb_aeroD.Checked = false;
            rb_zonaD.Checked = false;
        }

        private void dgv_ejerciciosDesarrollo_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dgv_ejerciciosDesarrollo.SelectedRows[0].Cells[0].Value == false)
            {
                dgv_ejerciciosDesarrollo.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dgv_ejerciciosDesarrollo.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void dgv_EjerciciosEC_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dgv_EjerciciosEC.SelectedRows[0].Cells[0].Value == false)
            {
                dgv_EjerciciosEC.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dgv_EjerciciosEC.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void dgv_Desarrollo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_Desarrollo.CurrentCell.ColumnIndex == 4 || dgv_Desarrollo.CurrentCell.ColumnIndex == 3 )
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dgv_Desarrollo_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dgv_Desarrollo_KeyPress);
                }
            }
        }

        private void dgv_Desarrollo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgv_Desarrollo.CurrentCell.ColumnIndex == 4 || dgv_Desarrollo.CurrentCell.ColumnIndex == 3)
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                { e.Handled = true; }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
            rb_aeroEC.Checked = false;
            rb_ZonaMediaEC.Checked = false;
            panel4.BringToFront();
            panel4.Visible = true;
            panel3.SendToBack();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rb_pectoralesD.Checked = false;
            rb_dorsalesD.Checked = false;
            rb_HombroD.Checked = false;
            rb_bicepsD.Checked = false;
            rb_tricepsD.Checked = false;
            rb_piernasD.Checked = false;
            rb_aeroD.Checked = false;
            rb_zonaD.Checked = false;
            panel2.BringToFront();
            panel2.Visible = true;
            panel5.SendToBack();
        }

        private void dgv_Desarrollo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }
    }
}
