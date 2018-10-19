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
            this.txt_imprimirPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaprevia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vistaprevia
            // 
            this.dgv_vistaprevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaprevia.Location = new System.Drawing.Point(786, 78);
            this.dgv_vistaprevia.Name = "dgv_vistaprevia";
            this.dgv_vistaprevia.Size = new System.Drawing.Size(70, 24);
            this.dgv_vistaprevia.TabIndex = 0;
            this.dgv_vistaprevia.Visible = false;
            // 
            // txt_imprimirPlan
            // 
            this.txt_imprimirPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_imprimirPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_imprimirPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_imprimirPlan.FlatAppearance.BorderSize = 0;
            this.txt_imprimirPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_imprimirPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_imprimirPlan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_imprimirPlan.ForeColor = System.Drawing.Color.White;
            this.txt_imprimirPlan.Location = new System.Drawing.Point(786, 12);
            this.txt_imprimirPlan.Name = "txt_imprimirPlan";
            this.txt_imprimirPlan.Size = new System.Drawing.Size(105, 51);
            this.txt_imprimirPlan.TabIndex = 6;
            this.txt_imprimirPlan.Text = "IMPRIMIR";
            this.txt_imprimirPlan.UseVisualStyleBackColor = false;
            this.txt_imprimirPlan.Click += new System.EventHandler(this.txt_imprimirPlan_Click);
            // 
            // FormVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(907, 485);
            this.Controls.Add(this.txt_imprimirPlan);
            this.Controls.Add(this.dgv_vistaprevia);
            this.Name = "FormVistaPrevia";
            this.Text = "FormVistaPrevia";
            this.Load += new System.EventHandler(this.FormVistaPrevia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaprevia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vistaprevia;
        private System.Windows.Forms.Button txt_imprimirPlan;
    }
}