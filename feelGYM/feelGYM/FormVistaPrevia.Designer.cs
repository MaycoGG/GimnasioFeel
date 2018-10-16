namespace feelGYM
{
    partial class FormVistaPrevia
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
            this.dgv_vistaprevia = new System.Windows.Forms.DataGridView();
            this.btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaprevia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vistaprevia
            // 
            this.dgv_vistaprevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaprevia.Location = new System.Drawing.Point(804, 69);
            this.dgv_vistaprevia.Name = "dgv_vistaprevia";
            this.dgv_vistaprevia.Size = new System.Drawing.Size(75, 22);
            this.dgv_vistaprevia.TabIndex = 0;
            this.dgv_vistaprevia.Visible = false;
            
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.AutoSize = true;
            this.btn_imprimir.Location = new System.Drawing.Point(786, 12);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(109, 51);
            this.btn_imprimir.TabIndex = 1;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // FormVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(907, 485);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.dgv_vistaprevia);
            this.Name = "FormVistaPrevia";
            this.Text = "FormVistaPrevia";
            this.Load += new System.EventHandler(this.FormVistaPrevia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaprevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vistaprevia;
        private System.Windows.Forms.Button btn_imprimir;
    }
}