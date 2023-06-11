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
            this.components = new System.ComponentModel.Container();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblColegio = new System.Windows.Forms.Label();
            this.txtNumColegiado = new System.Windows.Forms.TextBox();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtNumSegSocial = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.CmbPoblacionModificar = new System.Windows.Forms.ComboBox();
            this.CmbTipoModificar = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblINgresarMEdico = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.hOSPITALDataSet = new CapaPresentacion.HOSPITALDataSet();
            this.tipoMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoMedicoTableAdapter = new CapaPresentacion.HOSPITALDataSetTableAdapters.TipoMedicoTableAdapter();
            this.GbxTipo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMedicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(135, 1094);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(102, 20);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "PROVINCIA";
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblColegio.Location = new System.Drawing.Point(43, 423);
            this.lblColegio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(328, 28);
            this.lblColegio.TabIndex = 11;
            this.lblColegio.Text = "NÚMERO DE COLEGIADO: ";
            // 
            // txtNumColegiado
            // 
            this.txtNumColegiado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txtNumColegiado.Location = new System.Drawing.Point(399, 420);
            this.txtNumColegiado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumColegiado.Name = "txtNumColegiado";
            this.txtNumColegiado.Size = new System.Drawing.Size(199, 35);
            this.txtNumColegiado.TabIndex = 19;
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
            this.comboBoxProvincia.Location = new System.Drawing.Point(349, 1094);
            this.comboBoxProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(193, 27);
            this.comboBoxProvincia.TabIndex = 20;
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreModificar.Location = new System.Drawing.Point(253, 175);
            this.txtNombreModificar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(772, 34);
            this.txtNombreModificar.TabIndex = 64;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(560, 122);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(243, 34);
            this.TxtCedula.TabIndex = 63;
            // 
            // TxtNumSegSocial
            // 
            this.TxtNumSegSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSegSocial.Location = new System.Drawing.Point(355, 347);
            this.TxtNumSegSocial.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumSegSocial.Name = "TxtNumSegSocial";
            this.TxtNumSegSocial.Size = new System.Drawing.Size(243, 34);
            this.TxtNumSegSocial.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(253, 281);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(772, 34);
            this.textBox1.TabIndex = 61;
            // 
            // LblNumSegSocial
            // 
            this.LblNumSegSocial.AutoSize = true;
            this.LblNumSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSocial.Location = new System.Drawing.Point(63, 342);
            this.LblNumSegSocial.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblNumSegSocial.Name = "LblNumSegSocial";
            this.LblNumSegSocial.Size = new System.Drawing.Size(265, 56);
            this.LblNumSegSocial.TabIndex = 60;
            this.LblNumSegSocial.Text = "NÚMERO DE \r\nSEGURIDAD SOCIAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "CÉDULA:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(75, 286);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(160, 28);
            this.LblDireccion.TabIndex = 58;
            this.LblDireccion.Text = "DIRECCÍON:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(107, 180);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 28);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // dateTimePickerFecNac
            // 
            this.dateTimePickerFecNac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecNac.Location = new System.Drawing.Point(415, 226);
            this.dateTimePickerFecNac.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            this.dateTimePickerFecNac.Size = new System.Drawing.Size(416, 31);
            this.dateTimePickerFecNac.TabIndex = 66;
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(63, 230);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(306, 28);
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
            this.GbxTipo.Location = new System.Drawing.Point(48, 482);
            this.GbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.GbxTipo.Name = "GbxTipo";
            this.GbxTipo.Padding = new System.Windows.Forms.Padding(4);
            this.GbxTipo.Size = new System.Drawing.Size(531, 156);
            this.GbxTipo.TabIndex = 67;
            this.GbxTipo.TabStop = false;
            this.GbxTipo.Text = "TIPO DE MÉDICO";
            // 
            // radioButtonSustituto
            // 
            this.radioButtonSustituto.AutoSize = true;
            this.radioButtonSustituto.Location = new System.Drawing.Point(153, 107);
            this.radioButtonSustituto.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSustituto.Name = "radioButtonSustituto";
            this.radioButtonSustituto.Size = new System.Drawing.Size(225, 32);
            this.radioButtonSustituto.TabIndex = 0;
            this.radioButtonSustituto.TabStop = true;
            this.radioButtonSustituto.Text = "Médico Sustituto";
            this.radioButtonSustituto.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitular
            // 
            this.radioButtonTitular.AutoSize = true;
            this.radioButtonTitular.Location = new System.Drawing.Point(32, 53);
            this.radioButtonTitular.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTitular.Name = "radioButtonTitular";
            this.radioButtonTitular.Size = new System.Drawing.Size(199, 32);
            this.radioButtonTitular.TabIndex = 0;
            this.radioButtonTitular.TabStop = true;
            this.radioButtonTitular.Text = "Médico Titular";
            this.radioButtonTitular.UseVisualStyleBackColor = true;
            // 
            // radioButtonInterino
            // 
            this.radioButtonInterino.AutoSize = true;
            this.radioButtonInterino.Location = new System.Drawing.Point(288, 53);
            this.radioButtonInterino.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonInterino.Name = "radioButtonInterino";
            this.radioButtonInterino.Size = new System.Drawing.Size(213, 32);
            this.radioButtonInterino.TabIndex = 0;
            this.radioButtonInterino.TabStop = true;
            this.radioButtonInterino.Text = "Médico Interino";
            this.radioButtonInterino.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFecAlta
            // 
            this.dateTimePickerFecAlta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecAlta.Location = new System.Drawing.Point(643, 526);
            this.dateTimePickerFecAlta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFecAlta.Name = "dateTimePickerFecAlta";
            this.dateTimePickerFecAlta.Size = new System.Drawing.Size(416, 31);
            this.dateTimePickerFecAlta.TabIndex = 66;
            // 
            // dateTimePickerFecBaja
            // 
            this.dateTimePickerFecBaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecBaja.Location = new System.Drawing.Point(643, 607);
            this.dateTimePickerFecBaja.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFecBaja.Name = "dateTimePickerFecBaja";
            this.dateTimePickerFecBaja.Size = new System.Drawing.Size(416, 31);
            this.dateTimePickerFecBaja.TabIndex = 66;
            // 
            // LblFechaAlta
            // 
            this.LblFechaAlta.AutoSize = true;
            this.LblFechaAlta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAlta.Location = new System.Drawing.Point(639, 481);
            this.LblFechaAlta.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaAlta.Name = "LblFechaAlta";
            this.LblFechaAlta.Size = new System.Drawing.Size(212, 28);
            this.LblFechaAlta.TabIndex = 58;
            this.LblFechaAlta.Text = "FECHA DE ALTA:";
            // 
            // LblFechaBaja
            // 
            this.LblFechaBaja.AutoSize = true;
            this.LblFechaBaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaBaja.Location = new System.Drawing.Point(637, 569);
            this.LblFechaBaja.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaBaja.Name = "LblFechaBaja";
            this.LblFechaBaja.Size = new System.Drawing.Size(214, 28);
            this.LblFechaBaja.TabIndex = 58;
            this.LblFechaBaja.Text = "FECHA DE BAJA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 69;
            this.label5.Text = "POBLACIÓN:";
            // 
            // CmbPoblacionModificar
            // 
            this.CmbPoblacionModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbPoblacionModificar.FormattingEnabled = true;
            this.CmbPoblacionModificar.Location = new System.Drawing.Point(815, 418);
            this.CmbPoblacionModificar.Margin = new System.Windows.Forms.Padding(4);
            this.CmbPoblacionModificar.Name = "CmbPoblacionModificar";
            this.CmbPoblacionModificar.Size = new System.Drawing.Size(244, 37);
            this.CmbPoblacionModificar.TabIndex = 68;
            // 
            // CmbTipoModificar
            // 
            this.CmbTipoModificar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoMedicoBindingSource, "Descripcion", true));
            this.CmbTipoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbTipoModificar.FormattingEnabled = true;
            this.CmbTipoModificar.Location = new System.Drawing.Point(815, 347);
            this.CmbTipoModificar.Margin = new System.Windows.Forms.Padding(4);
            this.CmbTipoModificar.Name = "CmbTipoModificar";
            this.CmbTipoModificar.Size = new System.Drawing.Size(244, 37);
            this.CmbTipoModificar.TabIndex = 71;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(668, 352);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(78, 28);
            this.LblTipo.TabIndex = 70;
            this.LblTipo.Text = "TIPO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblINgresarMEdico);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 96);
            this.panel1.TabIndex = 73;
            // 
            // lblINgresarMEdico
            // 
            this.lblINgresarMEdico.AutoSize = true;
            this.lblINgresarMEdico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINgresarMEdico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblINgresarMEdico.Location = new System.Drawing.Point(389, 33);
            this.lblINgresarMEdico.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblINgresarMEdico.Name = "lblINgresarMEdico";
            this.lblINgresarMEdico.Size = new System.Drawing.Size(335, 38);
            this.lblINgresarMEdico.TabIndex = 1;
            this.lblINgresarMEdico.Text = "INGRESAR MÉDICO";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(580, 668);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(252, 62);
            this.BtnCancelar.TabIndex = 60;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnRegistrar.Location = new System.Drawing.Point(320, 670);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(252, 62);
            this.BtnRegistrar.TabIndex = 59;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // hOSPITALDataSet
            // 
            this.hOSPITALDataSet.DataSetName = "HOSPITALDataSet";
            this.hOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoMedicoBindingSource
            // 
            this.tipoMedicoBindingSource.DataMember = "TipoMedico";
            this.tipoMedicoBindingSource.DataSource = this.hOSPITALDataSet;
            // 
            // tipoMedicoTableAdapter
            // 
            this.tipoMedicoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmIngresoDatosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 784);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CmbTipoModificar);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbPoblacionModificar);
            this.Controls.Add(this.GbxTipo);
            this.Controls.Add(this.dateTimePickerFecBaja);
            this.Controls.Add(this.dateTimePickerFecAlta);
            this.Controls.Add(this.dateTimePickerFecNac);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.txtNombreModificar);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNumSegSocial);
            this.Controls.Add(this.textBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIngresoDatosMedico";
            this.Text = "Ingresar Médico";
            this.Load += new System.EventHandler(this.FrmIngresoDatosMedico_Load);
            this.GbxTipo.ResumeLayout(false);
            this.GbxTipo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMedicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblColegio;
        private System.Windows.Forms.TextBox txtNumColegiado;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNumSegSocial;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.ComboBox CmbPoblacionModificar;
        private System.Windows.Forms.ComboBox CmbTipoModificar;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.RadioButton radioButtonTitular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblINgresarMEdico;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
        private HOSPITALDataSet hOSPITALDataSet;
        private System.Windows.Forms.BindingSource tipoMedicoBindingSource;
        private HOSPITALDataSetTableAdapters.TipoMedicoTableAdapter tipoMedicoTableAdapter;
    }
}