using CLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ReportMedicoVacaciones : Form
    {
        public ReportMedicoVacaciones()
        {
            InitializeComponent();
        }

        ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();

        public void RefreshDataGrid(DataGridView d)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                adp = objOperacionesMedico.CargarMedicosVacaciones();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("No hay datos", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportMedicoVacaciones_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
