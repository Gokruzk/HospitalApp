using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLogic;

namespace CapaPresentacion
{
    public partial class ReportMedicoTipo : Form
    {
        public ReportMedicoTipo()
        {
            InitializeComponent();
        }

        private void ReportMedicoTipo_Load(object sender, EventArgs e)
        {
            ClOperacionesMedico objOperacionesMedico  = new ClOperacionesMedico();
            objOperacionesMedico.CargarMedicosTipos();
        }
    }
}
