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
            this.txt_nombreEjercicio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipoEjercicioAgregar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_nombreEjercicio
            // 
            this.txt_nombreEjercicio.Location = new System.Drawing.Point(235, 153);
            this.txt_nombreEjercicio.Name = "txt_nombreEjercicio";
            this.txt_nombreEjercicio.Size = new System.Drawing.Size(203, 20);
            this.txt_nombreEjercicio.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "TIPO EJERCICIO";
            // 
            // cmb_tipoEjercicioAgregar
            // 
            this.cmb_tipoEjercicioAgregar.FormattingEnabled = true;
            this.cmb_tipoEjercicioAgregar.Location = new System.Drawing.Point(235, 116);
            this.cmb_tipoEjercicioAgregar.Name = "cmb_tipoEjercicioAgregar";
            this.cmb_tipoEjercicioAgregar.Size = new System.Drawing.Size(203, 21);
            this.cmb_tipoEjercicioAgregar.TabIndex = 14;
            // 
            // FormAgregarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 354);
            this.Controls.Add(this.txt_nombreEjercicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_tipoEjercicioAgregar);
            this.Name = "FormAgregarEjercicio";
            this.Text = "FormAgregarEjercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombreEjercicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipoEjercicioAgregar;
    }
}