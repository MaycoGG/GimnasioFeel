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

        //crea un objeto de tipo Ejercicio.
        public DetallePlan planSeleccionado { get; set; }


        //metodo que borra de la BD un ejercicio de la ENTRADA EN CALOR y actualiza la grilla.
        private void button5_Click(object sender, EventArgs e)
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

        private void btn_ejerDesarrollo_Click(object sender, EventArgs e)
        {
            Metodos m = new Metodos();
            String consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id ";

            if (rb_pectoralesD.Checked)
            {
                consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (1)";

            }
            if (rb_dorsalesD.Checked)
            {
                consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (2)";
            }
            if (rb_HombroD.Checked)
            {
                consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (3)";
            }
            if (rb_bicepsD.Checked)
            {
                consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (4)";
            }
            if (rb_tricepsD.Checked)
            {
                consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (5)";
            }
            if (rb_piernasD.Checked)
            {
                consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (6)";
            }
            if (rb_aeroD.Checked)
            {
                consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (7)";
            }
            if (rb_zonaD.Checked)
            {
                consulta = "SELECT ejercicios.nombre as 'Nombre', tipoejercicio.nombre as 'Tipo Ejercicio', ejercicios.id FROM ejercicios JOIN tipoejercicio ON ejercicios.tipoEjercicio = tipoejercicio.id WHERE ejercicios.tipoEjercicio in (8)";

            }
            m.LlenarGrid(dgv_ejerciciosDesarrollo, consulta);

            panel5.Height = 201;
            panel5.Location = new Point(88, 473);
            panel6.Location = new Point(88, 690);
            Height = 749;
            panel1.Height = 749;
        }

        private void btn_aceptarEjerDesa_Click(object sender, EventArgs e)
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

            panel5.Location = new Point(88, 473);
            panel5.Height = 0;
            panel6.Location = new Point(88, 476);
            Height = 554;
            panel1.Height = 554;
            
            
        }

        private void btn_quitarEjerDes_Click(object sender, EventArgs e)
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

        private void btn_buscarEjerEC_Click(object sender, EventArgs e)
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
            //llena grilla de busqueda.
            m.LlenarGrid(dgv_EjerciciosEC, query);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btn_aceptarPag_Click(object sender, EventArgs e)
        {
            

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
                detalle.obsEC = item.Cells["ObservacionEC"].Value.ToString();

                int contador = Clases.Metodos.compararDetalle(detalle.nroPlan, detalle.dniSocio, detalle.nroSesion, detalle.idEjercicio);

                if (contador != 0)
                {
                    MessageBox.Show("Ejercicio " + detalle.idEjercicio + " se repite");

                    dgv_EntradaCalor.Rows.Remove(item);
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
                    "detalleplanejercicios.intensidad, detalleplanejercicios.series, detalleplanejercicios.repeticiones, detalleplanejercicios.observacionesD) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')";
                detalle.nroPlan  = Convert.ToInt32(lbl_numPlan.Text);
                detalle.dniSocio = Convert.ToInt32(lbl_dniSocio.Text);
                detalle.nroSesion = Convert.ToInt32(lbl_numPag.Text);
                detalle.tipoDetalle = 2;
                detalle.idEjercicio = Convert.ToInt32(item.Cells["IDD"].Value);
                detalle.intensidad = item.Cells["intensidad"].Value.ToString();
                detalle.series = Convert.ToInt32(item.Cells["series"].Value);
                detalle.repe = item.Cells["repeticiones"].Value.ToString();
                detalle.obsD = item.Cells["observacionD"].Value.ToString();
                

                int contador = Clases.Metodos.compararDetalle(detalle.nroPlan, detalle.dniSocio, detalle.nroSesion, detalle.idEjercicio);

                if (contador != 0)
                {
                    MessageBox.Show("Ejercicio " + detalle.idEjercicio + " se repite");

                    dgv_Desarrollo.Rows.Remove(item);
                }
                else
                {
                    int retorno = Clases.Metodos.AgregarDatosDetallePlanDesarrollo(detalle, query);
                }


            }
            
        }
    }
}
