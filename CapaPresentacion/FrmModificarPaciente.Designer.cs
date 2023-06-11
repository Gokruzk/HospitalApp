namespace CapaPresentacion
{
    partial class FrmModificarPaciente
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.TxtNumSegSocial = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.lblModificarPaciente = new System.Windows.Forms.Label();
            this.CmbMedicoAsignado = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblMedcoAsignado = new System.Windows.Forms.Label();
            this.LblNumSegSocial = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.CmbHabDes = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbCampo = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtEleccion = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerFecNac
            // 
            this.dateTimePickerFecNac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.dateTimePickerFecNac.Location = new System.Drawing.Point(298, 183);
            this.dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            this.dateTimePickerFecNac.Size = new System.Drawing.Size(385, 29);
            this.dateTimePickerFecNac.TabIndex = 94;
            this.dateTimePickerFecNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecNac_KeyPress);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(427, 404);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(189, 50);
            this.BtnCancelar.TabIndex = 93;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreModificar.Location = new System.Drawing.Point(170, 140);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(580, 29);
            this.txtNombreModificar.TabIndex = 92;
            this.txtNombreModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreModificar_KeyPress);
            // 
            // TxtNumSegSocial
            // 
            this.TxtNumSegSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSegSocial.Location = new System.Drawing.Point(387, 272);
            this.TxtNumSegSocial.Name = "TxtNumSegSocial";
            this.TxtNumSegSocial.Size = new System.Drawing.Size(183, 29);
            this.TxtNumSegSocial.TabIndex = 90;
            this.TxtNumSegSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumSegSocial_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(179, 224);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(580, 29);
            this.TxtDireccion.TabIndex = 89;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // lblModificarPaciente
            // 
            this.lblModificarPaciente.AutoSize = true;
            this.lblModificarPaciente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModificarPaciente.Location = new System.Drawing.Point(237, 23);
            this.lblModificarPaciente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModificarPaciente.Name = "lblModificarPaciente";
            this.lblModificarPaciente.Size = new System.Drawing.Size(313, 32);
            this.lblModificarPaciente.TabIndex = 1;
            this.lblModificarPaciente.Text = "MODIFICAR PACIENTE";
            // 
            // CmbMedicoAsignado
            // 
            this.CmbMedicoAsignado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.CmbMedicoAsignado.FormattingEnabled = true;
            this.CmbMedicoAsignado.Location = new System.Drawing.Point(258, 318);
            this.CmbMedicoAsignado.Name = "CmbMedicoAsignado";
            this.CmbMedicoAsignado.Size = new System.Drawing.Size(409, 30);
            this.CmbMedicoAsignado.TabIndex = 95;
            this.CmbMedicoAsignado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbMedicoAsignado_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblModificarPaciente);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 78);
            this.panel1.TabIndex = 88;
            // 
            // LblMedcoAsignado
            // 
            this.LblMedcoAsignado.AutoSize = true;
            this.LblMedcoAsignado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedcoAsignado.Location = new System.Drawing.Point(45, 321);
            this.LblMedcoAsignado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMedcoAsignado.Name = "LblMedcoAsignado";
            this.LblMedcoAsignado.Size = new System.Drawing.Size(204, 22);
            this.LblMedcoAsignado.TabIndex = 86;
            this.LblMedcoAsignado.Text = "MÉDICO ASIGNADO:";
            // 
            // LblNumSegSocial
            // 
            this.LblNumSegSocial.AutoSize = true;
            this.LblNumSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSocial.Location = new System.Drawing.Point(45, 276);
            this.LblNumSegSocial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNumSegSocial.Name = "LblNumSegSocial";
            this.LblNumSegSocial.Size = new System.Drawing.Size(334, 22);
            this.LblNumSegSocial.TabIndex = 87;
            this.LblNumSegSocial.Text = "NÚMERO DE SEGURIDAD SOCIAL:";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(34, 186);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(243, 22);
            this.LblFechaNacimiento.TabIndex = 84;
            this.LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(45, 228);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(126, 22);
            this.LblDireccion.TabIndex = 83;
            this.LblDireccion.Text = "DIRECCÍON:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(60, 144);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 22);
            this.lblNombre.TabIndex = 82;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnModificar.Location = new System.Drawing.Point(232, 405);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(189, 50);
            this.BtnModificar.TabIndex = 81;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // CmbHabDes
            // 
            this.CmbHabDes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.CmbHabDes.FormattingEnabled = true;
            this.CmbHabDes.Location = new System.Drawing.Point(320, 361);
            this.CmbHabDes.Name = "CmbHabDes";
            this.CmbHabDes.Size = new System.Drawing.Size(214, 30);
            this.CmbHabDes.TabIndex = 95;
            this.CmbHabDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbHabDes_KeyPress);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(215, 364);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(97, 22);
            this.LblEstado.TabIndex = 103;
            this.LblEstado.Text = "ESTADO:";
            // 
            // CmbCampo
            // 
            this.CmbCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbCampo.FormattingEnabled = true;
            this.CmbCampo.Items.AddRange(new object[] {
            "CÉDULA",
            "NUM. SEGURIDAD SOCIAL"});
            this.CmbCampo.Location = new System.Drawing.Point(147, 94);
            this.CmbCampo.Name = "CmbCampo";
            this.CmbCampo.Size = new System.Drawing.Size(226, 32);
            this.CmbCampo.TabIndex = 111;
            this.CmbCampo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbCampo_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(617, 89);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(189, 39);
            this.BtnBuscar.TabIndex = 110;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtEleccion
            // 
            this.TxtEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEleccion.Location = new System.Drawing.Point(402, 94);
            this.TxtEleccion.Name = "TxtEleccion";
            this.TxtEleccion.Size = new System.Drawing.Size(183, 29);
            this.TxtEleccion.TabIndex = 109;
            this.TxtEleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEleccion_KeyPress);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(36, 101);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(88, 22);
            this.LblCedula.TabIndex = 108;
            this.LblCedula.Text = "CAMPO:";
            // 
            // FrmModificarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(834, 478);
            this.Controls.Add(this.CmbCampo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtEleccion);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.dateTimePickerFecNac);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.txtNombreModificar);
            this.Controls.Add(this.TxtNumSegSocial);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.CmbHabDes);
            this.Controls.Add(this.CmbMedicoAsignado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblMedcoAsignado);
            this.Controls.Add(this.LblNumSegSocial);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.BtnModificar);
            this.Name = "FrmModificarPaciente";
            this.Text = "Modificar Paciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFecNac;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.TextBox TxtNumSegSocial;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label lblModificarPaciente;
        private System.Windows.Forms.ComboBox CmbMedicoAsignado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblMedcoAsignado;
        private System.Windows.Forms.Label LblNumSegSocial;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.ComboBox CmbHabDes;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbCampo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtEleccion;
        private System.Windows.Forms.Label LblCedula;
    }
}