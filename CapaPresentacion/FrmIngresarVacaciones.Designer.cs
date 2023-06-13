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
            this.lblIngresarVacaciones.Location = new System.Drawing.Point(323, 27);
            this.lblIngresarVacaciones.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIngresarVacaciones.Name = "lblIngresarVacaciones";
            this.lblIngresarVacaciones.Size = new System.Drawing.Size(426, 38);
            this.lblIngresarVacaciones.TabIndex = 1;
            this.lblIngresarVacaciones.Text = "INGRESAR VACACIONES";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(347, 208);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(121, 28);
            this.LblEstado.TabIndex = 82;
            this.LblEstado.Text = "ESTADO:";
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Realizada",
            "Planificada"});
            this.CmbEstado.Location = new System.Drawing.Point(488, 204);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(260, 36);
            this.CmbEstado.TabIndex = 81;
            this.CmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbEstado_KeyPress);
            // 
            // dateTimePickerFecFin
            // 
            this.dateTimePickerFecFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecFin.Location = new System.Drawing.Point(488, 318);
            this.dateTimePickerFecFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFecFin.Name = "dateTimePickerFecFin";
            this.dateTimePickerFecFin.Size = new System.Drawing.Size(416, 31);
            this.dateTimePickerFecFin.TabIndex = 79;
            this.dateTimePickerFecFin.CloseUp += new System.EventHandler(this.dateTimePickerFecFin_CloseUp);
            this.dateTimePickerFecFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecFin_KeyPress);
            // 
            // LblFechaFin
            // 
            this.LblFechaFin.AutoSize = true;
            this.LblFechaFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaFin.Location = new System.Drawing.Point(237, 321);
            this.LblFechaFin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaFin.Name = "LblFechaFin";
            this.LblFechaFin.Size = new System.Drawing.Size(189, 28);
            this.LblFechaFin.TabIndex = 77;
            this.LblFechaFin.Text = "FECHA DE FIN:";
            // 
            // dateTimePickerFecInicio
            // 
            this.dateTimePickerFecInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecInicio.Location = new System.Drawing.Point(488, 263);
            this.dateTimePickerFecInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFecInicio.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFecInicio.MinDate = new System.DateTime(2023, 6, 13, 0, 0, 0, 0);
            this.dateTimePickerFecInicio.Name = "dateTimePickerFecInicio";
            this.dateTimePickerFecInicio.Size = new System.Drawing.Size(416, 31);
            this.dateTimePickerFecInicio.TabIndex = 80;
            this.dateTimePickerFecInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecInicio_KeyPress);
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicio.Location = new System.Drawing.Point(237, 267);
            this.LblFechaInicio.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(228, 28);
            this.LblFechaInicio.TabIndex = 78;
            this.LblFechaInicio.Text = "FECHA DE INICIO:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(488, 148);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(260, 34);
            this.TxtCedula.TabIndex = 76;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(349, 153);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(121, 28);
            this.LblCedula.TabIndex = 75;
            this.LblCedula.Text = "CÉDULA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarVacaciones);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 96);
            this.panel1.TabIndex = 74;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(561, 396);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(252, 62);
            this.BtnCancelar.TabIndex = 84;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnRegistrar.Location = new System.Drawing.Point(301, 398);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(252, 62);
            this.BtnRegistrar.TabIndex = 83;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // FrmIngresarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1109, 533);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmIngresarVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Vacaciones";
            this.Load += new System.EventHandler(this.FrmIngresarVacaciones_Load);
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