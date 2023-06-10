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
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnIngresarM = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSeguridadSocial = new System.Windows.Forms.Label();
            this.lblColegio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtSeguridadSocial = new System.Windows.Forms.TextBox();
            this.txtNumColegiado = new System.Windows.Forms.TextBox();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoMed = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(69, 83);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(57, 13);
            this.lblNombreM.TabIndex = 0;
            this.lblNombreM.Text = "NOMBRE:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(69, 145);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(69, 13);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "DIRECCION ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(235, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(235, 142);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(146, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // btnIngresarM
            // 
            this.btnIngresarM.Location = new System.Drawing.Point(702, 428);
            this.btnIngresarM.Name = "btnIngresarM";
            this.btnIngresarM.Size = new System.Drawing.Size(99, 40);
            this.btnIngresarM.TabIndex = 4;
            this.btnIngresarM.Text = "REGISTRAR";
            this.btnIngresarM.UseVisualStyleBackColor = true;
            this.btnIngresarM.Click += new System.EventHandler(this.btnIngresarM_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(69, 208);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.Location = new System.Drawing.Point(74, 271);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(68, 13);
            this.lblPoblacion.TabIndex = 6;
            this.lblPoblacion.Text = "POBLACION";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(74, 331);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(65, 13);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "PROVINCIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CODIGO POSTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NIF";
            // 
            // lblSeguridadSocial
            // 
            this.lblSeguridadSocial.AutoSize = true;
            this.lblSeguridadSocial.Location = new System.Drawing.Point(471, 142);
            this.lblSeguridadSocial.Name = "lblSeguridadSocial";
            this.lblSeguridadSocial.Size = new System.Drawing.Size(197, 13);
            this.lblSeguridadSocial.TabIndex = 10;
            this.lblSeguridadSocial.Text = "NUMERO DE LA SEGURIDAD SOCIAL";
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Location = new System.Drawing.Point(471, 201);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(141, 13);
            this.lblColegio.TabIndex = 11;
            this.lblColegio.Text = "NÚMERO DE COLEGIADO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "TIPO DE MEDICO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(235, 201);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(146, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(235, 268);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(146, 20);
            this.txtPoblacion.TabIndex = 14;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(702, 18);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoPostal.TabIndex = 16;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(702, 76);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(121, 20);
            this.txtNIF.TabIndex = 17;
            this.txtNIF.TextChanged += new System.EventHandler(this.txtNIF_TextChanged);
            // 
            // txtSeguridadSocial
            // 
            this.txtSeguridadSocial.Location = new System.Drawing.Point(702, 131);
            this.txtSeguridadSocial.Name = "txtSeguridadSocial";
            this.txtSeguridadSocial.Size = new System.Drawing.Size(121, 20);
            this.txtSeguridadSocial.TabIndex = 18;
            // 
            // txtNumColegiado
            // 
            this.txtNumColegiado.Location = new System.Drawing.Point(702, 197);
            this.txtNumColegiado.Name = "txtNumColegiado";
            this.txtNumColegiado.Size = new System.Drawing.Size(121, 20);
            this.txtNumColegiado.TabIndex = 19;
            // 
            // comboBoxProvincia
            // 
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
            this.comboBoxProvincia.Location = new System.Drawing.Point(235, 331);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(146, 21);
            this.comboBoxProvincia.TabIndex = 20;
            // 
            // comboBoxTipoMed
            // 
            this.comboBoxTipoMed.FormattingEnabled = true;
            this.comboBoxTipoMed.Items.AddRange(new object[] {
            "Medico titular",
            "Medico interino",
            "Medico sustituto"});
            this.comboBoxTipoMed.Location = new System.Drawing.Point(702, 264);
            this.comboBoxTipoMed.Name = "comboBoxTipoMed";
            this.comboBoxTipoMed.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoMed.TabIndex = 21;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(69, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID MEDICO";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(235, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 20);
            this.txtID.TabIndex = 23;
            // 
            // FrmIngresoDatosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 553);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.comboBoxTipoMed);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.txtNumColegiado);
            this.Controls.Add(this.txtSeguridadSocial);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblColegio);
            this.Controls.Add(this.lblSeguridadSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnIngresarM);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombreM);
            this.Name = "FrmIngresoDatosMedico";
            this.Text = "FrmIngresoDatosMedico";
            this.Load += new System.EventHandler(this.FrmIngresoDatosMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnIngresarM;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSeguridadSocial;
        private System.Windows.Forms.Label lblColegio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtSeguridadSocial;
        private System.Windows.Forms.TextBox txtNumColegiado;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.ComboBox comboBoxTipoMed;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}