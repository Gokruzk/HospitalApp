namespace CapaPresentacion
{
    partial class FrmIngresoDatosMedico
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
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblColegio = new System.Windows.Forms.Label();
            this.txtNumColegiado = new System.Windows.Forms.TextBox();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtNumSegSocial = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblNumSegSocial = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dateTimePickerFecNac = new System.Windows.Forms.DateTimePicker();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.GbxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonSustituto = new System.Windows.Forms.RadioButton();
            this.radioButtonTitular = new System.Windows.Forms.RadioButton();
            this.radioButtonInterino = new System.Windows.Forms.RadioButton();
            this.dateTimePickerFecAlta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecBaja = new System.Windows.Forms.DateTimePicker();
            this.LblFechaAlta = new System.Windows.Forms.Label();
            this.LblFechaBaja = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbPoblacion = new System.Windows.Forms.ComboBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblINgresarMEdico = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.GbxTipo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(101, 889);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(77, 16);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "PROVINCIA";
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblColegio.Location = new System.Drawing.Point(32, 344);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(261, 22);
            this.lblColegio.TabIndex = 11;
            this.lblColegio.Text = "NÚMERO DE COLEGIADO: ";
            // 
            // txtNumColegiado
            // 
            this.txtNumColegiado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txtNumColegiado.Location = new System.Drawing.Point(299, 341);
            this.txtNumColegiado.Name = "txtNumColegiado";
            this.txtNumColegiado.Size = new System.Drawing.Size(150, 29);
            this.txtNumColegiado.TabIndex = 19;
            this.txtNumColegiado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumColegiado_KeyPress);
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Items.AddRange(new object[] {
            "Azuay",
            "Bolívar",
            "Cañar",
            "Carchi",
            "Chimborazo",
            "Cotopaxi",
            "El Oro",
            "Esmeraldas",
            "Galápagos",
            "Guayas",
            "Imbabura",
            "Loja",
            "Los Ríos",
            "Manabí",
            "Morona Santiago",
            "Napo",
            "Orellana",
            "Pastaza",
            "Pichincha",
            "Santa Elena",
            "Santo Domingo de los Tsáchilas",
            "Sucumbíos",
            "Tungurahua",
            "Zamora Chinchipe"});
            this.comboBoxProvincia.Location = new System.Drawing.Point(262, 889);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(146, 24);
            this.comboBoxProvincia.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(190, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(580, 29);
            this.txtNombre.TabIndex = 64;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(420, 99);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(183, 29);
            this.TxtCedula.TabIndex = 63;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtNumSegSocial
            // 
            this.TxtNumSegSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSegSocial.Location = new System.Drawing.Point(266, 282);
            this.TxtNumSegSocial.Name = "TxtNumSegSocial";
            this.TxtNumSegSocial.Size = new System.Drawing.Size(183, 29);
            this.TxtNumSegSocial.TabIndex = 62;
            this.TxtNumSegSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumSegSocial_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(190, 228);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(580, 29);
            this.TxtDireccion.TabIndex = 61;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // LblNumSegSocial
            // 
            this.LblNumSegSocial.AutoSize = true;
            this.LblNumSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSocial.Location = new System.Drawing.Point(47, 278);
            this.LblNumSegSocial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNumSegSocial.Name = "LblNumSegSocial";
            this.LblNumSegSocial.Size = new System.Drawing.Size(211, 44);
            this.LblNumSegSocial.TabIndex = 60;
            this.LblNumSegSocial.Text = "NÚMERO DE \r\nSEGURIDAD SOCIAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "CÉDULA:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(56, 232);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(126, 22);
            this.LblDireccion.TabIndex = 58;
            this.LblDireccion.Text = "DIRECCÍON:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(80, 146);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 22);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // dateTimePickerFecNac
            // 
            this.dateTimePickerFecNac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecNac.Location = new System.Drawing.Point(311, 184);
            this.dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            this.dateTimePickerFecNac.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecNac.TabIndex = 66;
            this.dateTimePickerFecNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecNac_KeyPress);
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(47, 187);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(243, 22);
            this.LblFechaNacimiento.TabIndex = 65;
            this.LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // GbxTipo
            // 
            this.GbxTipo.Controls.Add(this.radioButtonSustituto);
            this.GbxTipo.Controls.Add(this.radioButtonTitular);
            this.GbxTipo.Controls.Add(this.radioButtonInterino);
            this.GbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.GbxTipo.Location = new System.Drawing.Point(36, 392);
            this.GbxTipo.Name = "GbxTipo";
            this.GbxTipo.Size = new System.Drawing.Size(398, 127);
            this.GbxTipo.TabIndex = 67;
            this.GbxTipo.TabStop = false;
            this.GbxTipo.Text = "TIPO DE MÉDICO";
            // 
            // radioButtonSustituto
            // 
            this.radioButtonSustituto.AutoSize = true;
            this.radioButtonSustituto.Location = new System.Drawing.Point(115, 87);
            this.radioButtonSustituto.Name = "radioButtonSustituto";
            this.radioButtonSustituto.Size = new System.Drawing.Size(181, 26);
            this.radioButtonSustituto.TabIndex = 0;
            this.radioButtonSustituto.TabStop = true;
            this.radioButtonSustituto.Text = "Médico Sustituto";
            this.radioButtonSustituto.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitular
            // 
            this.radioButtonTitular.AutoSize = true;
            this.radioButtonTitular.Location = new System.Drawing.Point(24, 43);
            this.radioButtonTitular.Name = "radioButtonTitular";
            this.radioButtonTitular.Size = new System.Drawing.Size(158, 26);
            this.radioButtonTitular.TabIndex = 0;
            this.radioButtonTitular.TabStop = true;
            this.radioButtonTitular.Text = "Médico Titular";
            this.radioButtonTitular.UseVisualStyleBackColor = true;
            // 
            // radioButtonInterino
            // 
            this.radioButtonInterino.AutoSize = true;
            this.radioButtonInterino.Location = new System.Drawing.Point(216, 43);
            this.radioButtonInterino.Name = "radioButtonInterino";
            this.radioButtonInterino.Size = new System.Drawing.Size(169, 26);
            this.radioButtonInterino.TabIndex = 0;
            this.radioButtonInterino.TabStop = true;
            this.radioButtonInterino.Text = "Médico Interino";
            this.radioButtonInterino.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFecAlta
            // 
            this.dateTimePickerFecAlta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecAlta.Location = new System.Drawing.Point(482, 427);
            this.dateTimePickerFecAlta.Name = "dateTimePickerFecAlta";
            this.dateTimePickerFecAlta.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecAlta.TabIndex = 66;
            this.dateTimePickerFecAlta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecAlta_KeyPress);
            // 
            // dateTimePickerFecBaja
            // 
            this.dateTimePickerFecBaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecBaja.Location = new System.Drawing.Point(482, 493);
            this.dateTimePickerFecBaja.Name = "dateTimePickerFecBaja";
            this.dateTimePickerFecBaja.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecBaja.TabIndex = 66;
            this.dateTimePickerFecBaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecBaja_KeyPress);
            // 
            // LblFechaAlta
            // 
            this.LblFechaAlta.AutoSize = true;
            this.LblFechaAlta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAlta.Location = new System.Drawing.Point(479, 391);
            this.LblFechaAlta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaAlta.Name = "LblFechaAlta";
            this.LblFechaAlta.Size = new System.Drawing.Size(170, 22);
            this.LblFechaAlta.TabIndex = 58;
            this.LblFechaAlta.Text = "FECHA DE ALTA:";
            // 
            // LblFechaBaja
            // 
            this.LblFechaBaja.AutoSize = true;
            this.LblFechaBaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaBaja.Location = new System.Drawing.Point(478, 462);
            this.LblFechaBaja.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaBaja.Name = "LblFechaBaja";
            this.LblFechaBaja.Size = new System.Drawing.Size(172, 22);
            this.LblFechaBaja.TabIndex = 58;
            this.LblFechaBaja.Text = "FECHA DE BAJA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 69;
            this.label5.Text = "POBLACIÓN:";
            // 
            // CmbPoblacion
            // 
            this.CmbPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbPoblacion.FormattingEnabled = true;
            this.CmbPoblacion.Location = new System.Drawing.Point(611, 340);
            this.CmbPoblacion.Name = "CmbPoblacion";
            this.CmbPoblacion.Size = new System.Drawing.Size(184, 32);
            this.CmbPoblacion.TabIndex = 68;
            this.CmbPoblacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPoblacion_KeyPress);
            // 
            // CmbTipo
            // 
            this.CmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(611, 282);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(184, 32);
            this.CmbTipo.TabIndex = 71;
            this.CmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbTipo_KeyPress);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(501, 286);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(62, 22);
            this.LblTipo.TabIndex = 70;
            this.LblTipo.Text = "TIPO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblINgresarMEdico);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 78);
            this.panel1.TabIndex = 73;
            // 
            // lblINgresarMEdico
            // 
            this.lblINgresarMEdico.AutoSize = true;
            this.lblINgresarMEdico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINgresarMEdico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblINgresarMEdico.Location = new System.Drawing.Point(292, 27);
            this.lblINgresarMEdico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblINgresarMEdico.Name = "lblINgresarMEdico";
            this.lblINgresarMEdico.Size = new System.Drawing.Size(273, 32);
            this.lblINgresarMEdico.TabIndex = 1;
            this.lblINgresarMEdico.Text = "INGRESAR MÉDICO";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(435, 543);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(189, 50);
            this.BtnCancelar.TabIndex = 60;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnRegistrar.Location = new System.Drawing.Point(240, 544);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(189, 50);
            this.BtnRegistrar.TabIndex = 59;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // FrmIngresoDatosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 637);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbPoblacion);
            this.Controls.Add(this.GbxTipo);
            this.Controls.Add(this.dateTimePickerFecBaja);
            this.Controls.Add(this.dateTimePickerFecAlta);
            this.Controls.Add(this.dateTimePickerFecNac);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNumSegSocial);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.LblNumSegSocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblFechaBaja);
            this.Controls.Add(this.LblFechaAlta);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.txtNumColegiado);
            this.Controls.Add(this.lblColegio);
            this.Controls.Add(this.lblProvincia);
            this.Name = "FrmIngresoDatosMedico";
            this.Text = "Ingresar Médico";
            this.GbxTipo.ResumeLayout(false);
            this.GbxTipo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblColegio;
        private System.Windows.Forms.TextBox txtNumColegiado;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNumSegSocial;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblNumSegSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecNac;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.GroupBox GbxTipo;
        private System.Windows.Forms.RadioButton radioButtonSustituto;
        private System.Windows.Forms.RadioButton radioButtonInterino;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecAlta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecBaja;
        private System.Windows.Forms.Label LblFechaAlta;
        private System.Windows.Forms.Label LblFechaBaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbPoblacion;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.RadioButton radioButtonTitular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblINgresarMEdico;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}