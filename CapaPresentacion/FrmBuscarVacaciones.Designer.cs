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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_VACACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIngresarVacaciones);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 78);
            this.panel1.TabIndex = 75;
            // 
            // lblIngresarVacaciones
            // 
            this.lblIngresarVacaciones.AutoSize = true;
            this.lblIngresarVacaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarVacaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresarVacaciones.Location = new System.Drawing.Point(249, 22);
            this.lblIngresarVacaciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngresarVacaciones.Name = "lblIngresarVacaciones";
            this.lblIngresarVacaciones.Size = new System.Drawing.Size(320, 32);
            this.lblIngresarVacaciones.TabIndex = 1;
            this.lblIngresarVacaciones.Text = "BUSCAR VACACIONES";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(365, 96);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(183, 29);
            this.TxtCedula.TabIndex = 78;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(261, 100);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(96, 22);
            this.LblCedula.TabIndex = 77;
            this.LblCedula.Text = "CÉDULA:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.ID_VACACION,
            this.Estado,
            this.FecInicio,
            this.FecFin});
            this.dataGridView1.Location = new System.Drawing.Point(118, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 150);
            this.dataGridView1.TabIndex = 79;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "CÉDULA";
            this.Cedula.Name = "Cedula";
            // 
            // ID_VACACION
            // 
            this.ID_VACACION.HeaderText = "ID VACACIÓN";
            this.ID_VACACION.Name = "ID_VACACION";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            // 
            // FecInicio
            // 
            this.FecInicio.HeaderText = "FECHA DE INICIO";
            this.FecInicio.Name = "FecInicio";
            // 
            // FecFin
            // 
            this.FecFin.HeaderText = "FECHA FIN";
            this.FecFin.Name = "FecFin";
            // 
            // FrmBuscarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBuscarVacaciones";
            this.Text = "Buscar Vacaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngresarVacaciones;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VACACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecFin;
    }
}