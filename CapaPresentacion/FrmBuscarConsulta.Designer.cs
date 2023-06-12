namespace CapaPresentacion
{
    partial class FrmBuscarConsulta
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtEleccion = new System.Windows.Forms.TextBox();
            this.LblCampo = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblMedico = new System.Windows.Forms.Label();
            this.LblPaciente = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.lblIngresarEmpleado.Size = new System.Drawing.Size(290, 32);
            this.lblIngresarEmpleado.TabIndex = 1;
            this.lblIngresarEmpleado.Text = "BUSCAR CONSULTA";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(549, 95);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(189, 39);
            this.BtnBuscar.TabIndex = 128;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtEleccion
            // 
            this.TxtEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEleccion.Location = new System.Drawing.Point(334, 99);
            this.TxtEleccion.Name = "TxtEleccion";
            this.TxtEleccion.Size = new System.Drawing.Size(183, 29);
            this.TxtEleccion.TabIndex = 127;
            this.TxtEleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEleccion_KeyPress);
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(178, 104);
            this.LblCampo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(148, 22);
            this.LblCampo.TabIndex = 126;
            this.LblCampo.Text = "ID CONSULTA:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(75, 236);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(437, 22);
            this.LblFecha.TabIndex = 118;
            this.LblFecha.Text = "FECHA: ___________________________________";
            // 
            // LblMedico
            // 
            this.LblMedico.AutoSize = true;
            this.LblMedico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedico.Location = new System.Drawing.Point(75, 194);
            this.LblMedico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMedico.Name = "LblMedico";
            this.LblMedico.Size = new System.Drawing.Size(729, 22);
            this.LblMedico.TabIndex = 119;
            this.LblMedico.Text = "MÉDICO ASIGNADO: ____________________________________________________";
            // 
            // LblPaciente
            // 
            this.LblPaciente.AutoSize = true;
            this.LblPaciente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaciente.Location = new System.Drawing.Point(75, 155);
            this.LblPaciente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPaciente.Name = "LblPaciente";
            this.LblPaciente.Size = new System.Drawing.Size(640, 22);
            this.LblPaciente.TabIndex = 120;
            this.LblPaciente.Text = "PACIENTE: ____________________________________________________";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(246, 309);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(322, 145);
            this.TxtDescripcion.TabIndex = 117;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(244, 275);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(326, 22);
            this.LblDescripcion.TabIndex = 116;
            this.LblDescripcion.Text = "DESCRIPCIÓN DE LA CONSULTA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarEmpleado);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 78);
            this.panel1.TabIndex = 115;
            // 
            // FrmBuscarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(831, 476);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtEleccion);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblMedico);
            this.Controls.Add(this.LblPaciente);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBuscarConsulta";
            this.Text = "FrmBuscarConsulta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarEmpleado;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtEleccion;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.Label LblPaciente;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Panel panel1;
    }
}