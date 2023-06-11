using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnIngresarMedico_Click(object sender, EventArgs e)
        {
            FrmIngresoDatosMedico objM = new FrmIngresoDatosMedico();
            objM.ShowDialog();
        }

        private void BtnIngresarEmpleado_Click(object sender, EventArgs e)
        {
            FrmIngresoDatosEmpleado objEmpl= new FrmIngresoDatosEmpleado();
            objEmpl.ShowDialog();
        }

        private void BtnModificarMedico_Click(object sender, EventArgs e)
        {
            FrmModificarMedico objM = new FrmModificarMedico();
            objM.ShowDialog();
        }

        private void BtnIngresarPaciente_Click(object sender, EventArgs e)
        {
            FrmIngresoDatosPaciente objP = new FrmIngresoDatosPaciente();
            objP.ShowDialog();
        }

        private void BtnModificarPaciente_Click(object sender, EventArgs e)
        {
            FrmModificarPaciente ojbP = new FrmModificarPaciente();
            ojbP.ShowDialog();
        }
    }
}
