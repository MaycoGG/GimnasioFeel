namespace feelGYM
{
    partial class FormProfesor_AGREGAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfesor_AGREGAR));
            this.btn_registrarProfe = new System.Windows.Forms.Button();
            this.txt_apellidoProfe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombreProfe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_celProfe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_docProfe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cerEmergenciaProfe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_sangreProfe = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cerrarPlan = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_profesores = new System.Windows.Forms.GroupBox();
            this.btn_mostrarProfe = new System.Windows.Forms.Button();
            this.btn_modificarEjercicio = new System.Windows.Forms.Button();
            this.btn_borrarEjercicio = new System.Windows.Forms.Button();
            this.dgv_todosLosProfes = new System.Windows.Forms.DataGridView();
            this.txt_buscarPorNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarPlan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_profesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todosLosProfes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_registrarProfe
            // 
            this.btn_registrarProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_registrarProfe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrarProfe.FlatAppearance.BorderSize = 0;
            this.btn_registrarProfe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_registrarProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarProfe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarProfe.ForeColor = System.Drawing.Color.LightGray;
            this.btn_registrarProfe.Location = new System.Drawing.Point(41, 182);
            this.btn_registrarProfe.Name = "btn_registrarProfe";
            this.btn_registrarProfe.Size = new System.Drawing.Size(136, 40);
            this.btn_registrarProfe.TabIndex = 1;
            this.btn_registrarProfe.Text = "REGISTRAR";
            this.btn_registrarProfe.UseVisualStyleBackColor = false;
            this.btn_registrarProfe.Click += new System.EventHandler(this.txt_registrarProfe_Click);
            // 
            // txt_apellidoProfe
            // 
            this.txt_apellidoProfe.BackColor = System.Drawing.SystemColors.Control;
            this.txt_apellidoProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellidoProfe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoProfe.ForeColor = System.Drawing.Color.DimGray;
            this.txt_apellidoProfe.Location = new System.Drawing.Point(39, 44);
            this.txt_apellidoProfe.Name = "txt_apellidoProfe";
            this.txt_apellidoProfe.Size = new System.Drawing.Size(300, 19);
            this.txt_apellidoProfe.TabIndex = 34;
            this.txt_apellidoProfe.Text = "APELLIDO";
            this.txt_apellidoProfe.Enter += new System.EventHandler(this.txt_apellidoProfe_Enter);
            this.txt_apellidoProfe.Leave += new System.EventHandler(this.txt_apellidoProfe_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "_________________________________________________";
            // 
            // txt_nombreProfe
            // 
            this.txt_nombreProfe.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nombreProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombreProfe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreProfe.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombreProfe.Location = new System.Drawing.Point(39, 19);
            this.txt_nombreProfe.Name = "txt_nombreProfe";
            this.txt_nombreProfe.Size = new System.Drawing.Size(300, 19);
            this.txt_nombreProfe.TabIndex = 33;
            this.txt_nombreProfe.Text = "NOMBRE";
            this.txt_nombreProfe.Enter += new System.EventHandler(this.txt_nombreProfe_Enter);
            this.txt_nombreProfe.Leave += new System.EventHandler(this.txt_nombreProfe_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "_________________________________________________";
            // 
            // txt_celProfe
            // 
            this.txt_celProfe.BackColor = System.Drawing.SystemColors.Control;
            this.txt_celProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_celProfe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celProfe.ForeColor = System.Drawing.Color.DimGray;
            this.txt_celProfe.Location = new System.Drawing.Point(41, 94);
            this.txt_celProfe.Name = "txt_celProfe";
            this.txt_celProfe.Size = new System.Drawing.Size(300, 19);
            this.txt_celProfe.TabIndex = 39;
            this.txt_celProfe.Text = "CELULAR";
            this.txt_celProfe.Enter += new System.EventHandler(this.txt_celProfe_Enter);
            this.txt_celProfe.Leave += new System.EventHandler(this.txt_celProfe_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "_________________________________________________";
            // 
            // txt_docProfe
            // 
            this.txt_docProfe.BackColor = System.Drawing.SystemColors.Control;
            this.txt_docProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_docProfe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docProfe.ForeColor = System.Drawing.Color.DimGray;
            this.txt_docProfe.Location = new System.Drawing.Point(41, 69);
            this.txt_docProfe.Name = "txt_docProfe";
            this.txt_docProfe.Size = new System.Drawing.Size(300, 19);
            this.txt_docProfe.TabIndex = 38;
            this.txt_docProfe.Text = "NRO DOCUMENTO";
            this.txt_docProfe.Enter += new System.EventHandler(this.txt_docProfe_Enter);
            this.txt_docProfe.Leave += new System.EventHandler(this.txt_docProfe_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "_________________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "_________________________________________________";
            // 
            // txt_cerEmergenciaProfe
            // 
            this.txt_cerEmergenciaProfe.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cerEmergenciaProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cerEmergenciaProfe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cerEmergenciaProfe.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cerEmergenciaProfe.Location = new System.Drawing.Point(41, 119);
            this.txt_cerEmergenciaProfe.Name = "txt_cerEmergenciaProfe";
            this.txt_cerEmergenciaProfe.Size = new System.Drawing.Size(300, 19);
            this.txt_cerEmergenciaProfe.TabIndex = 42;
            this.txt_cerEmergenciaProfe.Text = "CEL EMERGENCIA";
            this.txt_cerEmergenciaProfe.Enter += new System.EventHandler(this.txt_cerEmergenciaProfe_Enter);
            this.txt_cerEmergenciaProfe.Leave += new System.EventHandler(this.txt_cerEmergenciaProfe_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(301, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "_________________________________________________";
            // 
            // cmb_sangreProfe
            // 
            this.cmb_sangreProfe.FormattingEnabled = true;
            this.cmb_sangreProfe.Location = new System.Drawing.Point(166, 144);
            this.cmb_sangreProfe.Name = "cmb_sangreProfe";
            this.cmb_sangreProfe.Size = new System.Drawing.Size(171, 21);
            this.cmb_sangreProfe.TabIndex = 49;
            this.cmb_sangreProfe.SelectedIndexChanged += new System.EventHandler(this.cmb_sangreProfe_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(41, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 19);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "TIPO DE SANGRE";
            // 
            // btn_cerrarPlan
            // 
            this.btn_cerrarPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarPlan.Image")));
            this.btn_cerrarPlan.Location = new System.Drawing.Point(859, 12);
            this.btn_cerrarPlan.Name = "btn_cerrarPlan";
            this.btn_cerrarPlan.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrarPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrarPlan.TabIndex = 51;
            this.btn_cerrarPlan.TabStop = false;
            this.btn_cerrarPlan.Click += new System.EventHandler(this.btn_cerrarPlan_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cancelar.Location = new System.Drawing.Point(191, 182);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(146, 40);
            this.btn_cancelar.TabIndex = 52;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_celProfe);
            this.groupBox1.Controls.Add(this.txt_docProfe);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_apellidoProfe);
            this.groupBox1.Controls.Add(this.txt_nombreProfe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_registrarProfe);
            this.groupBox1.Controls.Add(this.cmb_sangreProfe);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_cerEmergenciaProfe);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 246);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gb_profesores
            // 
            this.gb_profesores.Controls.Add(this.txt_buscarPorNombre);
            this.gb_profesores.Controls.Add(this.label1);
            this.gb_profesores.Controls.Add(this.btn_modificarEjercicio);
            this.gb_profesores.Controls.Add(this.btn_borrarEjercicio);
            this.gb_profesores.Controls.Add(this.dgv_todosLosProfes);
            this.gb_profesores.Location = new System.Drawing.Point(12, 280);
            this.gb_profesores.Name = "gb_profesores";
            this.gb_profesores.Size = new System.Drawing.Size(851, 284);
            this.gb_profesores.TabIndex = 54;
            this.gb_profesores.TabStop = false;
            this.gb_profesores.Text = "groupBox2";
            this.gb_profesores.Visible = false;
            // 
            // btn_mostrarProfe
            // 
            this.btn_mostrarProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_mostrarProfe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrarProfe.FlatAppearance.BorderSize = 0;
            this.btn_mostrarProfe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_mostrarProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrarProfe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarProfe.ForeColor = System.Drawing.Color.LightGray;
            this.btn_mostrarProfe.Location = new System.Drawing.Point(433, 13);
            this.btn_mostrarProfe.Name = "btn_mostrarProfe";
            this.btn_mostrarProfe.Size = new System.Drawing.Size(114, 65);
            this.btn_mostrarProfe.TabIndex = 53;
            this.btn_mostrarProfe.Text = "MOSTRAR PROFESORES";
            this.btn_mostrarProfe.UseVisualStyleBackColor = false;
            this.btn_mostrarProfe.Click += new System.EventHandler(this.btn_mostrarProfe_Click);
            // 
            // btn_modificarEjercicio
            // 
            this.btn_modificarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarEjercicio.Location = new System.Drawing.Point(156, 227);
            this.btn_modificarEjercicio.Name = "btn_modificarEjercicio";
            this.btn_modificarEjercicio.Size = new System.Drawing.Size(97, 37);
            this.btn_modificarEjercicio.TabIndex = 31;
            this.btn_modificarEjercicio.Text = "MODIFICAR";
            this.btn_modificarEjercicio.UseVisualStyleBackColor = true;
            this.btn_modificarEjercicio.Click += new System.EventHandler(this.btn_modificarEjercicio_Click);
            // 
            // btn_borrarEjercicio
            // 
            this.btn_borrarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarEjercicio.Location = new System.Drawing.Point(283, 227);
            this.btn_borrarEjercicio.Name = "btn_borrarEjercicio";
            this.btn_borrarEjercicio.Size = new System.Drawing.Size(97, 37);
            this.btn_borrarEjercicio.TabIndex = 30;
            this.btn_borrarEjercicio.Text = "BORRAR";
            this.btn_borrarEjercicio.UseVisualStyleBackColor = true;
            this.btn_borrarEjercicio.Click += new System.EventHandler(this.btn_borrarEjercicio_Click);
            // 
            // dgv_todosLosProfes
            // 
            this.dgv_todosLosProfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_todosLosProfes.Location = new System.Drawing.Point(49, 71);
            this.dgv_todosLosProfes.Name = "dgv_todosLosProfes";
            this.dgv_todosLosProfes.Size = new System.Drawing.Size(623, 150);
            this.dgv_todosLosProfes.TabIndex = 29;
            // 
            // txt_buscarPorNombre
            // 
            this.txt_buscarPorNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_buscarPorNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscarPorNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarPorNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_buscarPorNombre.Location = new System.Drawing.Point(102, 38);
            this.txt_buscarPorNombre.Name = "txt_buscarPorNombre";
            this.txt_buscarPorNombre.Size = new System.Drawing.Size(300, 19);
            this.txt_buscarPorNombre.TabIndex = 37;
            this.txt_buscarPorNombre.Text = "BUSCAR POR NOMBRE/APELLIDO";
            this.txt_buscarPorNombre.TextChanged += new System.EventHandler(this.txt_buscarPorNombre_TextChanged);
            this.txt_buscarPorNombre.Enter += new System.EventHandler(this.txt_buscarPorNombre_Enter);
            this.txt_buscarPorNombre.Leave += new System.EventHandler(this.txt_buscarPorNombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "_________________________________________________";
            // 
            // FormProfesor_AGREGAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 562);
            this.Controls.Add(this.btn_mostrarProfe);
            this.Controls.Add(this.gb_profesores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cerrarPlan);
            this.Name = "FormProfesor_AGREGAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR PROFESOR";
            this.Load += new System.EventHandler(this.FormProfesor_AGREGAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarPlan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_profesores.ResumeLayout(false);
            this.gb_profesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todosLosProfes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_registrarProfe;
        private System.Windows.Forms.TextBox txt_apellidoProfe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombreProfe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_celProfe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_docProfe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cerEmergenciaProfe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_sangreProfe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btn_cerrarPlan;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_mostrarProfe;
        private System.Windows.Forms.GroupBox gb_profesores;
        private System.Windows.Forms.TextBox txt_buscarPorNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modificarEjercicio;
        private System.Windows.Forms.Button btn_borrarEjercicio;
        private System.Windows.Forms.DataGridView dgv_todosLosProfes;
    }
}