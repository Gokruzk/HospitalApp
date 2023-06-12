namespace CapaPresentacion
{
    partial class FrmModificarConsulta
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.CmbMedicoAsignado = new System.Windows.Forms.ComboBox();
            this.CmbPaciente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPoblacion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtEleccion = new System.Windows.Forms.TextBox();
            this.LblCampo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresarEmpleado
            // 
            this.lblIngresarEmpleado.AutoSize = true;
            this.lblIngresarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresarEmpleado.Location = new System.Drawing.Point(237, 23);
            this.lblIngresarEmpleado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngresarEmpleado.Name = "lblIngresarEmpleado";
            this.lblIngresarEmpleado.Size = new System.Drawing.Size(327, 32);
            this.lblIngresarEmpleado.TabIndex = 1;
            this.lblIngresarEmpleado.Text = "MODIFICAR CONSULTA";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(410, 470);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(189, 50);
            this.BtnCancelar.TabIndex = 77;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnModificar.Location = new System.Drawing.Point(215, 470);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(189, 50);
            this.BtnModificar.TabIndex = 76;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.dateTimePickerFecha.Location = new System.Drawing.Point(167, 231);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(363, 29);
            this.dateTimePickerFecha.TabIndex = 75;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // CmbMedicoAsignado
            // 
            this.CmbMedicoAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbMedicoAsignado.FormattingEnabled = true;
            this.CmbMedicoAsignado.Location = new System.Drawing.Point(289, 189);
            this.CmbMedicoAsignado.Name = "CmbMedicoAsignado";
            this.CmbMedicoAsignado.Size = new System.Drawing.Size(427, 32);
            this.CmbMedicoAsignado.TabIndex = 73;
            this.CmbMedicoAsignado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbMedicoAsignado_KeyPress);
            // 
            // CmbPaciente
            // 
            this.CmbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbPaciente.FormattingEnabled = true;
            this.CmbPaciente.Location = new System.Drawing.Point(217, 151);
            this.CmbPaciente.Name = "CmbPaciente";
            this.CmbPaciente.Size = new System.Drawing.Size(427, 32);
            this.CmbPaciente.TabIndex = 74;
            this.CmbPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPaciente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 70;
            this.label2.Text = "FECHA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 71;
            this.label1.Text = "MÉÐICO ASIGNADO:";
            // 
            // LblPoblacion
            // 
            this.LblPoblacion.AutoSize = true;
            this.LblPoblacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoblacion.Location = new System.Drawing.Point(77, 155);
            this.LblPoblacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPoblacion.Name = "LblPoblacion";
            this.LblPoblacion.Size = new System.Drawing.Size(115, 22);
            this.LblPoblacion.TabIndex = 72;
            this.LblPoblacion.Text = "PACIENTE:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(248, 309);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(322, 145);
            this.TxtDescripcion.TabIndex = 69;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(246, 275);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(326, 22);
            this.LblDescripcion.TabIndex = 68;
            this.LblDescripcion.Text = "DESCRIPCIÓN DE LA CONSULTA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarEmpleado);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 78);
            this.panel1.TabIndex = 67;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(551, 95);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(189, 39);
            this.BtnBuscar.TabIndex = 114;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtEleccion
            // 
            this.TxtEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEleccion.Location = new System.Drawing.Point(336, 99);
            this.TxtEleccion.Name = "TxtEleccion";
            this.TxtEleccion.Size = new System.Drawing.Size(183, 29);
            this.TxtEleccion.TabIndex = 113;
            this.TxtEleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEleccion_KeyPress);
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(180, 104);
            this.LblCampo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(148, 22);
            this.LblCampo.TabIndex = 112;
            this.LblCampo.Text = "ID CONSULTA:";
            // 
            // FrmModificarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(832, 558);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtEleccion);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.CmbMedicoAsignado);
            this.Controls.Add(this.CmbPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPoblacion);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmModificarConsulta";
            this.Text = "Modificar Consulta";
            this.Load += new System.EventHandler(this.FrmModificarConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarEmpleado;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.ComboBox CmbMedicoAsignado;
        private System.Windows.Forms.ComboBox CmbPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPoblacion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtEleccion;
        private System.Windows.Forms.Label LblCampo;
    }
}