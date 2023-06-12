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
    public partial class Reportes: Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        public void RefreshDataGrid(DataGridView d, SqlDataAdapter obj)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                adp = obj;
                DataTable dt = new DataTable();
                adp.Fill(dt);
                d.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("No hay datos", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
            RefreshDataGrid(dataGridView1, objOperacionesMedico.CargarMedicosTipos());
            RefreshDataGrid(dataGridView1, objOperacionesMedico.CargarMedicosVacaciones());
        }
    }
}
