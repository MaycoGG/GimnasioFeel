namespace feelGYM
{
    partial class FormAgregarEjercicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEjercicio));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_idEjercicioModificar = new System.Windows.Forms.TextBox();
            this.btn_mostrarEjercicios = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_aceptarGuardarEjercicio = new System.Windows.Forms.Button();
            this.txt_nombreEjercicioNuevo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipoEjercicioAgregar = new System.Windows.Forms.ComboBox();
            this.btn_cerrarPlan = new System.Windows.Forms.PictureBox();
            this.gb_listaEjercicios = new System.Windows.Forms.GroupBox();
            this.btn_modificarEjercicio = new System.Windows.Forms.Button();
            this.btn_borrarEjercicio = new System.Windows.Forms.Button();
            this.dgv_todosLosEjercicios = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarPlan)).BeginInit();
            this.gb_listaEjercicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todosLosEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_idEjercicioModificar);
            this.groupBox1.Controls.Add(this.btn_mostrarEjercicios);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_aceptarGuardarEjercicio);
            this.groupBox1.Controls.Add(this.txt_nombreEjercicioNuevo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_tipoEjercicioAgregar);
            this.groupBox1.Location = new System.Drawing.Point(31, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 175);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EJERCICIO NUEVO";
            // 
            // txt_idEjercicioModificar
            // 
            this.txt_idEjercicioModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEjercicioModificar.Location = new System.Drawing.Point(427, 67);
            this.txt_idEjercicioModificar.Name = "txt_idEjercicioModificar";
            this.txt_idEjercicioModificar.Size = new System.Drawing.Size(17, 27);
            this.txt_idEjercicioModificar.TabIndex = 25;
            this.txt_idEjercicioModificar.Visible = false;
            // 
            // btn_mostrarEjercicios
            // 
            this.btn_mostrarEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarEjercicios.Location = new System.Drawing.Point(309, 117);
            this.btn_mostrarEjercicios.Name = "btn_mostrarEjercicios";
            this.btn_mostrarEjercicios.Size = new System.Drawing.Size(172, 37);
            this.btn_mostrarEjercicios.TabIndex = 24;
            this.btn_mostrarEjercicios.Text = "MOSTRAR EJERCICIOS";
            this.btn_mostrarEjercicios.UseVisualStyleBackColor = true;
            this.btn_mostrarEjercicios.Click += new System.EventHandler(this.button5_Click);
            this.btn_mostrarEjercicios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_mostrarEjercicios_MouseClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(190, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_aceptarGuardarEjercicio
            // 
            this.btn_aceptarGuardarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarGuardarEjercicio.Location = new System.Drawing.Point(71, 117);
            this.btn_aceptarGuardarEjercicio.Name = "btn_aceptarGuardarEjercicio";
            this.btn_aceptarGuardarEjercicio.Size = new System.Drawing.Size(97, 37);
            this.btn_aceptarGuardarEjercicio.TabIndex = 22;
            this.btn_aceptarGuardarEjercicio.Text = "ACEPTAR";
            this.btn_aceptarGuardarEjercicio.UseVisualStyleBackColor = true;
            this.btn_aceptarGuardarEjercicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nombreEjercicioNuevo
            // 
            this.txt_nombreEjercicioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreEjercicioNuevo.Location = new System.Drawing.Point(218, 67);
            this.txt_nombreEjercicioNuevo.Name = "txt_nombreEjercicioNuevo";
            this.txt_nombreEjercicioNuevo.Size = new System.Drawing.Size(203, 27);
            this.txt_nombreEjercicioNuevo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "TIPO EJERCICIO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmb_tipoEjercicioAgregar
            // 
            this.cmb_tipoEjercicioAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoEjercicioAgregar.FormattingEnabled = true;
            this.cmb_tipoEjercicioAgregar.Location = new System.Drawing.Point(218, 30);
            this.cmb_tipoEjercicioAgregar.Name = "cmb_tipoEjercicioAgregar";
            this.cmb_tipoEjercicioAgregar.Size = new System.Drawing.Size(203, 28);
            this.cmb_tipoEjercicioAgregar.TabIndex = 18;
            // 
            // btn_cerrarPlan
            // 
            this.btn_cerrarPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarPlan.Image")));
            this.btn_cerrarPlan.Location = new System.Drawing.Point(569, 12);
            this.btn_cerrarPlan.Name = "btn_cerrarPlan";
            this.btn_cerrarPlan.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrarPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrarPlan.TabIndex = 20;
            this.btn_cerrarPlan.TabStop = false;
            this.btn_cerrarPlan.Click += new System.EventHandler(this.btn_cerrarPlan_Click);
            // 
            // gb_listaEjercicios
            // 
            this.gb_listaEjercicios.Controls.Add(this.btn_modificarEjercicio);
            this.gb_listaEjercicios.Controls.Add(this.btn_borrarEjercicio);
            this.gb_listaEjercicios.Controls.Add(this.dgv_todosLosEjercicios);
            this.gb_listaEjercicios.Controls.Add(this.txt_buscar);
            this.gb_listaEjercicios.Controls.Add(this.label2);
            this.gb_listaEjercicios.Location = new System.Drawing.Point(31, 211);
            this.gb_listaEjercicios.Name = "gb_listaEjercicios";
            this.gb_listaEjercicios.Size = new System.Drawing.Size(510, 274);
            this.gb_listaEjercicios.TabIndex = 24;
            this.gb_listaEjercicios.TabStop = false;
            this.gb_listaEjercicios.Text = "LISTA DE EJERCICIOS";
            this.gb_listaEjercicios.Visible = false;
            // 
            // btn_modificarEjercicio
            // 
            this.btn_modificarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarEjercicio.Location = new System.Drawing.Point(127, 231);
            this.btn_modificarEjercicio.Name = "btn_modificarEjercicio";
            this.btn_modificarEjercicio.Size = new System.Drawing.Size(97, 37);
            this.btn_modificarEjercicio.TabIndex = 26;
            this.btn_modificarEjercicio.Text = "MODIFICAR";
            this.btn_modificarEjercicio.UseVisualStyleBackColor = true;
            this.btn_modificarEjercicio.Click += new System.EventHandler(this.btn_modificarEjercicio_Click);
            // 
            // btn_borrarEjercicio
            // 
            this.btn_borrarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarEjercicio.Location = new System.Drawing.Point(254, 231);
            this.btn_borrarEjercicio.Name = "btn_borrarEjercicio";
            this.btn_borrarEjercicio.Size = new System.Drawing.Size(97, 37);
            this.btn_borrarEjercicio.TabIndex = 25;
            this.btn_borrarEjercicio.Text = "BORRAR";
            this.btn_borrarEjercicio.UseVisualStyleBackColor = true;
            this.btn_borrarEjercicio.Click += new System.EventHandler(this.btn_borrarEjercicio_Click);
            // 
            // dgv_todosLosEjercicios
            // 
            this.dgv_todosLosEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_todosLosEjercicios.Location = new System.Drawing.Point(20, 75);
            this.dgv_todosLosEjercicios.Name = "dgv_todosLosEjercicios";
            this.dgv_todosLosEjercicios.Size = new System.Drawing.Size(461, 150);
            this.dgv_todosLosEjercicios.TabIndex = 24;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(218, 19);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(203, 27);
            this.txt_buscar.TabIndex = 21;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "BUSCAR";
            // 
            // FormAgregarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 497);
            this.Controls.Add(this.gb_listaEjercicios);
            this.Controls.Add(this.btn_cerrarPlan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarEjercicio";
            this.Text = "FormAgregarEjercicio";
            this.Load += new System.EventHandler(this.FormAgregarEjercicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarPlan)).EndInit();
            this.gb_listaEjercicios.ResumeLayout(false);
            this.gb_listaEjercicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todosLosEjercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_aceptarGuardarEjercicio;
        private System.Windows.Forms.TextBox txt_nombreEjercicioNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipoEjercicioAgregar;
        private System.Windows.Forms.PictureBox btn_cerrarPlan;
        private System.Windows.Forms.Button btn_mostrarEjercicios;
        private System.Windows.Forms.GroupBox gb_listaEjercicios;
        private System.Windows.Forms.DataGridView dgv_todosLosEjercicios;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_modificarEjercicio;
        private System.Windows.Forms.Button btn_borrarEjercicio;
        private System.Windows.Forms.TextBox txt_idEjercicioModificar;
    }
}