namespace CapaPresentacion
{
    partial class FrmIngresoDatosPaciente
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
            this.dateTimePickerFecNac = new System.Windows.Forms.DateTimePicker();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtNumSegSocial = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.lblIngresarPaciente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblNumSegSocial = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.LblMedicoAsignado = new System.Windows.Forms.Label();
            this.CmbMedicoAsignado = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerFecNac
            // 
            this.dateTimePickerFecNac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.dateTimePickerFecNac.Location = new System.Drawing.Point(400, 251);
            this.dateTimePickerFecNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            this.dateTimePickerFecNac.Size = new System.Drawing.Size(512, 35);
            this.dateTimePickerFecNac.TabIndex = 79;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(229, 198);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(772, 34);
            this.TxtNombre.TabIndex = 75;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(536, 121);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(243, 34);
            this.TxtCedula.TabIndex = 74;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtNumSegSocial
            // 
            this.TxtNumSegSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSegSocial.Location = new System.Drawing.Point(519, 361);
            this.TxtNumSegSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNumSegSocial.Name = "TxtNumSegSocial";
            this.TxtNumSegSocial.Size = new System.Drawing.Size(243, 34);
            this.TxtNumSegSocial.TabIndex = 73;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(241, 302);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(772, 34);
            this.TxtDireccion.TabIndex = 72;
            // 
            // lblIngresarPaciente
            // 
            this.lblIngresarPaciente.AutoSize = true;
            this.lblIngresarPaciente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresarPaciente.Location = new System.Drawing.Point(316, 28);
            this.lblIngresarPaciente.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIngresarPaciente.Name = "lblIngresarPaciente";
            this.lblIngresarPaciente.Size = new System.Drawing.Size(372, 38);
            this.lblIngresarPaciente.TabIndex = 1;
            this.lblIngresarPaciente.Text = "INGRESAR PACIENTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarPaciente);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 96);
            this.panel1.TabIndex = 71;
            // 
            // LblNumSegSocial
            // 
            this.LblNumSegSocial.AutoSize = true;
            this.LblNumSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSocial.Location = new System.Drawing.Point(63, 366);
            this.LblNumSegSocial.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblNumSegSocial.Name = "LblNumSegSocial";
            this.LblNumSegSocial.Size = new System.Drawing.Size(419, 28);
            this.LblNumSegSocial.TabIndex = 70;
            this.LblNumSegSocial.Text = "NÚMERO DE SEGURIDAD SOCIAL:";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(397, 129);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(121, 28);
            this.LblCedula.TabIndex = 69;
            this.LblCedula.Text = "CÉDULA:";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(48, 255);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(306, 28);
            this.LblFechaNacimiento.TabIndex = 67;
            this.LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(63, 306);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(160, 28);
            this.LblDireccion.TabIndex = 66;
            this.LblDireccion.Text = "DIRECCÍON:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(83, 203);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 28);
            this.lblNombre.TabIndex = 65;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // LblMedicoAsignado
            // 
            this.LblMedicoAsignado.AutoSize = true;
            this.LblMedicoAsignado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicoAsignado.Location = new System.Drawing.Point(63, 421);
            this.LblMedicoAsignado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblMedicoAsignado.Name = "LblMedicoAsignado";
            this.LblMedicoAsignado.Size = new System.Drawing.Size(257, 28);
            this.LblMedicoAsignado.TabIndex = 70;
            this.LblMedicoAsignado.Text = "MÉDICO ASIGNADO:";
            // 
            // CmbMedicoAsignado
            // 
            this.CmbMedicoAsignado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.CmbMedicoAsignado.FormattingEnabled = true;
            this.CmbMedicoAsignado.Location = new System.Drawing.Point(347, 417);
            this.CmbMedicoAsignado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbMedicoAsignado.Name = "CmbMedicoAsignado";
            this.CmbMedicoAsignado.Size = new System.Drawing.Size(544, 36);
            this.CmbMedicoAsignado.TabIndex = 80;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(567, 489);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(252, 62);
            this.BtnCancelar.TabIndex = 82;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnRegistrar.Location = new System.Drawing.Point(307, 490);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(252, 62);
            this.BtnRegistrar.TabIndex = 81;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // FrmIngresoDatosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1112, 588);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.CmbMedicoAsignado);
            this.Controls.Add(this.dateTimePickerFecNac);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNumSegSocial);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblMedicoAsignado);
            this.Controls.Add(this.LblNumSegSocial);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIngresoDatosPaciente";
            this.Text = "Ingresar paciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFecNac;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNumSegSocial;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label lblIngresarPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblNumSegSocial;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label LblMedicoAsignado;
        private System.Windows.Forms.ComboBox CmbMedicoAsignado;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}