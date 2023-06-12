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

        private void BtnBuscarMedico_Click(object sender, EventArgs e)
        {
            FrmBuscarMedico objM = new FrmBuscarMedico();
            objM.ShowDialog();
        }

        private void BtnBuscarPaciente_Click(object sender, EventArgs e)
        {
            FrmBuscarPaciente objP = new FrmBuscarPaciente();
            objP.ShowDialog();
        }

        private void BtnIngresarConsulta_Click(object sender, EventArgs e)
        {
            FrmIngresarConsulta obC = new FrmIngresarConsulta();
            obC.ShowDialog();
        }

        private void BtnIngresarVacaciones_Click(object sender, EventArgs e)
        {
            FrmIngresarVacaciones objV = new FrmIngresarVacaciones();
            objV.ShowDialog();
        }
    }
}
