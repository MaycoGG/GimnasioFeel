﻿using System;
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
    public partial class FormPlanDatos : Form
    {
        public FormPlanDatos()
        {
            InitializeComponent();
        }

        private void btn_cerrarPlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //txt_fechaActualPlan.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_fechaActualPlan.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txt_NombreClientePlan_Enter(object sender, EventArgs e)
        {
            if (txt_NombreClientePlan.Text == "NOMBRE")
            {
                txt_NombreClientePlan.Text = "";
                txt_NombreClientePlan.ForeColor = Color.LightGray;
            }
        }

        private void txt_NombreClientePlan_Leave(object sender, EventArgs e)
        {
            if (txt_NombreClientePlan.Text == "")
            {
                txt_NombreClientePlan.Text = "NOMBRE";
                txt_NombreClientePlan.ForeColor = Color.DimGray;
            }
        }

        private void txt_apellidoClientePlan_Enter(object sender, EventArgs e)
        {
            if (txt_apellidoClientePlan.Text == "APELLIDO")
            {
                txt_apellidoClientePlan.Text = "";
                txt_apellidoClientePlan.ForeColor = Color.LightGray;
            }
        }

        private void txt_apellidoClientePlan_Leave(object sender, EventArgs e)
        {
            if (txt_apellidoClientePlan.Text == "")
            {
                txt_apellidoClientePlan.Text = "APELLIDO";
                txt_apellidoClientePlan.ForeColor = Color.DimGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPlan_Ejercicios form = new FormPlan_Ejercicios();
            form.Show();
        }

        private void btn_agregarProfeEnPlan_Click(object sender, EventArgs e)
        {
            FormProfesor_AGREGAR form = new FormProfesor_AGREGAR();
            form.Show();
        }

        private void FormPlanDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
