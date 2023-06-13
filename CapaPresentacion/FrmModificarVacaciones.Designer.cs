namespace CapaPresentacion
{
    partial class FrmModificarVacaciones
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
            this.dateTimePickerFecFin = new System.Windows.Forms.DateTimePicker();
            this.lblModificarVacaciones = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.LblFechaFin = new System.Windows.Forms.Label();
            this.dateTimePickerFecInicio = new System.Windows.Forms.DateTimePicker();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.TxtIdVac = new System.Windows.Forms.TextBox();
            this.LblIdVacaciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCedula = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerFecFin
            // 
            this.dateTimePickerFecFin.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFecFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecFin.Location = new System.Drawing.Point(532, 331);
            this.dateTimePickerFecFin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFecFin.Name = "dateTimePickerFecFin";
            this.dateTimePickerFecFin.Size = new System.Drawing.Size(416, 31);
            this.dateTimePickerFecFin.TabIndex = 79;
            this.dateTimePickerFecFin.CloseUp += new System.EventHandler(this.dateTimePickerFecFin_CloseUp);
            this.dateTimePickerFecFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecFin_KeyPress);
            // 
            // lblModificarVacaciones
            // 
            this.lblModificarVacaciones.AutoSize = true;
            this.lblModificarVacaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarVacaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModificarVacaciones.Location = new System.Drawing.Point(323, 27);
            this.lblModificarVacaciones.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblModificarVacaciones.Name = "lblModificarVacaciones";
            this.lblModificarVacaciones.Size = new System.Drawing.Size(438, 38);
            this.lblModificarVacaciones.TabIndex = 1;
            this.lblModificarVacaciones.Text = "MODIFICAR VACACIONES";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnModificar.Location = new System.Drawing.Point(311, 405);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(252, 62);
            this.BtnModificar.TabIndex = 83;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(379, 217);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(121, 28);
            this.LblEstado.TabIndex = 82;
            this.LblEstado.Text = "ESTADO:";
            // 
            // CmbEstado
            // 
            this.CmbEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Realizada",
            "Planificada"});
            this.CmbEstado.Location = new System.Drawing.Point(520, 213);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(260, 36);
            this.CmbEstado.TabIndex = 81;
            this.CmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbEstado_KeyPress);
            // 
            // LblFechaFin
            // 
            this.LblFechaFin.AutoSize = true;
            this.LblFechaFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaFin.Location = new System.Drawing.Point(281, 335);
            this.LblFechaFin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaFin.Name = "LblFechaFin";
            this.LblFechaFin.Size = new System.Drawing.Size(189, 28);
            this.LblFechaFin.TabIndex = 77;
            this.LblFechaFin.Text = "FECHA DE FIN:";
            // 
            // dateTimePickerFecInicio
            // 
            this.dateTimePickerFecInicio.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFecInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecInicio.Location = new System.Drawing.Point(532, 277);
            this.dateTimePickerFecInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFecInicio.Name = "dateTimePickerFecInicio";
            this.dateTimePickerFecInicio.Size = new System.Drawing.Size(416, 31);
            this.dateTimePickerFecInicio.TabIndex = 80;
            this.dateTimePickerFecInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecInicio_KeyPress);
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicio.Location = new System.Drawing.Point(281, 281);
            this.LblFechaInicio.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(228, 28);
            this.LblFechaInicio.TabIndex = 78;
            this.LblFechaInicio.Text = "FECHA DE INICIO:";
            // 
            // TxtIdVac
            // 
            this.TxtIdVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdVac.Location = new System.Drawing.Point(579, 145);
            this.TxtIdVac.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdVac.Name = "TxtIdVac";
            this.TxtIdVac.Size = new System.Drawing.Size(243, 34);
            this.TxtIdVac.TabIndex = 76;
            // 
            // LblIdVacaciones
            // 
            this.LblIdVacaciones.AutoSize = true;
            this.LblIdVacaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdVacaciones.Location = new System.Drawing.Point(401, 150);
            this.LblIdVacaciones.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblIdVacaciones.Name = "LblIdVacaciones";
            this.LblIdVacaciones.Size = new System.Drawing.Size(160, 28);
            this.LblIdVacaciones.TabIndex = 75;
            this.LblIdVacaciones.Text = "ID Vacación:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblModificarVacaciones);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 96);
            this.panel1.TabIndex = 74;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(16, 150);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(121, 28);
            this.LblCedula.TabIndex = 75;
            this.LblCedula.Text = "CÉDULA:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(144, 145);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(243, 34);
            this.TxtCedula.TabIndex = 76;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(603, 405);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(252, 62);
            this.BtnCancelar.TabIndex = 83;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(841, 140);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(252, 48);
            this.BtnBuscar.TabIndex = 111;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmModificarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1109, 533);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dateTimePickerFecFin);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.LblFechaFin);
            this.Controls.Add(this.dateTimePickerFecInicio);
            this.Controls.Add(this.LblFechaInicio);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.TxtIdVac);
            this.Controls.Add(this.LblIdVacaciones);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmModificarVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar vacaciones";
            this.Load += new System.EventHandler(this.FrmModificarVacaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFecFin;
        private System.Windows.Forms.Label lblModificarVacaciones;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label LblFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecInicio;
        private System.Windows.Forms.Label LblFechaInicio;
        private System.Windows.Forms.TextBox TxtIdVac;
        private System.Windows.Forms.Label LblIdVacaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}