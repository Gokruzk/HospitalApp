namespace CapaPresentacion
{
    partial class FrmIngresarConsulta
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
            this.lblIngresarEmpleado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.CmbPaciente = new System.Windows.Forms.ComboBox();
            this.LblPoblacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbMedicoAsignado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresarEmpleado
            // 
            this.lblIngresarEmpleado.AutoSize = true;
            this.lblIngresarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresarEmpleado.Location = new System.Drawing.Point(316, 28);
            this.lblIngresarEmpleado.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIngresarEmpleado.Name = "lblIngresarEmpleado";
            this.lblIngresarEmpleado.Size = new System.Drawing.Size(389, 38);
            this.lblIngresarEmpleado.TabIndex = 1;
            this.lblIngresarEmpleado.Text = "INGRESAR CONSULTA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarEmpleado);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 96);
            this.panel1.TabIndex = 53;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(312, 311);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(428, 178);
            this.TxtDescripcion.TabIndex = 58;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(309, 270);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(410, 28);
            this.LblDescripcion.TabIndex = 57;
            this.LblDescripcion.Text = "DESCRIPCIÓN DE LA CONSULTA:";
            // 
            // CmbPaciente
            // 
            this.CmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbPaciente.FormattingEnabled = true;
            this.CmbPaciente.Location = new System.Drawing.Point(271, 117);
            this.CmbPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbPaciente.Name = "CmbPaciente";
            this.CmbPaciente.Size = new System.Drawing.Size(568, 37);
            this.CmbPaciente.TabIndex = 63;
            this.CmbPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPaciente_KeyPress);
            // 
            // LblPoblacion
            // 
            this.LblPoblacion.AutoSize = true;
            this.LblPoblacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoblacion.Location = new System.Drawing.Point(84, 122);
            this.LblPoblacion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblPoblacion.Name = "LblPoblacion";
            this.LblPoblacion.Size = new System.Drawing.Size(144, 28);
            this.LblPoblacion.TabIndex = 62;
            this.LblPoblacion.Text = "PACIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 62;
            this.label1.Text = "MÉÐICO ASIGNADO:";
            // 
            // CmbMedicoAsignado
            // 
            this.CmbMedicoAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMedicoAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbMedicoAsignado.FormattingEnabled = true;
            this.CmbMedicoAsignado.Location = new System.Drawing.Point(367, 164);
            this.CmbMedicoAsignado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbMedicoAsignado.Name = "CmbMedicoAsignado";
            this.CmbMedicoAsignado.Size = new System.Drawing.Size(568, 37);
            this.CmbMedicoAsignado.TabIndex = 63;
            this.CmbMedicoAsignado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbMedicoAsignado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 62;
            this.label2.Text = "FECHA:";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.dateTimePickerFecha.Location = new System.Drawing.Point(204, 215);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(483, 35);
            this.dateTimePickerFecha.TabIndex = 64;
            this.dateTimePickerFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerFecha_KeyPress);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(528, 510);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(252, 62);
            this.BtnCancelar.TabIndex = 66;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnRegistrar.Location = new System.Drawing.Point(268, 510);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(252, 62);
            this.BtnRegistrar.TabIndex = 65;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // FrmIngresarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1108, 599);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.CmbMedicoAsignado);
            this.Controls.Add(this.CmbPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPoblacion);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIngresarConsulta";
            this.Text = "Ingresar Consulta";
            this.Load += new System.EventHandler(this.FrmIngresarConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.ComboBox CmbPaciente;
        private System.Windows.Forms.Label LblPoblacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbMedicoAsignado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}