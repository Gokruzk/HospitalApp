namespace CapaPresentacion
{
    partial class FrmBuscarVacaciones
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
            this.lblIngresarVacaciones = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.dataGridViewVacaciones = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_VACACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarVacaciones);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 96);
            this.panel1.TabIndex = 75;
            // 
            // lblIngresarVacaciones
            // 
            this.lblIngresarVacaciones.AutoSize = true;
            this.lblIngresarVacaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarVacaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresarVacaciones.Location = new System.Drawing.Point(332, 27);
            this.lblIngresarVacaciones.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIngresarVacaciones.Name = "lblIngresarVacaciones";
            this.lblIngresarVacaciones.Size = new System.Drawing.Size(392, 38);
            this.lblIngresarVacaciones.TabIndex = 1;
            this.lblIngresarVacaciones.Text = "BUSCAR VACACIONES";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(343, 128);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(243, 34);
            this.TxtCedula.TabIndex = 78;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(204, 133);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(121, 28);
            this.LblCedula.TabIndex = 77;
            this.LblCedula.Text = "CÉDULA:";
            // 
            // dataGridViewVacaciones
            // 
            this.dataGridViewVacaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.ID_VACACION,
            this.Estado,
            this.FecInicio,
            this.FecFin});
            this.dataGridViewVacaciones.Location = new System.Drawing.Point(157, 203);
            this.dataGridViewVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVacaciones.Name = "dataGridViewVacaciones";
            this.dataGridViewVacaciones.RowHeadersWidth = 51;
            this.dataGridViewVacaciones.Size = new System.Drawing.Size(809, 185);
            this.dataGridViewVacaciones.TabIndex = 79;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "CÉDULA";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            // 
            // ID_VACACION
            // 
            this.ID_VACACION.HeaderText = "ID VACACIÓN";
            this.ID_VACACION.MinimumWidth = 6;
            this.ID_VACACION.Name = "ID_VACACION";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            // 
            // FecInicio
            // 
            this.FecInicio.HeaderText = "FECHA DE INICIO";
            this.FecInicio.MinimumWidth = 6;
            this.FecInicio.Name = "FecInicio";
            // 
            // FecFin
            // 
            this.FecFin.HeaderText = "FECHA FIN";
            this.FecFin.MinimumWidth = 6;
            this.FecFin.Name = "FecFin";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(641, 123);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(252, 48);
            this.BtnBuscar.TabIndex = 111;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmBuscarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1109, 533);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dataGridViewVacaciones);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscarVacaciones";
            this.Text = "Buscar Vacaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngresarVacaciones;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.DataGridView dataGridViewVacaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VACACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecFin;
        private System.Windows.Forms.Button BtnBuscar;
    }
}