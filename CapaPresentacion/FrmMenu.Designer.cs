﻿namespace CapaPresentacion
{
    partial class FrmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTituloInicio = new System.Windows.Forms.Label();
            this.GbxRegistros = new System.Windows.Forms.GroupBox();
            this.BtnIngresarConsulta = new System.Windows.Forms.Button();
            this.BtnIngresarVacaciones = new System.Windows.Forms.Button();
            this.BtnIngresarPaciente = new System.Windows.Forms.Button();
            this.BtnIngresarEmpleado = new System.Windows.Forms.Button();
            this.BtnIngresarMedico = new System.Windows.Forms.Button();
            this.GbxModificacion = new System.Windows.Forms.GroupBox();
            this.BtnModificarConsulta = new System.Windows.Forms.Button();
            this.BtnModificarVacaciones = new System.Windows.Forms.Button();
            this.BtnModificarPaciente = new System.Windows.Forms.Button();
            this.BtnModificarEmpleado = new System.Windows.Forms.Button();
            this.BtnModificarMedico = new System.Windows.Forms.Button();
            this.GbxBusqueda = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscarConsulta = new System.Windows.Forms.Button();
            this.BtnBuscarVacaciones = new System.Windows.Forms.Button();
            this.BtnBuscarPaciente = new System.Windows.Forms.Button();
            this.BtnBuscarEmpleado = new System.Windows.Forms.Button();
            this.BtnBuscarMedico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GbxRegistros.SuspendLayout();
            this.GbxModificacion.SuspendLayout();
            this.GbxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LblTituloInicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 98);
            this.panel1.TabIndex = 0;
            // 
            // LblTituloInicio
            // 
            this.LblTituloInicio.AutoSize = true;
            this.LblTituloInicio.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloInicio.Location = new System.Drawing.Point(406, 27);
            this.LblTituloInicio.Name = "LblTituloInicio";
            this.LblTituloInicio.Size = new System.Drawing.Size(125, 42);
            this.LblTituloInicio.TabIndex = 0;
            this.LblTituloInicio.Text = "MENÚ";
            // 
            // GbxRegistros
            // 
            this.GbxRegistros.Controls.Add(this.BtnIngresarConsulta);
            this.GbxRegistros.Controls.Add(this.BtnIngresarVacaciones);
            this.GbxRegistros.Controls.Add(this.BtnIngresarPaciente);
            this.GbxRegistros.Controls.Add(this.BtnIngresarEmpleado);
            this.GbxRegistros.Controls.Add(this.BtnIngresarMedico);
            this.GbxRegistros.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxRegistros.Location = new System.Drawing.Point(36, 116);
            this.GbxRegistros.Name = "GbxRegistros";
            this.GbxRegistros.Size = new System.Drawing.Size(286, 310);
            this.GbxRegistros.TabIndex = 1;
            this.GbxRegistros.TabStop = false;
            this.GbxRegistros.Text = "Ingreso de Datos";
            // 
            // BtnIngresarConsulta
            // 
            this.BtnIngresarConsulta.Location = new System.Drawing.Point(48, 248);
            this.BtnIngresarConsulta.Name = "BtnIngresarConsulta";
            this.BtnIngresarConsulta.Size = new System.Drawing.Size(189, 50);
            this.BtnIngresarConsulta.TabIndex = 1;
            this.BtnIngresarConsulta.Text = "Ingresar horario de consulta";
            this.BtnIngresarConsulta.UseVisualStyleBackColor = true;
            this.BtnIngresarConsulta.Click += new System.EventHandler(this.BtnIngresarConsulta_Click);
            // 
            // BtnIngresarVacaciones
            // 
            this.BtnIngresarVacaciones.Location = new System.Drawing.Point(42, 197);
            this.BtnIngresarVacaciones.Name = "BtnIngresarVacaciones";
            this.BtnIngresarVacaciones.Size = new System.Drawing.Size(201, 45);
            this.BtnIngresarVacaciones.TabIndex = 1;
            this.BtnIngresarVacaciones.Text = "Ingresar Vacaciones";
            this.BtnIngresarVacaciones.UseVisualStyleBackColor = true;
            this.BtnIngresarVacaciones.Click += new System.EventHandler(this.BtnIngresarVacaciones_Click);
            // 
            // BtnIngresarPaciente
            // 
            this.BtnIngresarPaciente.Location = new System.Drawing.Point(48, 146);
            this.BtnIngresarPaciente.Name = "BtnIngresarPaciente";
            this.BtnIngresarPaciente.Size = new System.Drawing.Size(189, 45);
            this.BtnIngresarPaciente.TabIndex = 0;
            this.BtnIngresarPaciente.Text = "Ingresar Paciente";
            this.BtnIngresarPaciente.UseVisualStyleBackColor = true;
            this.BtnIngresarPaciente.Click += new System.EventHandler(this.BtnIngresarPaciente_Click);
            // 
            // BtnIngresarEmpleado
            // 
            this.BtnIngresarEmpleado.Location = new System.Drawing.Point(48, 95);
            this.BtnIngresarEmpleado.Name = "BtnIngresarEmpleado";
            this.BtnIngresarEmpleado.Size = new System.Drawing.Size(189, 45);
            this.BtnIngresarEmpleado.TabIndex = 0;
            this.BtnIngresarEmpleado.Text = "Ingresar Empleado";
            this.BtnIngresarEmpleado.UseVisualStyleBackColor = true;
            this.BtnIngresarEmpleado.Click += new System.EventHandler(this.BtnIngresarEmpleado_Click);
            // 
            // BtnIngresarMedico
            // 
            this.BtnIngresarMedico.Location = new System.Drawing.Point(48, 44);
            this.BtnIngresarMedico.Name = "BtnIngresarMedico";
            this.BtnIngresarMedico.Size = new System.Drawing.Size(189, 45);
            this.BtnIngresarMedico.TabIndex = 0;
            this.BtnIngresarMedico.Text = "Ingresar Medico";
            this.BtnIngresarMedico.UseVisualStyleBackColor = true;
            this.BtnIngresarMedico.Click += new System.EventHandler(this.BtnIngresarMedico_Click);
            // 
            // GbxModificacion
            // 
            this.GbxModificacion.Controls.Add(this.BtnModificarConsulta);
            this.GbxModificacion.Controls.Add(this.BtnModificarVacaciones);
            this.GbxModificacion.Controls.Add(this.BtnModificarPaciente);
            this.GbxModificacion.Controls.Add(this.BtnModificarEmpleado);
            this.GbxModificacion.Controls.Add(this.BtnModificarMedico);
            this.GbxModificacion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxModificacion.Location = new System.Drawing.Point(657, 116);
            this.GbxModificacion.Name = "GbxModificacion";
            this.GbxModificacion.Size = new System.Drawing.Size(284, 310);
            this.GbxModificacion.TabIndex = 1;
            this.GbxModificacion.TabStop = false;
            this.GbxModificacion.Text = "Modificación de Datos";
            // 
            // BtnModificarConsulta
            // 
            this.BtnModificarConsulta.Location = new System.Drawing.Point(48, 249);
            this.BtnModificarConsulta.Name = "BtnModificarConsulta";
            this.BtnModificarConsulta.Size = new System.Drawing.Size(189, 50);
            this.BtnModificarConsulta.TabIndex = 3;
            this.BtnModificarConsulta.Text = "Modificar horario de consulta";
            this.BtnModificarConsulta.UseVisualStyleBackColor = true;
            this.BtnModificarConsulta.Click += new System.EventHandler(this.BtnModificarConsulta_Click);
            // 
            // BtnModificarVacaciones
            // 
            this.BtnModificarVacaciones.Location = new System.Drawing.Point(38, 198);
            this.BtnModificarVacaciones.Name = "BtnModificarVacaciones";
            this.BtnModificarVacaciones.Size = new System.Drawing.Size(210, 45);
            this.BtnModificarVacaciones.TabIndex = 2;
            this.BtnModificarVacaciones.Text = "Modificar Vacaciones";
            this.BtnModificarVacaciones.UseVisualStyleBackColor = true;
            this.BtnModificarVacaciones.Click += new System.EventHandler(this.BtnModificarVacaciones_Click);
            // 
            // BtnModificarPaciente
            // 
            this.BtnModificarPaciente.Location = new System.Drawing.Point(48, 147);
            this.BtnModificarPaciente.Name = "BtnModificarPaciente";
            this.BtnModificarPaciente.Size = new System.Drawing.Size(189, 45);
            this.BtnModificarPaciente.TabIndex = 0;
            this.BtnModificarPaciente.Text = "Modificar Paciente";
            this.BtnModificarPaciente.UseVisualStyleBackColor = true;
            this.BtnModificarPaciente.Click += new System.EventHandler(this.BtnModificarPaciente_Click);
            // 
            // BtnModificarEmpleado
            // 
            this.BtnModificarEmpleado.Location = new System.Drawing.Point(43, 96);
            this.BtnModificarEmpleado.Name = "BtnModificarEmpleado";
            this.BtnModificarEmpleado.Size = new System.Drawing.Size(199, 45);
            this.BtnModificarEmpleado.TabIndex = 0;
            this.BtnModificarEmpleado.Text = "Modificar Empleado";
            this.BtnModificarEmpleado.UseVisualStyleBackColor = true;
            this.BtnModificarEmpleado.Click += new System.EventHandler(this.BtnModificarEmpleado_Click);
            // 
            // BtnModificarMedico
            // 
            this.BtnModificarMedico.Location = new System.Drawing.Point(48, 45);
            this.BtnModificarMedico.Name = "BtnModificarMedico";
            this.BtnModificarMedico.Size = new System.Drawing.Size(189, 45);
            this.BtnModificarMedico.TabIndex = 0;
            this.BtnModificarMedico.Text = "Modificar Medico";
            this.BtnModificarMedico.UseVisualStyleBackColor = true;
            this.BtnModificarMedico.Click += new System.EventHandler(this.BtnModificarMedico_Click);
            // 
            // GbxBusqueda
            // 
            this.GbxBusqueda.Controls.Add(this.button1);
            this.GbxBusqueda.Controls.Add(this.BtnBuscarConsulta);
            this.GbxBusqueda.Controls.Add(this.BtnBuscarVacaciones);
            this.GbxBusqueda.Controls.Add(this.BtnBuscarPaciente);
            this.GbxBusqueda.Controls.Add(this.BtnBuscarEmpleado);
            this.GbxBusqueda.Controls.Add(this.BtnBuscarMedico);
            this.GbxBusqueda.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxBusqueda.Location = new System.Drawing.Point(351, 116);
            this.GbxBusqueda.Name = "GbxBusqueda";
            this.GbxBusqueda.Size = new System.Drawing.Size(284, 366);
            this.GbxBusqueda.TabIndex = 1;
            this.GbxBusqueda.TabStop = false;
            this.GbxBusqueda.Text = "Búsqueda de Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBuscarConsulta
            // 
            this.BtnBuscarConsulta.Location = new System.Drawing.Point(48, 248);
            this.BtnBuscarConsulta.Name = "BtnBuscarConsulta";
            this.BtnBuscarConsulta.Size = new System.Drawing.Size(189, 50);
            this.BtnBuscarConsulta.TabIndex = 3;
            this.BtnBuscarConsulta.Text = "Buscar horario de consulta";
            this.BtnBuscarConsulta.UseVisualStyleBackColor = true;
            this.BtnBuscarConsulta.Click += new System.EventHandler(this.BtnBuscarConsulta_Click);
            // 
            // BtnBuscarVacaciones
            // 
            this.BtnBuscarVacaciones.Location = new System.Drawing.Point(48, 197);
            this.BtnBuscarVacaciones.Name = "BtnBuscarVacaciones";
            this.BtnBuscarVacaciones.Size = new System.Drawing.Size(189, 45);
            this.BtnBuscarVacaciones.TabIndex = 2;
            this.BtnBuscarVacaciones.Text = "Buscar Vacaciones";
            this.BtnBuscarVacaciones.UseVisualStyleBackColor = true;
            this.BtnBuscarVacaciones.Click += new System.EventHandler(this.BtnBuscarVacaciones_Click);
            // 
            // BtnBuscarPaciente
            // 
            this.BtnBuscarPaciente.Location = new System.Drawing.Point(48, 146);
            this.BtnBuscarPaciente.Name = "BtnBuscarPaciente";
            this.BtnBuscarPaciente.Size = new System.Drawing.Size(189, 45);
            this.BtnBuscarPaciente.TabIndex = 0;
            this.BtnBuscarPaciente.Text = "Buscar Paciente";
            this.BtnBuscarPaciente.UseVisualStyleBackColor = true;
            this.BtnBuscarPaciente.Click += new System.EventHandler(this.BtnBuscarPaciente_Click);
            // 
            // BtnBuscarEmpleado
            // 
            this.BtnBuscarEmpleado.Location = new System.Drawing.Point(48, 95);
            this.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            this.BtnBuscarEmpleado.Size = new System.Drawing.Size(189, 45);
            this.BtnBuscarEmpleado.TabIndex = 0;
            this.BtnBuscarEmpleado.Text = "Buscar Empleado";
            this.BtnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.BtnBuscarEmpleado.Click += new System.EventHandler(this.BtnBuscarEmpleado_Click);
            // 
            // BtnBuscarMedico
            // 
            this.BtnBuscarMedico.Location = new System.Drawing.Point(48, 44);
            this.BtnBuscarMedico.Name = "BtnBuscarMedico";
            this.BtnBuscarMedico.Size = new System.Drawing.Size(189, 45);
            this.BtnBuscarMedico.TabIndex = 0;
            this.BtnBuscarMedico.Text = "Buscar Medico";
            this.BtnBuscarMedico.UseVisualStyleBackColor = true;
            this.BtnBuscarMedico.Click += new System.EventHandler(this.BtnBuscarMedico_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(985, 508);
            this.Controls.Add(this.GbxBusqueda);
            this.Controls.Add(this.GbxModificacion);
            this.Controls.Add(this.GbxRegistros);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbxRegistros.ResumeLayout(false);
            this.GbxModificacion.ResumeLayout(false);
            this.GbxBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTituloInicio;
        private System.Windows.Forms.GroupBox GbxRegistros;
        private System.Windows.Forms.Button BtnIngresarPaciente;
        private System.Windows.Forms.Button BtnIngresarEmpleado;
        private System.Windows.Forms.Button BtnIngresarMedico;
        private System.Windows.Forms.GroupBox GbxModificacion;
        private System.Windows.Forms.GroupBox GbxBusqueda;
        private System.Windows.Forms.Button BtnModificarPaciente;
        private System.Windows.Forms.Button BtnModificarEmpleado;
        private System.Windows.Forms.Button BtnModificarMedico;
        private System.Windows.Forms.Button BtnBuscarPaciente;
        private System.Windows.Forms.Button BtnBuscarEmpleado;
        private System.Windows.Forms.Button BtnBuscarMedico;
        private System.Windows.Forms.Button BtnIngresarConsulta;
        private System.Windows.Forms.Button BtnIngresarVacaciones;
        private System.Windows.Forms.Button BtnModificarConsulta;
        private System.Windows.Forms.Button BtnModificarVacaciones;
        private System.Windows.Forms.Button BtnBuscarConsulta;
        private System.Windows.Forms.Button BtnBuscarVacaciones;
        private System.Windows.Forms.Button button1;
    }
}

