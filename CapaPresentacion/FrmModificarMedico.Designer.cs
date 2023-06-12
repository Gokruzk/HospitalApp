namespace CapaPresentacion
{
    partial class FrmModificarMedico
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
            this.lblModificarMedico = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.CmbTipoModificar = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblPoblacion = new System.Windows.Forms.Label();
            this.CmbPoblacionModificar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerFecBaja = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecAlta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecNac = new System.Windows.Forms.DateTimePicker();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.TxtNumSegSocial = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.LblNumSegSocial = new System.Windows.Forms.Label();
            this.LblFechaBaja = new System.Windows.Forms.Label();
            this.LblFechaAlta = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.txtNumColegiado = new System.Windows.Forms.TextBox();
            this.lblColegio = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbHabDes = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbCampo = new System.Windows.Forms.ComboBox();
            this.TxtEleccion = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GbxFechas = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.GbxFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModificarMedico
            // 
            this.lblModificarMedico.AutoSize = true;
            this.lblModificarMedico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarMedico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModificarMedico.Location = new System.Drawing.Point(292, 27);
            this.lblModificarMedico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModificarMedico.Name = "lblModificarMedico";
            this.lblModificarMedico.Size = new System.Drawing.Size(283, 32);
            this.lblModificarMedico.TabIndex = 1;
            this.lblModificarMedico.Text = "MODIFICAR MÉDICO";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnModificar.Location = new System.Drawing.Point(233, 490);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(189, 50);
            this.BtnModificar.TabIndex = 97;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // CmbTipoModificar
            // 
            this.CmbTipoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbTipoModificar.FormattingEnabled = true;
            this.CmbTipoModificar.Location = new System.Drawing.Point(567, 265);
            this.CmbTipoModificar.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTipoModificar.Name = "CmbTipoModificar";
            this.CmbTipoModificar.Size = new System.Drawing.Size(184, 32);
            this.CmbTipoModificar.TabIndex = 96;
            this.CmbTipoModificar.SelectionChangeCommitted += new System.EventHandler(this.CmbTipoModificar_SelectionChangeCommitted);
            this.CmbTipoModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbTipoModificar_KeyPress);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(475, 269);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(62, 22);
            this.LblTipo.TabIndex = 95;
            this.LblTipo.Text = "TIPO:";
            // 
            // LblPoblacion
            // 
            this.LblPoblacion.AutoSize = true;
            this.LblPoblacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoblacion.Location = new System.Drawing.Point(54, 275);
            this.LblPoblacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPoblacion.Name = "LblPoblacion";
            this.LblPoblacion.Size = new System.Drawing.Size(132, 22);
            this.LblPoblacion.TabIndex = 94;
            this.LblPoblacion.Text = "POBLACIÓN:";
            // 
            // CmbPoblacionModificar
            // 
            this.CmbPoblacionModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbPoblacionModificar.FormattingEnabled = true;
            this.CmbPoblacionModificar.Location = new System.Drawing.Point(216, 269);
            this.CmbPoblacionModificar.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPoblacionModificar.Name = "CmbPoblacionModificar";
            this.CmbPoblacionModificar.Size = new System.Drawing.Size(184, 32);
            this.CmbPoblacionModificar.TabIndex = 93;
            this.CmbPoblacionModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPoblacionModificar_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblModificarMedico);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 78);
            this.panel1.TabIndex = 98;
            // 
            // dateTimePickerFecBaja
            // 
            this.dateTimePickerFecBaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecBaja.Location = new System.Drawing.Point(36, 111);
            this.dateTimePickerFecBaja.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFecBaja.Name = "dateTimePickerFecBaja";
            this.dateTimePickerFecBaja.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecBaja.TabIndex = 91;
            this.dateTimePickerFecBaja.CloseUp += new System.EventHandler(this.dateTimePickerFecBaja_CloseUp);
            this.dateTimePickerFecBaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecBaja_KeyPress);
            // 
            // dateTimePickerFecAlta
            // 
            this.dateTimePickerFecAlta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecAlta.Location = new System.Drawing.Point(36, 58);
            this.dateTimePickerFecAlta.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFecAlta.Name = "dateTimePickerFecAlta";
            this.dateTimePickerFecAlta.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecAlta.TabIndex = 90;
            this.dateTimePickerFecAlta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecAlta_KeyPress);
            // 
            // dateTimePickerFecNac
            // 
            this.dateTimePickerFecNac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecNac.Location = new System.Drawing.Point(311, 184);
            this.dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            this.dateTimePickerFecNac.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecNac.TabIndex = 89;
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
            this.LblFechaNacimiento.TabIndex = 88;
            this.LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreModificar.Location = new System.Drawing.Point(190, 142);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(580, 29);
            this.txtNombreModificar.TabIndex = 87;
            this.txtNombreModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreModificar_KeyPress);
            // 
            // TxtNumSegSocial
            // 
            this.TxtNumSegSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSegSocial.Location = new System.Drawing.Point(268, 317);
            this.TxtNumSegSocial.Name = "TxtNumSegSocial";
            this.TxtNumSegSocial.Size = new System.Drawing.Size(183, 29);
            this.TxtNumSegSocial.TabIndex = 85;
            this.TxtNumSegSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumSegSocial_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(190, 228);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(580, 29);
            this.txtDireccion.TabIndex = 84;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // LblNumSegSocial
            // 
            this.LblNumSegSocial.AutoSize = true;
            this.LblNumSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSocial.Location = new System.Drawing.Point(49, 313);
            this.LblNumSegSocial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNumSegSocial.Name = "LblNumSegSocial";
            this.LblNumSegSocial.Size = new System.Drawing.Size(211, 44);
            this.LblNumSegSocial.TabIndex = 83;
            this.LblNumSegSocial.Text = "NÚMERO DE \r\nSEGURIDAD SOCIAL:";
            // 
            // LblFechaBaja
            // 
            this.LblFechaBaja.AutoSize = true;
            this.LblFechaBaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaBaja.Location = new System.Drawing.Point(33, 86);
            this.LblFechaBaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFechaBaja.Name = "LblFechaBaja";
            this.LblFechaBaja.Size = new System.Drawing.Size(172, 22);
            this.LblFechaBaja.TabIndex = 81;
            this.LblFechaBaja.Text = "FECHA DE BAJA:";
            // 
            // LblFechaAlta
            // 
            this.LblFechaAlta.AutoSize = true;
            this.LblFechaAlta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAlta.Location = new System.Drawing.Point(34, 29);
            this.LblFechaAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFechaAlta.Name = "LblFechaAlta";
            this.LblFechaAlta.Size = new System.Drawing.Size(170, 22);
            this.LblFechaAlta.TabIndex = 80;
            this.LblFechaAlta.Text = "FECHA DE ALTA:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(56, 232);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(126, 22);
            this.LblDireccion.TabIndex = 79;
            this.LblDireccion.Text = "DIRECCIÓN:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(80, 146);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 22);
            this.lblNombre.TabIndex = 78;
            this.lblNombre.Text = "NOMBRE:";
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
            this.comboBoxProvincia.TabIndex = 77;
            // 
            // txtNumColegiado
            // 
            this.txtNumColegiado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txtNumColegiado.Location = new System.Drawing.Point(301, 376);
            this.txtNumColegiado.Name = "txtNumColegiado";
            this.txtNumColegiado.Size = new System.Drawing.Size(150, 29);
            this.txtNumColegiado.TabIndex = 76;
            this.txtNumColegiado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumColegiado_KeyPress);
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblColegio.Location = new System.Drawing.Point(34, 379);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(261, 22);
            this.lblColegio.TabIndex = 75;
            this.lblColegio.Text = "NÚMERO DE COLEGIADO: ";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(101, 889);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(77, 16);
            this.lblProvincia.TabIndex = 74;
            this.lblProvincia.Text = "PROVINCIA";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(479, 490);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(189, 50);
            this.BtnCancelar.TabIndex = 97;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CmbHabDes
            // 
            this.CmbHabDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbHabDes.FormattingEnabled = true;
            this.CmbHabDes.Items.AddRange(new object[] {
            "Habilitado",
            "No habilitado"});
            this.CmbHabDes.Location = new System.Drawing.Point(238, 418);
            this.CmbHabDes.Margin = new System.Windows.Forms.Padding(2);
            this.CmbHabDes.Name = "CmbHabDes";
            this.CmbHabDes.Size = new System.Drawing.Size(184, 32);
            this.CmbHabDes.TabIndex = 93;
            this.CmbHabDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbHabDes_KeyPress);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(125, 422);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.CmbCampo.Location = new System.Drawing.Point(174, 95);
            this.CmbCampo.Name = "CmbCampo";
            this.CmbCampo.Size = new System.Drawing.Size(226, 32);
            this.CmbCampo.TabIndex = 107;
            this.CmbCampo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbCampo_KeyPress);
            // 
            // TxtEleccion
            // 
            this.TxtEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEleccion.Location = new System.Drawing.Point(429, 95);
            this.TxtEleccion.Name = "TxtEleccion";
            this.TxtEleccion.Size = new System.Drawing.Size(183, 29);
            this.TxtEleccion.TabIndex = 105;
            this.TxtEleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEleccion_KeyPress);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(63, 102);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(88, 22);
            this.LblCedula.TabIndex = 104;
            this.LblCedula.Text = "CAMPO:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(644, 90);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(189, 39);
            this.BtnBuscar.TabIndex = 106;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GbxFechas
            // 
            this.GbxFechas.Controls.Add(this.dateTimePickerFecBaja);
            this.GbxFechas.Controls.Add(this.LblFechaAlta);
            this.GbxFechas.Controls.Add(this.LblFechaBaja);
            this.GbxFechas.Controls.Add(this.dateTimePickerFecAlta);
            this.GbxFechas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.GbxFechas.Location = new System.Drawing.Point(479, 304);
            this.GbxFechas.Name = "GbxFechas";
            this.GbxFechas.Size = new System.Drawing.Size(388, 168);
            this.GbxFechas.TabIndex = 108;
            this.GbxFechas.TabStop = false;
            this.GbxFechas.Text = "FECHAS";
            // 
            // FrmModificarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(881, 561);
            this.Controls.Add(this.GbxFechas);
            this.Controls.Add(this.CmbCampo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtEleccion);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.CmbTipoModificar);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblPoblacion);
            this.Controls.Add(this.CmbHabDes);
            this.Controls.Add(this.CmbPoblacionModificar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerFecNac);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.txtNombreModificar);
            this.Controls.Add(this.TxtNumSegSocial);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.LblNumSegSocial);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.txtNumColegiado);
            this.Controls.Add(this.lblColegio);
            this.Controls.Add(this.lblProvincia);
            this.MaximizeBox = false;
            this.Name = "FrmModificarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Médico";
            this.Load += new System.EventHandler(this.FrmModificarMedico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbxFechas.ResumeLayout(false);
            this.GbxFechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificarMedico;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.ComboBox CmbTipoModificar;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblPoblacion;
        private System.Windows.Forms.ComboBox CmbPoblacionModificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecBaja;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecAlta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecNac;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.TextBox TxtNumSegSocial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label LblNumSegSocial;
        private System.Windows.Forms.Label LblFechaBaja;
        private System.Windows.Forms.Label LblFechaAlta;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.TextBox txtNumColegiado;
        private System.Windows.Forms.Label lblColegio;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CmbHabDes;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbCampo;
        private System.Windows.Forms.TextBox TxtEleccion;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GbxFechas;
    }
}