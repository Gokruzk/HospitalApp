namespace CapaPresentacion
{
    partial class FrmIngresarVacaciones
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
            this.lblIngresarVacaciones = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFecFin = new System.Windows.Forms.DateTimePicker();
            this.LblFechaFin = new System.Windows.Forms.Label();
            this.dateTimePickerFecInicio = new System.Windows.Forms.DateTimePicker();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresarVacaciones
            // 
            this.lblIngresarVacaciones.AutoSize = true;
            this.lblIngresarVacaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarVacaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresarVacaciones.Location = new System.Drawing.Point(242, 22);
            this.lblIngresarVacaciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngresarVacaciones.Name = "lblIngresarVacaciones";
            this.lblIngresarVacaciones.Size = new System.Drawing.Size(347, 32);
            this.lblIngresarVacaciones.TabIndex = 1;
            this.lblIngresarVacaciones.Text = "INGRESAR VACACIONES";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(260, 169);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(97, 22);
            this.LblEstado.TabIndex = 82;
            this.LblEstado.Text = "ESTADO:";
            // 
            // CmbEstado
            // 
            this.CmbEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(366, 166);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(196, 30);
            this.CmbEstado.TabIndex = 81;
            this.CmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbEstado_KeyPress);
            // 
            // dateTimePickerFecFin
            // 
            this.dateTimePickerFecFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecFin.Location = new System.Drawing.Point(366, 258);
            this.dateTimePickerFecFin.Name = "dateTimePickerFecFin";
            this.dateTimePickerFecFin.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecFin.TabIndex = 79;
            this.dateTimePickerFecFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecFin_KeyPress);
            // 
            // LblFechaFin
            // 
            this.LblFechaFin.AutoSize = true;
            this.LblFechaFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaFin.Location = new System.Drawing.Point(178, 261);
            this.LblFechaFin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaFin.Name = "LblFechaFin";
            this.LblFechaFin.Size = new System.Drawing.Size(150, 22);
            this.LblFechaFin.TabIndex = 77;
            this.LblFechaFin.Text = "FECHA DE FIN:";
            // 
            // dateTimePickerFecInicio
            // 
            this.dateTimePickerFecInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecInicio.Location = new System.Drawing.Point(366, 214);
            this.dateTimePickerFecInicio.Name = "dateTimePickerFecInicio";
            this.dateTimePickerFecInicio.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecInicio.TabIndex = 80;
            this.dateTimePickerFecInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecInicio_KeyPress);
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicio.Location = new System.Drawing.Point(178, 217);
            this.LblFechaInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(180, 22);
            this.LblFechaInicio.TabIndex = 78;
            this.LblFechaInicio.Text = "FECHA DE INICIO:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(366, 120);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(196, 29);
            this.TxtCedula.TabIndex = 76;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(262, 124);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(96, 22);
            this.LblCedula.TabIndex = 75;
            this.LblCedula.Text = "CÉDULA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarVacaciones);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 78);
            this.panel1.TabIndex = 74;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(421, 322);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(189, 50);
            this.BtnCancelar.TabIndex = 84;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnRegistrar.Location = new System.Drawing.Point(226, 323);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(189, 50);
            this.BtnRegistrar.TabIndex = 83;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // FrmIngresarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.dateTimePickerFecFin);
            this.Controls.Add(this.LblFechaFin);
            this.Controls.Add(this.dateTimePickerFecInicio);
            this.Controls.Add(this.LblFechaInicio);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIngresarVacaciones";
            this.Text = "Ingresar Vacaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarVacaciones;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecFin;
        private System.Windows.Forms.Label LblFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecInicio;
        private System.Windows.Forms.Label LblFechaInicio;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}