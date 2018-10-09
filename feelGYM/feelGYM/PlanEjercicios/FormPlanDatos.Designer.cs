namespace feelGYM
{
    partial class FormPlanDatos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanDatos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_apellidoClientePlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreClientePlan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_sesionesPlan = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_agregarProfeEnPlan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_fechaActualPlan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_profesor = new System.Windows.Forms.ComboBox();
            this.btn_cerrarPlan = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sesionesPlan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_apellidoClientePlan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_NombreClientePlan);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmb_sesionesPlan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(53, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 384);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 183);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 45);
            this.textBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "OBJETIVOS";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(17, 274);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(300, 80);
            this.textBox5.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "OBSERVACIONES";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_apellidoClientePlan
            // 
            this.txt_apellidoClientePlan.BackColor = System.Drawing.SystemColors.Control;
            this.txt_apellidoClientePlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellidoClientePlan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoClientePlan.ForeColor = System.Drawing.Color.DimGray;
            this.txt_apellidoClientePlan.Location = new System.Drawing.Point(19, 69);
            this.txt_apellidoClientePlan.Name = "txt_apellidoClientePlan";
            this.txt_apellidoClientePlan.Size = new System.Drawing.Size(300, 19);
            this.txt_apellidoClientePlan.TabIndex = 23;
            this.txt_apellidoClientePlan.Text = "APELLIDO";
            this.txt_apellidoClientePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_apellidoClientePlan.Enter += new System.EventHandler(this.txt_apellidoClientePlan_Enter);
            this.txt_apellidoClientePlan.Leave += new System.EventHandler(this.txt_apellidoClientePlan_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "_________________________________________________";
            // 
            // txt_NombreClientePlan
            // 
            this.txt_NombreClientePlan.BackColor = System.Drawing.SystemColors.Control;
            this.txt_NombreClientePlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NombreClientePlan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreClientePlan.ForeColor = System.Drawing.Color.DimGray;
            this.txt_NombreClientePlan.Location = new System.Drawing.Point(19, 33);
            this.txt_NombreClientePlan.Name = "txt_NombreClientePlan";
            this.txt_NombreClientePlan.Size = new System.Drawing.Size(300, 19);
            this.txt_NombreClientePlan.TabIndex = 22;
            this.txt_NombreClientePlan.Text = "NOMBRE";
            this.txt_NombreClientePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NombreClientePlan.Enter += new System.EventHandler(this.txt_NombreClientePlan_Enter);
            this.txt_NombreClientePlan.Leave += new System.EventHandler(this.txt_NombreClientePlan_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(350, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "_________________________________________________";
            // 
            // cmb_sesionesPlan
            // 
            this.cmb_sesionesPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sesionesPlan.Location = new System.Drawing.Point(152, 116);
            this.cmb_sesionesPlan.Name = "cmb_sesionesPlan";
            this.cmb_sesionesPlan.Size = new System.Drawing.Size(49, 23);
            this.cmb_sesionesPlan.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "NRO SESIONES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_agregarProfeEnPlan);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_fechaActualPlan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_profesor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 384);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Plan Actual";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_agregarProfeEnPlan
            // 
            this.btn_agregarProfeEnPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProfeEnPlan.Location = new System.Drawing.Point(266, 39);
            this.btn_agregarProfeEnPlan.Name = "btn_agregarProfeEnPlan";
            this.btn_agregarProfeEnPlan.Size = new System.Drawing.Size(37, 23);
            this.btn_agregarProfeEnPlan.TabIndex = 18;
            this.btn_agregarProfeEnPlan.Text = "+";
            this.btn_agregarProfeEnPlan.UseVisualStyleBackColor = true;
            this.btn_agregarProfeEnPlan.Click += new System.EventHandler(this.btn_agregarProfeEnPlan_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(95, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Limpiar Datos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Empezar Armado de Plan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(109, 143);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(194, 23);
            this.textBox7.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fecha Fin";
            // 
            // txt_fechaActualPlan
            // 
            this.txt_fechaActualPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaActualPlan.Location = new System.Drawing.Point(109, 76);
            this.txt_fechaActualPlan.Name = "txt_fechaActualPlan";
            this.txt_fechaActualPlan.Size = new System.Drawing.Size(194, 23);
            this.txt_fechaActualPlan.TabIndex = 13;
            this.txt_fechaActualPlan.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha Inicio";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(109, 110);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Plan N°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Profesor";
            // 
            // cmb_profesor
            // 
            this.cmb_profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_profesor.FormattingEnabled = true;
            this.cmb_profesor.Location = new System.Drawing.Point(109, 39);
            this.cmb_profesor.Name = "cmb_profesor";
            this.cmb_profesor.Size = new System.Drawing.Size(149, 24);
            this.cmb_profesor.TabIndex = 0;
            // 
            // btn_cerrarPlan
            // 
            this.btn_cerrarPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarPlan.Image")));
            this.btn_cerrarPlan.Location = new System.Drawing.Point(756, 12);
            this.btn_cerrarPlan.Name = "btn_cerrarPlan";
            this.btn_cerrarPlan.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrarPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrarPlan.TabIndex = 5;
            this.btn_cerrarPlan.TabStop = false;
            this.btn_cerrarPlan.Click += new System.EventHandler(this.btn_cerrarPlan_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPlanDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 452);
            this.Controls.Add(this.btn_cerrarPlan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPlanDatos";
            this.Text = "Form Plan Datos";
            this.Load += new System.EventHandler(this.FormPlanDatos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sesionesPlan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown cmb_sesionesPlan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_fechaActualPlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_profesor;
        private System.Windows.Forms.PictureBox btn_cerrarPlan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_apellidoClientePlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreClientePlan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_agregarProfeEnPlan;
    }
}