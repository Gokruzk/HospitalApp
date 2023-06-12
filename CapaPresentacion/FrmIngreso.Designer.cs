namespace CapaPresentacion
{
    partial class FrmIngreso
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
            this.LblTituloInicio = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LblTituloInicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 98);
            this.panel1.TabIndex = 1;
            // 
            // LblTituloInicio
            // 
            this.LblTituloInicio.AutoSize = true;
            this.LblTituloInicio.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloInicio.Location = new System.Drawing.Point(302, 29);
            this.LblTituloInicio.Name = "LblTituloInicio";
            this.LblTituloInicio.Size = new System.Drawing.Size(182, 42);
            this.LblTituloInicio.TabIndex = 0;
            this.LblTituloInicio.Text = "INGRESO";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(332, 137);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(107, 23);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "USUARIO:";
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia.Location = new System.Drawing.Point(303, 209);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(158, 23);
            this.LblContrasenia.TabIndex = 0;
            this.LblContrasenia.Text = "CONTRASEÑA:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.TxtUsuario.Location = new System.Drawing.Point(236, 163);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(291, 32);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.TxtContrasenia.Location = new System.Drawing.Point(236, 246);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.Size = new System.Drawing.Size(291, 32);
            this.TxtContrasenia.TabIndex = 2;
            this.TxtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContrasenia_KeyPress);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.BtnIngresar.Location = new System.Drawing.Point(311, 301);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(134, 49);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 394);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblContrasenia);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTituloInicio;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.Button BtnIngresar;
    }
}