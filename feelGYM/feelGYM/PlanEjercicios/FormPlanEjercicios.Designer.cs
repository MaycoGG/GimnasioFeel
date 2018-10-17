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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dniSocio = new System.Windows.Forms.Label();
            this.lbl_numPlan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_numPag = new System.Windows.Forms.Label();
            this.lbl_sesion = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_aceptarPag = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_ejerciciosDesarrollo = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Desarrollo = new System.Windows.Forms.DataGridView();
            this.rb_dorsalesD = new System.Windows.Forms.RadioButton();
            this.rb_HombroD = new System.Windows.Forms.RadioButton();
            this.rb_bicepsD = new System.Windows.Forms.RadioButton();
            this.rb_tricepsD = new System.Windows.Forms.RadioButton();
            this.rb_piernasD = new System.Windows.Forms.RadioButton();
            this.rb_aeroD = new System.Windows.Forms.RadioButton();
            this.rb_zonaD = new System.Windows.Forms.RadioButton();
            this.rb_pectoralesD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_EjerciciosEC = new System.Windows.Forms.DataGridView();
            this.selec_EjerEC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_EntradaCalor = new System.Windows.Forms.DataGridView();
            this.btn_buscarEC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_aeroEC = new System.Windows.Forms.RadioButton();
            this.rb_ZonaMediaEC = new System.Windows.Forms.RadioButton();
            this.nombreeje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intensidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ejerciciosDesarrollo)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Desarrollo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EjerciciosEC)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EntradaCalor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 623);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_dniSocio
            // 
            this.lbl_dniSocio.AutoSize = true;
            this.lbl_dniSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dniSocio.Location = new System.Drawing.Point(17, 10);
            this.lbl_dniSocio.Name = "lbl_dniSocio";
            this.lbl_dniSocio.Size = new System.Drawing.Size(71, 31);
            this.lbl_dniSocio.TabIndex = 27;
            this.lbl_dniSocio.Text = "Num";
            this.lbl_dniSocio.Visible = false;
            // 
            // lbl_numPlan
            // 
            this.lbl_numPlan.AutoSize = true;
            this.lbl_numPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lbl_numPlan.Location = new System.Drawing.Point(263, 10);
            this.lbl_numPlan.Name = "lbl_numPlan";
            this.lbl_numPlan.Size = new System.Drawing.Size(71, 31);
            this.lbl_numPlan.TabIndex = 26;
            this.lbl_numPlan.Text = "Num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(140, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "N° Plan:";
            // 
            // lbl_numPag
            // 
            this.lbl_numPag.AutoSize = true;
            this.lbl_numPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lbl_numPag.Location = new System.Drawing.Point(474, 10);
            this.lbl_numPag.Name = "lbl_numPag";
            this.lbl_numPag.Size = new System.Drawing.Size(71, 31);
            this.lbl_numPag.TabIndex = 24;
            this.lbl_numPag.Text = "Num";
            // 
            // lbl_sesion
            // 
            this.lbl_sesion.AutoSize = true;
            this.lbl_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lbl_sesion.Location = new System.Drawing.Point(351, 10);
            this.lbl_sesion.Name = "lbl_sesion";
            this.lbl_sesion.Size = new System.Drawing.Size(132, 31);
            this.lbl_sesion.TabIndex = 23;
            this.lbl_sesion.Text = "SESIÓN: ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_dniSocio);
            this.panel6.Controls.Add(this.btn_aceptarPag);
            this.panel6.Controls.Add(this.lbl_numPlan);
            this.panel6.Controls.Add(this.lbl_sesion);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lbl_numPag);
            this.panel6.Location = new System.Drawing.Point(48, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(828, 63);
            this.panel6.TabIndex = 23;
            // 
            // btn_aceptarPag
            // 
            this.btn_aceptarPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_aceptarPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptarPag.FlatAppearance.BorderSize = 0;
            this.btn_aceptarPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceptarPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarPag.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarPag.ForeColor = System.Drawing.Color.LightGray;
            this.btn_aceptarPag.Location = new System.Drawing.Point(621, 7);
            this.btn_aceptarPag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aceptarPag.Name = "btn_aceptarPag";
            this.btn_aceptarPag.Size = new System.Drawing.Size(184, 46);
            this.btn_aceptarPag.TabIndex = 56;
            this.btn_aceptarPag.Text = "GUARDAR SESIÓN";
            this.btn_aceptarPag.UseVisualStyleBackColor = false;
            this.btn_aceptarPag.Click += new System.EventHandler(this.btn_aceptarPag_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.dgv_ejerciciosDesarrollo);
            this.panel5.Location = new System.Drawing.Point(48, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(828, 220);
            this.panel5.TabIndex = 21;
            // 
            // dgv_ejerciciosDesarrollo
            // 
            this.dgv_ejerciciosDesarrollo.AllowUserToAddRows = false;
            this.dgv_ejerciciosDesarrollo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ejerciciosDesarrollo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dgv_ejerciciosDesarrollo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ejerciciosDesarrollo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dgv_ejerciciosDesarrollo.EnableHeadersVisualStyles = false;
            this.dgv_ejerciciosDesarrollo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgv_ejerciciosDesarrollo.Location = new System.Drawing.Point(179, 21);
            this.dgv_ejerciciosDesarrollo.Name = "dgv_ejerciciosDesarrollo";
            this.dgv_ejerciciosDesarrollo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ejerciciosDesarrollo.Size = new System.Drawing.Size(629, 170);
            this.dgv_ejerciciosDesarrollo.TabIndex = 7;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Selección";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(48, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(828, 270);
            this.panel4.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dgv_Desarrollo);
            this.groupBox2.Controls.Add(this.rb_dorsalesD);
            this.groupBox2.Controls.Add(this.rb_HombroD);
            this.groupBox2.Controls.Add(this.rb_bicepsD);
            this.groupBox2.Controls.Add(this.rb_tricepsD);
            this.groupBox2.Controls.Add(this.rb_piernasD);
            this.groupBox2.Controls.Add(this.rb_aeroD);
            this.groupBox2.Controls.Add(this.rb_zonaD);
            this.groupBox2.Controls.Add(this.rb_pectoralesD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 256);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desarrollo";
            // 
            // dgv_Desarrollo
            // 
            this.dgv_Desarrollo.AllowUserToAddRows = false;
            this.dgv_Desarrollo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Desarrollo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dgv_Desarrollo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Desarrollo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.IDD,
            this.intensidad,
            this.series,
            this.repeticiones,
            this.observacionD});
            this.dgv_Desarrollo.EnableHeadersVisualStyles = false;
            this.dgv_Desarrollo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgv_Desarrollo.Location = new System.Drawing.Point(18, 77);
            this.dgv_Desarrollo.Name = "dgv_Desarrollo";
            this.dgv_Desarrollo.Size = new System.Drawing.Size(748, 173);
            this.dgv_Desarrollo.TabIndex = 21;
            // 
            // rb_dorsalesD
            // 
            this.rb_dorsalesD.AutoSize = true;
            this.rb_dorsalesD.Location = new System.Drawing.Point(255, 19);
            this.rb_dorsalesD.Name = "rb_dorsalesD";
            this.rb_dorsalesD.Size = new System.Drawing.Size(82, 21);
            this.rb_dorsalesD.TabIndex = 19;
            this.rb_dorsalesD.TabStop = true;
            this.rb_dorsalesD.Text = "Dorsales";
            this.rb_dorsalesD.UseVisualStyleBackColor = true;
            this.rb_dorsalesD.CheckedChanged += new System.EventHandler(this.rb_dorsalesD_CheckedChanged);
            // 
            // rb_HombroD
            // 
            this.rb_HombroD.AutoSize = true;
            this.rb_HombroD.Location = new System.Drawing.Point(365, 19);
            this.rb_HombroD.Name = "rb_HombroD";
            this.rb_HombroD.Size = new System.Drawing.Size(83, 21);
            this.rb_HombroD.TabIndex = 18;
            this.rb_HombroD.TabStop = true;
            this.rb_HombroD.Text = "Hombros";
            this.rb_HombroD.UseVisualStyleBackColor = true;
            this.rb_HombroD.CheckedChanged += new System.EventHandler(this.rb_HombroD_CheckedChanged);
            // 
            // rb_bicepsD
            // 
            this.rb_bicepsD.AutoSize = true;
            this.rb_bicepsD.Location = new System.Drawing.Point(478, 19);
            this.rb_bicepsD.Name = "rb_bicepsD";
            this.rb_bicepsD.Size = new System.Drawing.Size(68, 21);
            this.rb_bicepsD.TabIndex = 17;
            this.rb_bicepsD.TabStop = true;
            this.rb_bicepsD.Text = "Biceps";
            this.rb_bicepsD.UseVisualStyleBackColor = true;
            this.rb_bicepsD.CheckedChanged += new System.EventHandler(this.rb_bicepsD_CheckedChanged);
            // 
            // rb_tricepsD
            // 
            this.rb_tricepsD.AutoSize = true;
            this.rb_tricepsD.Location = new System.Drawing.Point(142, 46);
            this.rb_tricepsD.Name = "rb_tricepsD";
            this.rb_tricepsD.Size = new System.Drawing.Size(73, 21);
            this.rb_tricepsD.TabIndex = 16;
            this.rb_tricepsD.TabStop = true;
            this.rb_tricepsD.Text = "Triceps";
            this.rb_tricepsD.UseVisualStyleBackColor = true;
            this.rb_tricepsD.CheckedChanged += new System.EventHandler(this.rb_tricepsD_CheckedChanged);
            // 
            // rb_piernasD
            // 
            this.rb_piernasD.AutoSize = true;
            this.rb_piernasD.Location = new System.Drawing.Point(255, 46);
            this.rb_piernasD.Name = "rb_piernasD";
            this.rb_piernasD.Size = new System.Drawing.Size(74, 21);
            this.rb_piernasD.TabIndex = 15;
            this.rb_piernasD.TabStop = true;
            this.rb_piernasD.Text = "Piernas";
            this.rb_piernasD.UseVisualStyleBackColor = true;
            this.rb_piernasD.CheckedChanged += new System.EventHandler(this.rb_piernasD_CheckedChanged);
            // 
            // rb_aeroD
            // 
            this.rb_aeroD.AutoSize = true;
            this.rb_aeroD.Location = new System.Drawing.Point(365, 46);
            this.rb_aeroD.Name = "rb_aeroD";
            this.rb_aeroD.Size = new System.Drawing.Size(89, 21);
            this.rb_aeroD.TabIndex = 14;
            this.rb_aeroD.TabStop = true;
            this.rb_aeroD.Text = "Aeróbicos";
            this.rb_aeroD.UseVisualStyleBackColor = true;
            this.rb_aeroD.CheckedChanged += new System.EventHandler(this.rb_aeroD_CheckedChanged);
            // 
            // rb_zonaD
            // 
            this.rb_zonaD.AutoSize = true;
            this.rb_zonaD.Location = new System.Drawing.Point(478, 46);
            this.rb_zonaD.Name = "rb_zonaD";
            this.rb_zonaD.Size = new System.Drawing.Size(101, 21);
            this.rb_zonaD.TabIndex = 13;
            this.rb_zonaD.TabStop = true;
            this.rb_zonaD.Text = "Zona Media";
            this.rb_zonaD.UseVisualStyleBackColor = true;
            this.rb_zonaD.CheckedChanged += new System.EventHandler(this.rb_zonaD_CheckedChanged);
            // 
            // rb_pectoralesD
            // 
            this.rb_pectoralesD.AutoSize = true;
            this.rb_pectoralesD.Location = new System.Drawing.Point(142, 19);
            this.rb_pectoralesD.Name = "rb_pectoralesD";
            this.rb_pectoralesD.Size = new System.Drawing.Size(93, 21);
            this.rb_pectoralesD.TabIndex = 12;
            this.rb_pectoralesD.TabStop = true;
            this.rb_pectoralesD.Text = "Pectorales";
            this.rb_pectoralesD.UseVisualStyleBackColor = true;
            this.rb_pectoralesD.CheckedChanged += new System.EventHandler(this.rb_pectoralesD_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "OBJETIVOS DEL DÍA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.dgv_EjerciciosEC);
            this.panel3.Location = new System.Drawing.Point(48, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(828, 200);
            this.panel3.TabIndex = 19;
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
            this.button2.Location = new System.Drawing.Point(23, 73);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 47);
            this.button2.TabIndex = 58;
            this.button2.Text = "AGREGAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_EjerciciosEC
            // 
            this.dgv_EjerciciosEC.AllowUserToAddRows = false;
            this.dgv_EjerciciosEC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EjerciciosEC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dgv_EjerciciosEC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EjerciciosEC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selec_EjerEC});
            this.dgv_EjerciciosEC.EnableHeadersVisualStyles = false;
            this.dgv_EjerciciosEC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgv_EjerciciosEC.Location = new System.Drawing.Point(191, 18);
            this.dgv_EjerciciosEC.Name = "dgv_EjerciciosEC";
            this.dgv_EjerciciosEC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_EjerciciosEC.Size = new System.Drawing.Size(589, 170);
            this.dgv_EjerciciosEC.TabIndex = 7;
            // 
            // selec_EjerEC
            // 
            this.selec_EjerEC.HeaderText = "Selección";
            this.selec_EjerEC.Name = "selec_EjerEC";
            this.selec_EjerEC.Width = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(48, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 224);
            this.panel2.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_ZonaMediaEC);
            this.groupBox4.Controls.Add(this.rb_aeroEC);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.dgv_EntradaCalor);
            this.groupBox4.Controls.Add(this.btn_buscarEC);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 214);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ENTRADA EN CALOR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(9, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 47);
            this.button1.TabIndex = 57;
            this.button1.Text = "BORRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_EntradaCalor
            // 
            this.dgv_EntradaCalor.AllowUserToAddRows = false;
            this.dgv_EntradaCalor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EntradaCalor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.dgv_EntradaCalor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EntradaCalor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreeje,
            this.tipoEje,
            this.Id,
            this.observacionEC});
            this.dgv_EntradaCalor.EnableHeadersVisualStyles = false;
            this.dgv_EntradaCalor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgv_EntradaCalor.Location = new System.Drawing.Point(177, 22);
            this.dgv_EntradaCalor.Name = "dgv_EntradaCalor";
            this.dgv_EntradaCalor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_EntradaCalor.Size = new System.Drawing.Size(589, 171);
            this.dgv_EntradaCalor.TabIndex = 20;
            // 
            // btn_buscarEC
            // 
            this.btn_buscarEC.Location = new System.Drawing.Point(132, 68);
            this.btn_buscarEC.Name = "btn_buscarEC";
            this.btn_buscarEC.Size = new System.Drawing.Size(95, 0);
            this.btn_buscarEC.TabIndex = 17;
            this.btn_buscarEC.Text = "BUSCAR EJERCICIOS";
            this.btn_buscarEC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "SELECCIONE EJERCICIOS";
            // 
            // rb_aeroEC
            // 
            this.rb_aeroEC.AutoSize = true;
            this.rb_aeroEC.Location = new System.Drawing.Point(36, 74);
            this.rb_aeroEC.Name = "rb_aeroEC";
            this.rb_aeroEC.Size = new System.Drawing.Size(90, 21);
            this.rb_aeroEC.TabIndex = 58;
            this.rb_aeroEC.TabStop = true;
            this.rb_aeroEC.Text = "Aeróbicos";
            this.rb_aeroEC.UseVisualStyleBackColor = true;
            this.rb_aeroEC.CheckedChanged += new System.EventHandler(this.rb_aeroEC_CheckedChanged);
            // 
            // rb_ZonaMediaEC
            // 
            this.rb_ZonaMediaEC.AutoSize = true;
            this.rb_ZonaMediaEC.Location = new System.Drawing.Point(36, 101);
            this.rb_ZonaMediaEC.Name = "rb_ZonaMediaEC";
            this.rb_ZonaMediaEC.Size = new System.Drawing.Size(102, 21);
            this.rb_ZonaMediaEC.TabIndex = 59;
            this.rb_ZonaMediaEC.TabStop = true;
            this.rb_ZonaMediaEC.Text = "Zona Media";
            this.rb_ZonaMediaEC.UseVisualStyleBackColor = true;
            this.rb_ZonaMediaEC.CheckedChanged += new System.EventHandler(this.rb_ZonaMediaEC_CheckedChanged);
            // 
            // nombreeje
            // 
            this.nombreeje.HeaderText = "Nombre";
            this.nombreeje.Name = "nombreeje";
            this.nombreeje.ReadOnly = true;
            this.nombreeje.Width = 200;
            // 
            // tipoEje
            // 
            this.tipoEje.HeaderText = "Tipo Ejercicio";
            this.tipoEje.Name = "tipoEje";
            this.tipoEje.ReadOnly = true;
            this.tipoEje.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // observacionEC
            // 
            this.observacionEC.HeaderText = "Observación";
            this.observacionEC.Name = "observacionEC";
            this.observacionEC.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo Ejercicio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // IDD
            // 
            this.IDD.HeaderText = "IDD";
            this.IDD.Name = "IDD";
            this.IDD.Visible = false;
            // 
            // intensidad
            // 
            this.intensidad.HeaderText = "I (%)";
            this.intensidad.Name = "intensidad";
            this.intensidad.Width = 50;
            // 
            // series
            // 
            this.series.HeaderText = "S";
            this.series.Name = "series";
            this.series.Width = 50;
            // 
            // repeticiones
            // 
            this.repeticiones.HeaderText = "R";
            this.repeticiones.Name = "repeticiones";
            // 
            // observacionD
            // 
            this.observacionD.HeaderText = "Observaciones";
            this.observacionD.Name = "observacionD";
            this.observacionD.Width = 150;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(607, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 47);
            this.button3.TabIndex = 58;
            this.button3.Text = "BORRAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(14, 90);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 47);
            this.button4.TabIndex = 59;
            this.button4.Text = "AGREGAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormPlanEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(910, 623);
            this.Controls.Add(this.panel1);
            this.Name = "FormPlanEjercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlan_Ejercicios";
            this.Load += new System.EventHandler(this.FormPlanEjercicios_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ejerciciosDesarrollo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Desarrollo)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EjerciciosEC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EntradaCalor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscarEC;
        public System.Windows.Forms.DataGridView dgv_EntradaCalor;
        private System.Windows.Forms.DataGridView dgv_EjerciciosEC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selec_EjerEC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgv_ejerciciosDesarrollo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.RadioButton rb_dorsalesD;
        private System.Windows.Forms.RadioButton rb_HombroD;
        private System.Windows.Forms.RadioButton rb_bicepsD;
        private System.Windows.Forms.RadioButton rb_tricepsD;
        private System.Windows.Forms.RadioButton rb_piernasD;
        private System.Windows.Forms.RadioButton rb_aeroD;
        private System.Windows.Forms.RadioButton rb_zonaD;
        private System.Windows.Forms.RadioButton rb_pectoralesD;
        public System.Windows.Forms.DataGridView dgv_Desarrollo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_sesion;
        private System.Windows.Forms.Label lbl_numPag;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_numPlan;
        public System.Windows.Forms.Label lbl_dniSocio;
        private System.Windows.Forms.Button btn_aceptarPag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rb_ZonaMediaEC;
        private System.Windows.Forms.RadioButton rb_aeroEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreeje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn intensidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn series;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}