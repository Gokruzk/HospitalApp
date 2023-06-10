namespace CapaPresentacion
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
            this.BtnIngresarPaciente = new System.Windows.Forms.Button();
            this.BtnIngresarEmpleado = new System.Windows.Forms.Button();
            this.BtnIngresarMedico = new System.Windows.Forms.Button();
            this.GbxModificacion = new System.Windows.Forms.GroupBox();
            this.BtnModificarPaciente = new System.Windows.Forms.Button();
            this.BtnModificarEmpleado = new System.Windows.Forms.Button();
            this.BtnModificarMedico = new System.Windows.Forms.Button();
            this.GbxEliminacionDatos = new System.Windows.Forms.GroupBox();
            this.BtnEliminarPaciente = new System.Windows.Forms.Button();
            this.BtnEliminarEmpleado = new System.Windows.Forms.Button();
            this.BtnEliminarMedico = new System.Windows.Forms.Button();
            this.GbxBusqueda = new System.Windows.Forms.GroupBox();
            this.BtnBuscarPaciente = new System.Windows.Forms.Button();
            this.BtnBuscarEmpleado = new System.Windows.Forms.Button();
            this.BtnBuscarMedico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GbxRegistros.SuspendLayout();
            this.GbxModificacion.SuspendLayout();
            this.GbxEliminacionDatos.SuspendLayout();
            this.GbxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.LblTituloInicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 98);
            this.panel1.TabIndex = 0;
            // 
            // LblTituloInicio
            // 
            this.LblTituloInicio.AutoSize = true;
            this.LblTituloInicio.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloInicio.Location = new System.Drawing.Point(355, 24);
            this.LblTituloInicio.Name = "LblTituloInicio";
            this.LblTituloInicio.Size = new System.Drawing.Size(125, 42);
            this.LblTituloInicio.TabIndex = 0;
            this.LblTituloInicio.Text = "MENU";
            // 
            // GbxRegistros
            // 
            this.GbxRegistros.Controls.Add(this.BtnIngresarPaciente);
            this.GbxRegistros.Controls.Add(this.BtnIngresarEmpleado);
            this.GbxRegistros.Controls.Add(this.BtnIngresarMedico);
            this.GbxRegistros.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxRegistros.Location = new System.Drawing.Point(36, 116);
            this.GbxRegistros.Name = "GbxRegistros";
            this.GbxRegistros.Size = new System.Drawing.Size(798, 119);
            this.GbxRegistros.TabIndex = 1;
            this.GbxRegistros.TabStop = false;
            this.GbxRegistros.Text = "Ingreso de Datos";
            // 
            // BtnIngresarPaciente
            // 
            this.BtnIngresarPaciente.Location = new System.Drawing.Point(549, 44);
            this.BtnIngresarPaciente.Name = "BtnIngresarPaciente";
            this.BtnIngresarPaciente.Size = new System.Drawing.Size(189, 45);
            this.BtnIngresarPaciente.TabIndex = 0;
            this.BtnIngresarPaciente.Text = "Ingresar Paciente";
            this.BtnIngresarPaciente.UseVisualStyleBackColor = true;
            // 
            // BtnIngresarEmpleado
            // 
            this.BtnIngresarEmpleado.Location = new System.Drawing.Point(298, 44);
            this.BtnIngresarEmpleado.Name = "BtnIngresarEmpleado";
            this.BtnIngresarEmpleado.Size = new System.Drawing.Size(189, 45);
            this.BtnIngresarEmpleado.TabIndex = 0;
            this.BtnIngresarEmpleado.Text = "Ingresar Empleado";
            this.BtnIngresarEmpleado.UseVisualStyleBackColor = true;
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
            this.GbxModificacion.Controls.Add(this.BtnModificarPaciente);
            this.GbxModificacion.Controls.Add(this.BtnModificarEmpleado);
            this.GbxModificacion.Controls.Add(this.BtnModificarMedico);
            this.GbxModificacion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxModificacion.Location = new System.Drawing.Point(36, 248);
            this.GbxModificacion.Name = "GbxModificacion";
            this.GbxModificacion.Size = new System.Drawing.Size(798, 119);
            this.GbxModificacion.TabIndex = 1;
            this.GbxModificacion.TabStop = false;
            this.GbxModificacion.Text = "Modificación de Datos";
            // 
            // BtnModificarPaciente
            // 
            this.BtnModificarPaciente.Location = new System.Drawing.Point(549, 45);
            this.BtnModificarPaciente.Name = "BtnModificarPaciente";
            this.BtnModificarPaciente.Size = new System.Drawing.Size(189, 45);
            this.BtnModificarPaciente.TabIndex = 0;
            this.BtnModificarPaciente.Text = "Modificar Paciente";
            this.BtnModificarPaciente.UseVisualStyleBackColor = true;
            // 
            // BtnModificarEmpleado
            // 
            this.BtnModificarEmpleado.Location = new System.Drawing.Point(294, 45);
            this.BtnModificarEmpleado.Name = "BtnModificarEmpleado";
            this.BtnModificarEmpleado.Size = new System.Drawing.Size(199, 45);
            this.BtnModificarEmpleado.TabIndex = 0;
            this.BtnModificarEmpleado.Text = "Modificar Empleado";
            this.BtnModificarEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnModificarMedico
            // 
            this.BtnModificarMedico.Location = new System.Drawing.Point(48, 45);
            this.BtnModificarMedico.Name = "BtnModificarMedico";
            this.BtnModificarMedico.Size = new System.Drawing.Size(189, 45);
            this.BtnModificarMedico.TabIndex = 0;
            this.BtnModificarMedico.Text = "Modificar Medico";
            this.BtnModificarMedico.UseVisualStyleBackColor = true;
            // 
            // GbxEliminacionDatos
            // 
            this.GbxEliminacionDatos.Controls.Add(this.BtnEliminarPaciente);
            this.GbxEliminacionDatos.Controls.Add(this.BtnEliminarEmpleado);
            this.GbxEliminacionDatos.Controls.Add(this.BtnEliminarMedico);
            this.GbxEliminacionDatos.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxEliminacionDatos.Location = new System.Drawing.Point(36, 513);
            this.GbxEliminacionDatos.Name = "GbxEliminacionDatos";
            this.GbxEliminacionDatos.Size = new System.Drawing.Size(798, 119);
            this.GbxEliminacionDatos.TabIndex = 1;
            this.GbxEliminacionDatos.TabStop = false;
            this.GbxEliminacionDatos.Text = "Eliminación de Datos";
            // 
            // BtnEliminarPaciente
            // 
            this.BtnEliminarPaciente.Location = new System.Drawing.Point(549, 45);
            this.BtnEliminarPaciente.Name = "BtnEliminarPaciente";
            this.BtnEliminarPaciente.Size = new System.Drawing.Size(189, 45);
            this.BtnEliminarPaciente.TabIndex = 0;
            this.BtnEliminarPaciente.Text = "Eliminar Paciente";
            this.BtnEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarEmpleado
            // 
            this.BtnEliminarEmpleado.Location = new System.Drawing.Point(298, 45);
            this.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado";
            this.BtnEliminarEmpleado.Size = new System.Drawing.Size(189, 45);
            this.BtnEliminarEmpleado.TabIndex = 0;
            this.BtnEliminarEmpleado.Text = "Eliminar Empleado";
            this.BtnEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarMedico
            // 
            this.BtnEliminarMedico.Location = new System.Drawing.Point(48, 45);
            this.BtnEliminarMedico.Name = "BtnEliminarMedico";
            this.BtnEliminarMedico.Size = new System.Drawing.Size(189, 45);
            this.BtnEliminarMedico.TabIndex = 0;
            this.BtnEliminarMedico.Text = "Eliminar Medico";
            this.BtnEliminarMedico.UseVisualStyleBackColor = true;
            // 
            // GbxBusqueda
            // 
            this.GbxBusqueda.Controls.Add(this.BtnBuscarPaciente);
            this.GbxBusqueda.Controls.Add(this.BtnBuscarEmpleado);
            this.GbxBusqueda.Controls.Add(this.BtnBuscarMedico);
            this.GbxBusqueda.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxBusqueda.Location = new System.Drawing.Point(36, 376);
            this.GbxBusqueda.Name = "GbxBusqueda";
            this.GbxBusqueda.Size = new System.Drawing.Size(798, 119);
            this.GbxBusqueda.TabIndex = 1;
            this.GbxBusqueda.TabStop = false;
            this.GbxBusqueda.Text = "Búsqueda de Datos";
            // 
            // BtnBuscarPaciente
            // 
            this.BtnBuscarPaciente.Location = new System.Drawing.Point(549, 44);
            this.BtnBuscarPaciente.Name = "BtnBuscarPaciente";
            this.BtnBuscarPaciente.Size = new System.Drawing.Size(189, 45);
            this.BtnBuscarPaciente.TabIndex = 0;
            this.BtnBuscarPaciente.Text = "Buscar Paciente";
            this.BtnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarEmpleado
            // 
            this.BtnBuscarEmpleado.Location = new System.Drawing.Point(298, 44);
            this.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            this.BtnBuscarEmpleado.Size = new System.Drawing.Size(189, 45);
            this.BtnBuscarEmpleado.TabIndex = 0;
            this.BtnBuscarEmpleado.Text = "Buscar Empleado";
            this.BtnBuscarEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarMedico
            // 
            this.BtnBuscarMedico.Location = new System.Drawing.Point(48, 44);
            this.BtnBuscarMedico.Name = "BtnBuscarMedico";
            this.BtnBuscarMedico.Size = new System.Drawing.Size(189, 45);
            this.BtnBuscarMedico.TabIndex = 0;
            this.BtnBuscarMedico.Text = "Buscar Medico";
            this.BtnBuscarMedico.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 666);
            this.Controls.Add(this.GbxEliminacionDatos);
            this.Controls.Add(this.GbxBusqueda);
            this.Controls.Add(this.GbxModificacion);
            this.Controls.Add(this.GbxRegistros);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbxRegistros.ResumeLayout(false);
            this.GbxModificacion.ResumeLayout(false);
            this.GbxEliminacionDatos.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox GbxEliminacionDatos;
        private System.Windows.Forms.GroupBox GbxBusqueda;
        private System.Windows.Forms.Button BtnModificarPaciente;
        private System.Windows.Forms.Button BtnModificarEmpleado;
        private System.Windows.Forms.Button BtnModificarMedico;
        private System.Windows.Forms.Button BtnEliminarPaciente;
        private System.Windows.Forms.Button BtnEliminarEmpleado;
        private System.Windows.Forms.Button BtnEliminarMedico;
        private System.Windows.Forms.Button BtnBuscarPaciente;
        private System.Windows.Forms.Button BtnBuscarEmpleado;
        private System.Windows.Forms.Button BtnBuscarMedico;
    }
}

