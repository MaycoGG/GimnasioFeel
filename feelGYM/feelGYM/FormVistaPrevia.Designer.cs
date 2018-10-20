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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaPrevia));
            this.dgv_vistaprevia = new System.Windows.Forms.DataGridView();
            this.txt_imprimirPlan = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaprevia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vistaprevia
            // 
            this.dgv_vistaprevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaprevia.Location = new System.Drawing.Point(860, 110);
            this.dgv_vistaprevia.Name = "dgv_vistaprevia";
            this.dgv_vistaprevia.Size = new System.Drawing.Size(70, 24);
            this.dgv_vistaprevia.TabIndex = 0;
            this.dgv_vistaprevia.Visible = false;
            // 
            // txt_imprimirPlan
            // 
            this.txt_imprimirPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_imprimirPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_imprimirPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_imprimirPlan.FlatAppearance.BorderSize = 0;
            this.txt_imprimirPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_imprimirPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_imprimirPlan.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_imprimirPlan.ForeColor = System.Drawing.Color.White;
            this.txt_imprimirPlan.Location = new System.Drawing.Point(791, 80);
            this.txt_imprimirPlan.Name = "txt_imprimirPlan";
            this.txt_imprimirPlan.Size = new System.Drawing.Size(156, 71);
            this.txt_imprimirPlan.TabIndex = 6;
            this.txt_imprimirPlan.Text = "IMPRIMIR";
            this.txt_imprimirPlan.UseVisualStyleBackColor = false;
            this.txt_imprimirPlan.Click += new System.EventHandler(this.txt_imprimirPlan_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(915, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(32, 28);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 53;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // FormVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(960, 719);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.txt_imprimirPlan);
            this.Controls.Add(this.dgv_vistaprevia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVistaPrevia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVistaPrevia";
            this.Load += new System.EventHandler(this.FormVistaPrevia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaprevia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vistaprevia;
        private System.Windows.Forms.Button txt_imprimirPlan;
        private System.Windows.Forms.PictureBox btn_cerrar;
    }
}