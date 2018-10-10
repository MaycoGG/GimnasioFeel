namespace feelGYM.PlanEjercicios
{
    partial class GrillaEjercicios
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
            this.dataGridEjercicios = new System.Windows.Forms.DataGridView();
            this.checkBoxAero = new System.Windows.Forms.CheckBox();
            this.checkBoxZona = new System.Windows.Forms.CheckBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEjercicios
            // 
            this.dataGridEjercicios.AllowUserToAddRows = false;
            this.dataGridEjercicios.AllowUserToDeleteRows = false;
            this.dataGridEjercicios.AllowUserToOrderColumns = true;
            this.dataGridEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEjercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            this.dataGridEjercicios.Location = new System.Drawing.Point(12, 12);
            this.dataGridEjercicios.Name = "dataGridEjercicios";
            this.dataGridEjercicios.Size = new System.Drawing.Size(653, 278);
            this.dataGridEjercicios.TabIndex = 0;
            // 
            // checkBoxAero
            // 
            this.checkBoxAero.AutoSize = true;
            this.checkBoxAero.Location = new System.Drawing.Point(24, 310);
            this.checkBoxAero.Name = "checkBoxAero";
            this.checkBoxAero.Size = new System.Drawing.Size(96, 17);
            this.checkBoxAero.TabIndex = 1;
            this.checkBoxAero.Text = "checkBoxAero";
            this.checkBoxAero.UseVisualStyleBackColor = true;
            this.checkBoxAero.Visible = false;
            // 
            // checkBoxZona
            // 
            this.checkBoxZona.AutoSize = true;
            this.checkBoxZona.Location = new System.Drawing.Point(126, 310);
            this.checkBoxZona.Name = "checkBoxZona";
            this.checkBoxZona.Size = new System.Drawing.Size(99, 17);
            this.checkBoxZona.TabIndex = 2;
            this.checkBoxZona.Text = "checkBoxZona";
            this.checkBoxZona.UseVisualStyleBackColor = true;
            this.checkBoxZona.Visible = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(465, 304);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(560, 304);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Seleccion
            // 
            this.Seleccion.FalseValue = "False";
            this.Seleccion.HeaderText = "Selección";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Width = 60;
            // 
            // GrillaEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 339);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.checkBoxZona);
            this.Controls.Add(this.checkBoxAero);
            this.Controls.Add(this.dataGridEjercicios);
            this.Name = "GrillaEjercicios";
            this.Text = "GrillaEjercicios";
            this.Load += new System.EventHandler(this.GrillaEjercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEjercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEjercicios;
        public System.Windows.Forms.CheckBox checkBoxAero;
        public System.Windows.Forms.CheckBox checkBoxZona;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
    }
}