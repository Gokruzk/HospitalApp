namespace CapaPresentacion
{
    partial class FrmBuscarPaciente
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
            this.lblBuscarPaciente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblMedicoAsignado = new System.Windows.Forms.Label();
            this.LblNumSegSocial = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbCampo = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtEleccion = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarPaciente
            // 
            this.lblBuscarPaciente.AutoSize = true;
            this.lblBuscarPaciente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscarPaciente.Location = new System.Drawing.Point(265, 26);
            this.lblBuscarPaciente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBuscarPaciente.Name = "lblBuscarPaciente";
            this.lblBuscarPaciente.Size = new System.Drawing.Size(276, 32);
            this.lblBuscarPaciente.TabIndex = 1;
            this.lblBuscarPaciente.Text = "BUSCAR PACIENTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblBuscarPaciente);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 78);
            this.panel1.TabIndex = 88;
            // 
            // LblMedicoAsignado
            // 
            this.LblMedicoAsignado.AutoSize = true;
            this.LblMedicoAsignado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicoAsignado.Location = new System.Drawing.Point(46, 344);
            this.LblMedicoAsignado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMedicoAsignado.Name = "LblMedicoAsignado";
            this.LblMedicoAsignado.Size = new System.Drawing.Size(709, 22);
            this.LblMedicoAsignado.TabIndex = 86;
            this.LblMedicoAsignado.Text = "MÉDICO ASIGNADO: __________________________________________________";
            // 
            // LblNumSegSocial
            // 
            this.LblNumSegSocial.AutoSize = true;
            this.LblNumSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSegSocial.Location = new System.Drawing.Point(46, 299);
            this.LblNumSegSocial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNumSegSocial.Name = "LblNumSegSocial";
            this.LblNumSegSocial.Size = new System.Drawing.Size(529, 22);
            this.LblNumSegSocial.TabIndex = 87;
            this.LblNumSegSocial.Text = "NÚMERO DE SEGURIDAD SOCIAL: ___________________";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(35, 209);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(618, 22);
            this.LblFechaNacimiento.TabIndex = 84;
            this.LblFechaNacimiento.Text = "FECHA DE NACIMIENTO: _____________________________________";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(46, 251);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(731, 22);
            this.LblDireccion.TabIndex = 83;
            this.LblDireccion.Text = "DIRECCÍON: ____________________________________________________________";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(61, 167);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(707, 22);
            this.lblNombre.TabIndex = 82;
            this.lblNombre.Text = "NOMBRE: ____________________________________________________________";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(262, 391);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(282, 22);
            this.LblEstado.TabIndex = 101;
            this.LblEstado.Text = "ESTADO: __________________";
            // 
            // CmbCampo
            // 
            this.CmbCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbCampo.FormattingEnabled = true;
            this.CmbCampo.Items.AddRange(new object[] {
            "CÉDULA",
            "NUM. SEGURIDAD SOCIAL"});
            this.CmbCampo.Location = new System.Drawing.Point(137, 101);
            this.CmbCampo.Name = "CmbCampo";
            this.CmbCampo.Size = new System.Drawing.Size(226, 32);
            this.CmbCampo.TabIndex = 111;
            this.CmbCampo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbCampo_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(607, 96);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(189, 39);
            this.BtnBuscar.TabIndex = 110;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtEleccion
            // 
            this.TxtEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEleccion.Location = new System.Drawing.Point(392, 101);
            this.TxtEleccion.Name = "TxtEleccion";
            this.TxtEleccion.Size = new System.Drawing.Size(183, 29);
            this.TxtEleccion.TabIndex = 109;
            this.TxtEleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEleccion_KeyPress);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(26, 108);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(88, 22);
            this.LblCedula.TabIndex = 108;
            this.LblCedula.Text = "CAMPO:";
            // 
            // FrmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.CmbCampo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtEleccion);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblMedicoAsignado);
            this.Controls.Add(this.LblNumSegSocial);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Paciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBuscarPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblMedicoAsignado;
        private System.Windows.Forms.Label LblNumSegSocial;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbCampo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtEleccion;
        private System.Windows.Forms.Label LblCedula;
    }
}