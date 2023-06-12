namespace CapaPresentacion
{
    partial class FrmIngresoDatosEmpleado
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
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.CmbPoblacion = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtNumSegSocial = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIngresarEmpleado = new System.Windows.Forms.Label();
            this.LblNumSegSocial = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblPoblacion = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimePickerFecNac = new System.Windows.Forms.DateTimePicker();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnRegistrar.Location = new System.Drawing.Point(232, 405);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(189, 50);
            this.BtnRegistrar.TabIndex = 20;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click_1);
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(566, 289);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(184, 32);
            this.CmbTipo.TabIndex = 60;
            this.CmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbTipo_KeyPress);
            // 
            // CmbPoblacion
            // 
            this.CmbPoblacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbPoblacion.FormattingEnabled = true;
            this.CmbPoblacion.Location = new System.Drawing.Point(237, 289);
            this.CmbPoblacion.Name = "CmbPoblacion";
            this.CmbPoblacion.Size = new System.Drawing.Size(184, 32);
            this.CmbPoblacion.TabIndex = 61;
            this.CmbPoblacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPoblacion_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(170, 161);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(580, 29);
            this.TxtNombre.TabIndex = 56;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(400, 98);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(183, 29);
            this.TxtCedula.TabIndex = 55;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtNumSegSocial
            // 
            this.TxtNumSegSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumSegSocial.Location = new System.Drawing.Point(300, 349);
            this.TxtNumSegSocial.Name = "TxtNumSegSocial";
            this.TxtNumSegSocial.Size = new System.Drawing.Size(183, 29);
            this.TxtNumSegSocial.TabIndex = 54;
            this.TxtNumSegSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumSegSocial_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(179, 245);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(580, 29);
            this.TxtDireccion.TabIndex = 53;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarEmpleado);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 78);
            this.panel1.TabIndex = 52;
            // 
            // lblIngresarEmpleado
            // 
            this.lblIngresarEmpleado.AutoSize = true;
            this.lblIngresarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresarEmpleado.Location = new System.Drawing.Point(237, 23);
            this.lblIngresarEmpleado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngresarEmpleado.Name = "lblIngresarEmpleado";
            this.lblIngresarEmpleado.Size = new System.Drawing.Size(334, 32);
            this.lblIngresarEmpleado.TabIndex = 1;
            this.lblIngresarEmpleado.Text = "INGRESAR EMPLEADOS";
            // 
            // LblNumSegSocial
            // 
            this.LblNumSegSocial.AutoSize = true;
            this.LblNumSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSocial.Location = new System.Drawing.Point(81, 334);
            this.LblNumSegSocial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNumSegSocial.Name = "LblNumSegSocial";
            this.LblNumSegSocial.Size = new System.Drawing.Size(211, 44);
            this.LblNumSegSocial.TabIndex = 51;
            this.LblNumSegSocial.Text = "NÚMERO DE \r\nSEGURIDAD SOCIAL:";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(296, 105);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(96, 22);
            this.LblCedula.TabIndex = 50;
            this.LblCedula.Text = "CÉDULA:";
            // 
            // LblPoblacion
            // 
            this.LblPoblacion.AutoSize = true;
            this.LblPoblacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoblacion.Location = new System.Drawing.Point(97, 293);
            this.LblPoblacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPoblacion.Name = "LblPoblacion";
            this.LblPoblacion.Size = new System.Drawing.Size(132, 22);
            this.LblPoblacion.TabIndex = 49;
            this.LblPoblacion.Text = "POBLACIÓN:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(463, 293);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(62, 22);
            this.LblTipo.TabIndex = 46;
            this.LblTipo.Text = "TIPO:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(45, 249);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(126, 22);
            this.LblDireccion.TabIndex = 48;
            this.LblDireccion.Text = "DIRECCÍON:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(60, 165);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 22);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(34, 207);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(243, 22);
            this.LblFechaNacimiento.TabIndex = 48;
            this.LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // dateTimePickerFecNac
            // 
            this.dateTimePickerFecNac.Location = new System.Drawing.Point(298, 204);
            this.dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            this.dateTimePickerFecNac.Size = new System.Drawing.Size(313, 26);
            this.dateTimePickerFecNac.TabIndex = 62;
            this.dateTimePickerFecNac.ValueChanged += new System.EventHandler(this.dateTimePickerFecNac_ValueChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(427, 404);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(189, 50);
            this.BtnCancelar.TabIndex = 58;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmIngresoDatosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(834, 478);
            this.Controls.Add(this.dateTimePickerFecNac);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.CmbPoblacion);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNumSegSocial);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblNumSegSocial);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.LblPoblacion);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.BtnRegistrar);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmIngresoDatosEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Empleado";
            this.Load += new System.EventHandler(this.FrmIngresoDatosEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.ComboBox CmbPoblacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNumSegSocial;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngresarEmpleado;
        private System.Windows.Forms.Label LblNumSegSocial;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblPoblacion;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecNac;
        private System.Windows.Forms.Button BtnCancelar;
    }
}