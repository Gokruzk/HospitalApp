namespace CapaPresentacion
{
    partial class FrmModificarEmpleado
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtNumSegSocialModificar = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblModificarEmpleado = new System.Windows.Forms.Label();
            this.LblNumSegSocial = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbPoblacionModificar = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.LblPoblacion = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dateTimePickerFecNac = new System.Windows.Forms.DateTimePicker();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.CmbHabilDeshabil = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbCampo = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtEleccion = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnModificar.Location = new System.Drawing.Point(281, 572);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(252, 62);
            this.BtnModificar.TabIndex = 40;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(224, 199);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(772, 34);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // TxtNumSegSocialModificar
            // 
            this.TxtNumSegSocialModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSegSocialModificar.Location = new System.Drawing.Point(372, 416);
            this.TxtNumSegSocialModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNumSegSocialModificar.Name = "TxtNumSegSocialModificar";
            this.TxtNumSegSocialModificar.Size = new System.Drawing.Size(243, 34);
            this.TxtNumSegSocialModificar.TabIndex = 34;
            this.TxtNumSegSocialModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumSegSocialModificar_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(224, 299);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(772, 34);
            this.TxtDireccion.TabIndex = 33;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblModificarEmpleado);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 96);
            this.panel1.TabIndex = 31;
            // 
            // lblModificarEmpleado
            // 
            this.lblModificarEmpleado.AutoSize = true;
            this.lblModificarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModificarEmpleado.Location = new System.Drawing.Point(329, 28);
            this.lblModificarEmpleado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblModificarEmpleado.Name = "lblModificarEmpleado";
            this.lblModificarEmpleado.Size = new System.Drawing.Size(423, 38);
            this.lblModificarEmpleado.TabIndex = 1;
            this.lblModificarEmpleado.Text = "MODIFICAR EMPLEADOS";
            // 
            // LblNumSegSocial
            // 
            this.LblNumSegSocial.AutoSize = true;
            this.LblNumSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSocial.Location = new System.Drawing.Point(80, 410);
            this.LblNumSegSocial.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblNumSegSocial.Name = "LblNumSegSocial";
            this.LblNumSegSocial.Size = new System.Drawing.Size(265, 56);
            this.LblNumSegSocial.TabIndex = 30;
            this.LblNumSegSocial.Text = "NÚMERO DE \r\nSEGURIDAD SOCIAL:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(569, 572);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(252, 62);
            this.BtnCancelar.TabIndex = 42;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CmbPoblacionModificar
            // 
            this.CmbPoblacionModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbPoblacionModificar.FormattingEnabled = true;
            this.CmbPoblacionModificar.Location = new System.Drawing.Point(259, 352);
            this.CmbPoblacionModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbPoblacionModificar.Name = "CmbPoblacionModificar";
            this.CmbPoblacionModificar.Size = new System.Drawing.Size(244, 37);
            this.CmbPoblacionModificar.TabIndex = 45;
            this.CmbPoblacionModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPoblacionModificar_KeyPress);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(547, 357);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(78, 28);
            this.LblTipo.TabIndex = 23;
            this.LblTipo.Text = "TIPO:";
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(693, 352);
            this.CmbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(244, 37);
            this.CmbTipo.TabIndex = 45;
            this.CmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbTipo_KeyPress);
            // 
            // LblPoblacion
            // 
            this.LblPoblacion.AutoSize = true;
            this.LblPoblacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoblacion.Location = new System.Drawing.Point(72, 357);
            this.LblPoblacion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPoblacion.Name = "LblPoblacion";
            this.LblPoblacion.Size = new System.Drawing.Size(166, 28);
            this.LblPoblacion.TabIndex = 52;
            this.LblPoblacion.Text = "POBLACIÓN:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(45, 304);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(160, 28);
            this.LblDireccion.TabIndex = 51;
            this.LblDireccion.Text = "DIRECCÍON:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(77, 204);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 28);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // dateTimePickerFecNac
            // 
            this.dateTimePickerFecNac.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFecNac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.dateTimePickerFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecNac.Location = new System.Drawing.Point(424, 251);
            this.dateTimePickerFecNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            this.dateTimePickerFecNac.Size = new System.Drawing.Size(416, 31);
            this.dateTimePickerFecNac.TabIndex = 68;
            this.dateTimePickerFecNac.ValueChanged += new System.EventHandler(this.dateTimePickerFecNac_ValueChanged);
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(72, 255);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(306, 28);
            this.LblFechaNacimiento.TabIndex = 67;
            this.LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // CmbHabilDeshabil
            // 
            this.CmbHabilDeshabil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHabilDeshabil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbHabilDeshabil.FormattingEnabled = true;
            this.CmbHabilDeshabil.Items.AddRange(new object[] {
            "Habilitado",
            "No habilitado"});
            this.CmbHabilDeshabil.Location = new System.Drawing.Point(424, 486);
            this.CmbHabilDeshabil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbHabilDeshabil.Name = "CmbHabilDeshabil";
            this.CmbHabilDeshabil.Size = new System.Drawing.Size(244, 37);
            this.CmbHabilDeshabil.TabIndex = 45;
            this.CmbHabilDeshabil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbHabilDeshabil_KeyPress);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(284, 491);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(121, 28);
            this.LblEstado.TabIndex = 102;
            this.LblEstado.Text = "ESTADO:";
            // 
            // CmbCampo
            // 
            this.CmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbCampo.FormattingEnabled = true;
            this.CmbCampo.Items.AddRange(new object[] {
            "CÉDULA",
            "NUM. SEGURIDAD SOCIAL"});
            this.CmbCampo.Location = new System.Drawing.Point(191, 124);
            this.CmbCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbCampo.Name = "CmbCampo";
            this.CmbCampo.Size = new System.Drawing.Size(300, 37);
            this.CmbCampo.TabIndex = 111;
            this.CmbCampo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbCampo_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(817, 118);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(252, 48);
            this.BtnBuscar.TabIndex = 110;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtEleccion
            // 
            this.TxtEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEleccion.Location = new System.Drawing.Point(531, 124);
            this.TxtEleccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEleccion.Name = "TxtEleccion";
            this.TxtEleccion.Size = new System.Drawing.Size(243, 34);
            this.TxtEleccion.TabIndex = 109;
            this.TxtEleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEleccion_KeyPress);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(43, 133);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(110, 28);
            this.LblCedula.TabIndex = 108;
            this.LblCedula.Text = "CAMPO:";
            // 
            // FrmModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1107, 693);
            this.Controls.Add(this.CmbCampo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtEleccion);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.dateTimePickerFecNac);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblPoblacion);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.CmbHabilDeshabil);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.CmbPoblacionModificar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.TxtNumSegSocialModificar);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblNumSegSocial);
            this.Controls.Add(this.LblTipo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmModificarEmpleado";
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.FrmModificarEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox TxtNumSegSocialModificar;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblModificarEmpleado;
        private System.Windows.Forms.Label LblNumSegSocial;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CmbPoblacionModificar;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label LblPoblacion;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecNac;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.ComboBox CmbHabilDeshabil;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbCampo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtEleccion;
        private System.Windows.Forms.Label LblCedula;
    }
}