namespace feelGYM.PlanEjercicios
{
    partial class TabsSesiones
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txt_imprimirPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 662);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // txt_imprimirPlan
            // 
            this.txt_imprimirPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_imprimirPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.txt_imprimirPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_imprimirPlan.FlatAppearance.BorderSize = 0;
            this.txt_imprimirPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_imprimirPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_imprimirPlan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_imprimirPlan.ForeColor = System.Drawing.Color.LightGray;
            this.txt_imprimirPlan.Location = new System.Drawing.Point(755, 668);
            this.txt_imprimirPlan.Name = "txt_imprimirPlan";
            this.txt_imprimirPlan.Size = new System.Drawing.Size(149, 46);
            this.txt_imprimirPlan.TabIndex = 5;
            this.txt_imprimirPlan.Text = "VISTA PREVIA";
            this.txt_imprimirPlan.UseVisualStyleBackColor = false;
            this.txt_imprimirPlan.Click += new System.EventHandler(this.txt_imprimirPlan_Click);
            // 
            // TabsSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(921, 720);
            this.Controls.Add(this.txt_imprimirPlan);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabsSesiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabsSesiones";
            this.Load += new System.EventHandler(this.TabsSesiones_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button txt_imprimirPlan;
    }
}