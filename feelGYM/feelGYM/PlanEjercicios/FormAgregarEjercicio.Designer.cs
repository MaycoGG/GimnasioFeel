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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombreEjercicioNuevo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mostrarEj = new System.Windows.Forms.Button();
            this.btn_cancelarEjer = new System.Windows.Forms.Button();
            this.btn_registrarEjercicio = new System.Windows.Forms.Button();
            this.txt_idEjercicioModificar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipoEjercicioAgregar = new System.Windows.Forms.ComboBox();
            this.btn_cerrarPlan = new System.Windows.Forms.PictureBox();
            this.gb_listaEjercicios = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_todosLosEjercicios = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarPlan)).BeginInit();
            this.gb_listaEjercicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todosLosEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombreEjercicioNuevo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mostrarEj);
            this.groupBox1.Controls.Add(this.btn_cancelarEjer);
            this.groupBox1.Controls.Add(this.btn_registrarEjercicio);
            this.groupBox1.Controls.Add(this.txt_idEjercicioModificar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_tipoEjercicioAgregar);
            this.groupBox1.Location = new System.Drawing.Point(214, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(662, 229);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EJERCICIO NUEVO";
            // 
            // txt_nombreEjercicioNuevo
            // 
            this.txt_nombreEjercicioNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_nombreEjercicioNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombreEjercicioNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreEjercicioNuevo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombreEjercicioNuevo.Location = new System.Drawing.Point(110, 91);
            this.txt_nombreEjercicioNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreEjercicioNuevo.Name = "txt_nombreEjercicioNuevo";
            this.txt_nombreEjercicioNuevo.Size = new System.Drawing.Size(412, 19);
            this.txt_nombreEjercicioNuevo.TabIndex = 56;
            this.txt_nombreEjercicioNuevo.Text = "NOMBRE";
            this.txt_nombreEjercicioNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombreEjercicioNuevo.Enter += new System.EventHandler(this.txt_nombreEjercicioNuevo_Enter);
            this.txt_nombreEjercicioNuevo.Leave += new System.EventHandler(this.txt_nombreEjercicioNuevo_Leave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "___________________________________________________________";
            // 
            // txt_mostrarEj
            // 
            this.txt_mostrarEj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.txt_mostrarEj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_mostrarEj.FlatAppearance.BorderSize = 0;
            this.txt_mostrarEj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mostrarEj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_mostrarEj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mostrarEj.ForeColor = System.Drawing.Color.LightGray;
            this.txt_mostrarEj.Location = new System.Drawing.Point(404, 151);
            this.txt_mostrarEj.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mostrarEj.Name = "txt_mostrarEj";
            this.txt_mostrarEj.Size = new System.Drawing.Size(195, 52);
            this.txt_mostrarEj.TabIndex = 55;
            this.txt_mostrarEj.Text = "MOSTRAR EJERCICIOS";
            this.txt_mostrarEj.UseVisualStyleBackColor = false;
            this.txt_mostrarEj.Click += new System.EventHandler(this.txt_mostrarEj_Click);
            // 
            // btn_cancelarEjer
            // 
            this.btn_cancelarEjer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_cancelarEjer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarEjer.FlatAppearance.BorderSize = 0;
            this.btn_cancelarEjer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelarEjer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarEjer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarEjer.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cancelarEjer.Location = new System.Drawing.Point(242, 151);
            this.btn_cancelarEjer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelarEjer.Name = "btn_cancelarEjer";
            this.btn_cancelarEjer.Size = new System.Drawing.Size(154, 52);
            this.btn_cancelarEjer.TabIndex = 54;
            this.btn_cancelarEjer.Text = "CANCELAR";
            this.btn_cancelarEjer.UseVisualStyleBackColor = false;
            this.btn_cancelarEjer.Click += new System.EventHandler(this.btn_cancelarEjer_Click);
            // 
            // btn_registrarEjercicio
            // 
            this.btn_registrarEjercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_registrarEjercicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrarEjercicio.FlatAppearance.BorderSize = 0;
            this.btn_registrarEjercicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_registrarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarEjercicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarEjercicio.ForeColor = System.Drawing.Color.LightGray;
            this.btn_registrarEjercicio.Location = new System.Drawing.Point(80, 150);
            this.btn_registrarEjercicio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_registrarEjercicio.Name = "btn_registrarEjercicio";
            this.btn_registrarEjercicio.Size = new System.Drawing.Size(154, 52);
            this.btn_registrarEjercicio.TabIndex = 53;
            this.btn_registrarEjercicio.Text = "REGISTRAR";
            this.btn_registrarEjercicio.UseVisualStyleBackColor = false;
            this.btn_registrarEjercicio.Click += new System.EventHandler(this.btn_registrarEjercicio_Click);
            // 
            // txt_idEjercicioModificar
            // 
            this.txt_idEjercicioModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEjercicioModificar.Location = new System.Drawing.Point(569, 88);
            this.txt_idEjercicioModificar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idEjercicioModificar.Name = "txt_idEjercicioModificar";
            this.txt_idEjercicioModificar.Size = new System.Drawing.Size(21, 27);
            this.txt_idEjercicioModificar.TabIndex = 25;
            this.txt_idEjercicioModificar.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(107, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "TIPO EJERCICIO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmb_tipoEjercicioAgregar
            // 
            this.cmb_tipoEjercicioAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoEjercicioAgregar.FormattingEnabled = true;
            this.cmb_tipoEjercicioAgregar.Location = new System.Drawing.Point(253, 41);
            this.cmb_tipoEjercicioAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipoEjercicioAgregar.Name = "cmb_tipoEjercicioAgregar";
            this.cmb_tipoEjercicioAgregar.Size = new System.Drawing.Size(269, 28);
            this.cmb_tipoEjercicioAgregar.TabIndex = 18;
            // 
            // btn_cerrarPlan
            // 
            this.btn_cerrarPlan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cerrarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarPlan.Image")));
            this.btn_cerrarPlan.Location = new System.Drawing.Point(952, 16);
            this.btn_cerrarPlan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrarPlan.Name = "btn_cerrarPlan";
            this.btn_cerrarPlan.Size = new System.Drawing.Size(33, 33);
            this.btn_cerrarPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrarPlan.TabIndex = 20;
            this.btn_cerrarPlan.TabStop = false;
            this.btn_cerrarPlan.Click += new System.EventHandler(this.btn_cerrarPlan_Click);
            // 
            // gb_listaEjercicios
            // 
            this.gb_listaEjercicios.Controls.Add(this.button1);
            this.gb_listaEjercicios.Controls.Add(this.button2);
            this.gb_listaEjercicios.Controls.Add(this.txt_buscar);
            this.gb_listaEjercicios.Controls.Add(this.label4);
            this.gb_listaEjercicios.Controls.Add(this.dgv_todosLosEjercicios);
            this.gb_listaEjercicios.Location = new System.Drawing.Point(214, 278);
            this.gb_listaEjercicios.Margin = new System.Windows.Forms.Padding(4);
            this.gb_listaEjercicios.Name = "gb_listaEjercicios";
            this.gb_listaEjercicios.Padding = new System.Windows.Forms.Padding(4);
            this.gb_listaEjercicios.Size = new System.Drawing.Size(680, 358);
            this.gb_listaEjercicios.TabIndex = 24;
            this.gb_listaEjercicios.TabStop = false;
            this.gb_listaEjercicios.Text = "LISTA DE EJERCICIOS";
            this.gb_listaEjercicios.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(489, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 52);
            this.button1.TabIndex = 61;
            this.button1.Text = "BORRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(489, 136);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 52);
            this.button2.TabIndex = 60;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.DimGray;
            this.txt_buscar.Location = new System.Drawing.Point(129, 35);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(412, 19);
            this.txt_buscar.TabIndex = 58;
            this.txt_buscar.Text = "BUSCAR EJERCICIO";
            this.txt_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged_1);
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "___________________________________________________________";
            // 
            // dgv_todosLosEjercicios
            // 
            this.dgv_todosLosEjercicios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_todosLosEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_todosLosEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_todosLosEjercicios.EnableHeadersVisualStyles = false;
            this.dgv_todosLosEjercicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgv_todosLosEjercicios.Location = new System.Drawing.Point(27, 98);
            this.dgv_todosLosEjercicios.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_todosLosEjercicios.Name = "dgv_todosLosEjercicios";
            this.dgv_todosLosEjercicios.ReadOnly = true;
            this.dgv_todosLosEjercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_todosLosEjercicios.Size = new System.Drawing.Size(434, 196);
            this.dgv_todosLosEjercicios.TabIndex = 24;
            // 
            // FormAgregarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1001, 650);
            this.Controls.Add(this.gb_listaEjercicios);
            this.Controls.Add(this.btn_cerrarPlan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAgregarEjercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAgregarEjercicio";
            this.Load += new System.EventHandler(this.FormAgregarEjercicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarPlan)).EndInit();
            this.gb_listaEjercicios.ResumeLayout(false);
            this.gb_listaEjercicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todosLosEjercicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipoEjercicioAgregar;
        private System.Windows.Forms.PictureBox btn_cerrarPlan;
        private System.Windows.Forms.GroupBox gb_listaEjercicios;
        private System.Windows.Forms.DataGridView dgv_todosLosEjercicios;
        private System.Windows.Forms.TextBox txt_idEjercicioModificar;
        private System.Windows.Forms.Button btn_cancelarEjer;
        private System.Windows.Forms.Button btn_registrarEjercicio;
        private System.Windows.Forms.Button txt_mostrarEj;
        private System.Windows.Forms.TextBox txt_nombreEjercicioNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}