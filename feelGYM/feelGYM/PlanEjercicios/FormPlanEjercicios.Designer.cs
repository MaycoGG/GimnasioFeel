namespace feelGYM
{
    partial class FormPlanEjercicios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_EjerciciosEC = new System.Windows.Forms.DataGridView();
            this.selec_EjerEC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aceptar_Ejer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_EntradaCalor = new System.Windows.Forms.DataGridView();
            this.ckb_AeroEC = new System.Windows.Forms.CheckBox();
            this.ckb_ZonaEC = new System.Windows.Forms.CheckBox();
            this.btn_buscarEC = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.btn_quitarEjerDes = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Series = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Repeticiones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ejerDesarrollo = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_aceptarEjerDesa = new System.Windows.Forms.Button();
            this.nombreeje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EjerciciosEC)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EntradaCalor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 749);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_EjerciciosEC);
            this.panel3.Controls.Add(this.aceptar_Ejer);
            this.panel3.Location = new System.Drawing.Point(88, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 0);
            this.panel3.TabIndex = 19;
            // 
            // dgv_EjerciciosEC
            // 
            this.dgv_EjerciciosEC.AllowUserToAddRows = false;
            this.dgv_EjerciciosEC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EjerciciosEC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selec_EjerEC});
            this.dgv_EjerciciosEC.Location = new System.Drawing.Point(14, 3);
            this.dgv_EjerciciosEC.Name = "dgv_EjerciciosEC";
            this.dgv_EjerciciosEC.Size = new System.Drawing.Size(662, 170);
            this.dgv_EjerciciosEC.TabIndex = 7;
            // 
            // selec_EjerEC
            // 
            this.selec_EjerEC.HeaderText = "Selección";
            this.selec_EjerEC.Name = "selec_EjerEC";
            this.selec_EjerEC.Width = 60;
            // 
            // aceptar_Ejer
            // 
            this.aceptar_Ejer.Location = new System.Drawing.Point(687, 61);
            this.aceptar_Ejer.Name = "aceptar_Ejer";
            this.aceptar_Ejer.Size = new System.Drawing.Size(65, 33);
            this.aceptar_Ejer.TabIndex = 17;
            this.aceptar_Ejer.Text = "Aceptar";
            this.aceptar_Ejer.UseVisualStyleBackColor = true;
            this.aceptar_Ejer.Click += new System.EventHandler(this.aceptar_Ejer_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(88, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 155);
            this.panel2.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_EntradaCalor);
            this.groupBox4.Controls.Add(this.ckb_AeroEC);
            this.groupBox4.Controls.Add(this.ckb_ZonaEC);
            this.groupBox4.Controls.Add(this.btn_buscarEC);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 145);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entrada en Calor";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgv_EntradaCalor
            // 
            this.dgv_EntradaCalor.AllowUserToAddRows = false;
            this.dgv_EntradaCalor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EntradaCalor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreeje,
            this.tipoEje,
            this.Id});
            this.dgv_EntradaCalor.Location = new System.Drawing.Point(266, 23);
            this.dgv_EntradaCalor.Name = "dgv_EntradaCalor";
            this.dgv_EntradaCalor.Size = new System.Drawing.Size(396, 106);
            this.dgv_EntradaCalor.TabIndex = 20;
            this.dgv_EntradaCalor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_EntradaCalor_CellContentClick);
            // 
            // ckb_AeroEC
            // 
            this.ckb_AeroEC.AutoSize = true;
            this.ckb_AeroEC.Location = new System.Drawing.Point(24, 68);
            this.ckb_AeroEC.Name = "ckb_AeroEC";
            this.ckb_AeroEC.Size = new System.Drawing.Size(90, 21);
            this.ckb_AeroEC.TabIndex = 19;
            this.ckb_AeroEC.Text = "Aeróbicos";
            this.ckb_AeroEC.UseVisualStyleBackColor = true;
            // 
            // ckb_ZonaEC
            // 
            this.ckb_ZonaEC.AutoSize = true;
            this.ckb_ZonaEC.Location = new System.Drawing.Point(24, 95);
            this.ckb_ZonaEC.Name = "ckb_ZonaEC";
            this.ckb_ZonaEC.Size = new System.Drawing.Size(102, 21);
            this.ckb_ZonaEC.TabIndex = 18;
            this.ckb_ZonaEC.Text = "Zona Media";
            this.ckb_ZonaEC.UseVisualStyleBackColor = true;
            // 
            // btn_buscarEC
            // 
            this.btn_buscarEC.Location = new System.Drawing.Point(132, 68);
            this.btn_buscarEC.Name = "btn_buscarEC";
            this.btn_buscarEC.Size = new System.Drawing.Size(95, 52);
            this.btn_buscarEC.TabIndex = 17;
            this.btn_buscarEC.Text = "BUSCAR EJERCICIOS";
            this.btn_buscarEC.UseVisualStyleBackColor = true;
            this.btn_buscarEC.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(682, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 33);
            this.button5.TabIndex = 16;
            this.button5.Text = "Quitar Ejercicio";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ejercicios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.btn_quitarEjerDes);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btn_ejerDesarrollo);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 256);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desarrollo";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(241, 50);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(90, 21);
            this.checkBox7.TabIndex = 13;
            this.checkBox7.Text = "Aeróbicos";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(337, 50);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(102, 21);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Zona Media";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // btn_quitarEjerDes
            // 
            this.btn_quitarEjerDes.Location = new System.Drawing.Point(682, 119);
            this.btn_quitarEjerDes.Name = "btn_quitarEjerDes";
            this.btn_quitarEjerDes.Size = new System.Drawing.Size(81, 32);
            this.btn_quitarEjerDes.TabIndex = 11;
            this.btn_quitarEjerDes.Text = "Quitar Ejercicio";
            this.btn_quitarEjerDes.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Series,
            this.Repeticiones,
            this.Peso});
            this.listView1.Location = new System.Drawing.Point(36, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(640, 146);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 146;
            // 
            // Series
            // 
            this.Series.Text = "Series";
            this.Series.Width = 94;
            // 
            // Repeticiones
            // 
            this.Repeticiones.Text = "Repeticiones";
            this.Repeticiones.Width = 94;
            // 
            // Peso
            // 
            this.Peso.Text = "Peso";
            this.Peso.Width = 116;
            // 
            // btn_ejerDesarrollo
            // 
            this.btn_ejerDesarrollo.Location = new System.Drawing.Point(652, 19);
            this.btn_ejerDesarrollo.Name = "btn_ejerDesarrollo";
            this.btn_ejerDesarrollo.Size = new System.Drawing.Size(95, 52);
            this.btn_ejerDesarrollo.TabIndex = 9;
            this.btn_ejerDesarrollo.Text = "BUSCAR EJERCICIOS";
            this.btn_ejerDesarrollo.UseVisualStyleBackColor = true;
            this.btn_ejerDesarrollo.Click += new System.EventHandler(this.btn_ejerDesarrollo_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(406, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 21);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Biceps";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Objetivo del Día";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(227, 19);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(83, 21);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Dorsales";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(127, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(94, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Pectorales";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(481, 20);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Triceps";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(316, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Hombros";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(561, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Piernas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(88, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 270);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.btn_aceptarEjerDesa);
            this.panel5.Location = new System.Drawing.Point(88, 473);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(807, 196);
            this.panel5.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(38, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 170);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Selección";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // btn_aceptarEjerDesa
            // 
            this.btn_aceptarEjerDesa.Location = new System.Drawing.Point(711, 61);
            this.btn_aceptarEjerDesa.Name = "btn_aceptarEjerDesa";
            this.btn_aceptarEjerDesa.Size = new System.Drawing.Size(65, 33);
            this.btn_aceptarEjerDesa.TabIndex = 17;
            this.btn_aceptarEjerDesa.Text = "Aceptar";
            this.btn_aceptarEjerDesa.UseVisualStyleBackColor = true;
            // 
            // nombreeje
            // 
            this.nombreeje.HeaderText = "Nombre";
            this.nombreeje.Name = "nombreeje";
            this.nombreeje.Width = 200;
            // 
            // tipoEje
            // 
            this.tipoEje.HeaderText = "Tipo Ejercicio";
            this.tipoEje.Name = "tipoEje";
            this.tipoEje.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FormPlanEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.panel1);
            this.Name = "FormPlanEjercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlan_Ejercicios";
            this.Load += new System.EventHandler(this.FormPlanEjercicios_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EjerciciosEC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EntradaCalor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button btn_quitarEjerDes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Series;
        private System.Windows.Forms.ColumnHeader Repeticiones;
        private System.Windows.Forms.ColumnHeader Peso;
        private System.Windows.Forms.Button btn_ejerDesarrollo;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscarEC;
        public System.Windows.Forms.CheckBox ckb_AeroEC;
        public System.Windows.Forms.CheckBox ckb_ZonaEC;
        public System.Windows.Forms.DataGridView dgv_EntradaCalor;
        private System.Windows.Forms.DataGridView dgv_EjerciciosEC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selec_EjerEC;
        private System.Windows.Forms.Button aceptar_Ejer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btn_aceptarEjerDesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreeje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}