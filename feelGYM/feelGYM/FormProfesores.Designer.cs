namespace feelGYM
{
    partial class FormProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfesores));
            this.btn_cerrarProfe = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_loginProfe = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_nuevoUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarProfe)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrarProfe
            // 
            this.btn_cerrarProfe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cerrarProfe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarProfe.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarProfe.Image")));
            this.btn_cerrarProfe.Location = new System.Drawing.Point(515, 12);
            this.btn_cerrarProfe.Name = "btn_cerrarProfe";
            this.btn_cerrarProfe.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrarProfe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrarProfe.TabIndex = 8;
            this.btn_cerrarProfe.TabStop = false;
            this.btn_cerrarProfe.Click += new System.EventHandler(this.btn_cerrarProfe_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "_________________________________________________";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.txt_usuario.Location = new System.Drawing.Point(116, 99);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(300, 19);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.Text = "USUARIO";
            this.txt_usuario.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Control;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pass.Location = new System.Drawing.Point(116, 135);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(300, 19);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Text = "CONTRASEÑA";
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "_________________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(203, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 32);
            this.label10.TabIndex = 23;
            this.label10.Text = "LOGIN";
            // 
            // txt_loginProfe
            // 
            this.txt_loginProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.txt_loginProfe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_loginProfe.FlatAppearance.BorderSize = 0;
            this.txt_loginProfe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_loginProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_loginProfe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginProfe.ForeColor = System.Drawing.Color.LightGray;
            this.txt_loginProfe.Location = new System.Drawing.Point(116, 171);
            this.txt_loginProfe.Name = "txt_loginProfe";
            this.txt_loginProfe.Size = new System.Drawing.Size(298, 40);
            this.txt_loginProfe.TabIndex = 4;
            this.txt_loginProfe.Text = "INGRESAR";
            this.txt_loginProfe.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(113, 223);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidó su contraseña?";
            // 
            // txt_nuevoUser
            // 
            this.txt_nuevoUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevoUser.Location = new System.Drawing.Point(278, 221);
            this.txt_nuevoUser.Name = "txt_nuevoUser";
            this.txt_nuevoUser.Size = new System.Drawing.Size(136, 23);
            this.txt_nuevoUser.TabIndex = 26;
            this.txt_nuevoUser.Text = "AGREGAR USUARIO";
            this.txt_nuevoUser.UseVisualStyleBackColor = true;
            this.txt_nuevoUser.Click += new System.EventHandler(this.txt_nuevoUser_Click);
            // 
            // FormProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(552, 334);
            this.Controls.Add(this.txt_nuevoUser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txt_loginProfe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_cerrarProfe);
            this.Name = "FormProfesores";
            this.Text = "FormProfesores";
            this.Load += new System.EventHandler(this.FormProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarProfe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_cerrarProfe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button txt_loginProfe;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button txt_nuevoUser;
    }
}