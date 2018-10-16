using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace feelGYM
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

#region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            btn_maximizar.Visible = true;
            btn_restaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrirFormulario<FormProfesores>();
            abrirFormulario<FormProfesor_AGREGAR>();
            button1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormulario<FormPlanDatos>();
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormulario<FormAgregarEjercicio>();
            Ejercicios.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void timerOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 60)
            {
                this.timerOcultarMenu.Enabled = false;
            }
            else {
                this.panelMenu.Width = panelMenu.Width - 20;
            }
        }

        private void timerMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 200)
            {
                this.timerMostrarMenu.Enabled = false;
            }
            else
            {
                this.panelMenu.Width = panelMenu.Width + 20;
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 200)
            {
                timerOcultarMenu.Enabled = true;
            }
            else{
                if (panelMenu.Width == 60) { timerMostrarMenu.Enabled = true; }
            }
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lbl_horaActual.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void lbl_horaActual_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Clases.Conexion.obtenerConexion();
            //try
            //{
            //    MessageBox.Show("Ok estas conectado");
            //}
            //catch (Exception e1)
            //{
            //    MessageBox.Show(e1.Message);
            //}

            FormVistaPrevia fvp = new FormVistaPrevia();
            fvp.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        //Método para abrir formulario dentro del panel
        public void abrirFormulario<MiForm>() where MiForm : Form, new() {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault(); //busca en la coleccion el formulario

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None; //quita el borde del formulario
                formulario.Dock = DockStyle.Fill; //Dock = fill --> lo acopla al panel contenedor
                panelContenedor.Controls.Add(formulario);//agrega el formulario a la coleccion del PANELCONTENEDOR
                panelContenedor.Tag = formulario;
                formulario.Show();
                
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        //mantiene el color original del boton cuando se cierra el formulario hijo
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormProfesores"] == null)
                button1.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormPlanDeEjercicios"] == null)
                button2.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form3"] == null)
                Ejercicios.BackColor = Color.FromArgb(4, 41, 68);
        }

    }
}
