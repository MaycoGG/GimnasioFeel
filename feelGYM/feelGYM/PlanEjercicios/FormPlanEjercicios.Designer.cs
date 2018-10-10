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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Series = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Repeticiones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckb_AeroEC = new System.Windows.Forms.CheckBox();
            this.ckb_ZonaEC = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_EntradaCalor = new System.Windows.Forms.DataGridView();
            this.NombreEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEjeEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarEC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EntradaCalor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 530);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(79, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 354);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Quitar Ejercicio";
            this.button2.UseVisualStyleBackColor = true;
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
            this.listView1.Size = new System.Drawing.Size(640, 220);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "BUSCAR EJERCICIOS";
            this.button1.UseVisualStyleBackColor = true;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_EntradaCalor);
            this.groupBox4.Controls.Add(this.ckb_AeroEC);
            this.groupBox4.Controls.Add(this.ckb_ZonaEC);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(79, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 145);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entrada en Calor";
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 52);
            this.button3.TabIndex = 17;
            this.button3.Text = "BUSCAR EJERCICIOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(682, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 33);
            this.button5.TabIndex = 16;
            this.button5.Text = "Quitar Ejercicio";
            this.button5.UseVisualStyleBackColor = true;
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
            // dgv_EntradaCalor
            // 
            this.dgv_EntradaCalor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EntradaCalor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEC,
            this.tipoEjeEC,
            this.id_EC,
            this.eliminarEC});
            this.dgv_EntradaCalor.Location = new System.Drawing.Point(266, 23);
            this.dgv_EntradaCalor.Name = "dgv_EntradaCalor";
            this.dgv_EntradaCalor.Size = new System.Drawing.Size(396, 106);
            this.dgv_EntradaCalor.TabIndex = 20;
            // 
            // NombreEC
            // 
            this.NombreEC.HeaderText = "Nombre";
            this.NombreEC.Name = "NombreEC";
            // 
            // tipoEjeEC
            // 
            this.tipoEjeEC.HeaderText = "Tipo Ejercicio";
            this.tipoEjeEC.Name = "tipoEjeEC";
            // 
            // id_EC
            // 
            this.id_EC.HeaderText = "Id";
            this.id_EC.Name = "id_EC";
            this.id_EC.Visible = false;
            // 
            // eliminarEC
            // 
            this.eliminarEC.HeaderText = "Eliminar";
            this.eliminarEC.Name = "eliminarEC";
            this.eliminarEC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminarEC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminarEC.Width = 60;
            // 
            // FormPlanEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 530);
            this.Controls.Add(this.panel1);
            this.Name = "FormPlanEjercicios";
            this.Text = "FormPlan_Ejercicios";
            this.Load += new System.EventHandler(this.FormPlanEjercicios_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EntradaCalor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Series;
        private System.Windows.Forms.ColumnHeader Repeticiones;
        private System.Windows.Forms.ColumnHeader Peso;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.CheckBox ckb_AeroEC;
        public System.Windows.Forms.CheckBox ckb_ZonaEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEjeEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_EC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eliminarEC;
        public System.Windows.Forms.DataGridView dgv_EntradaCalor;
    }
}