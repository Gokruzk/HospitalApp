using CLogic;
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
    public partial class FrmIngresarConsulta : Form
    {
        ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        ClOperacionesPaciente objOperacionesPaciente = new ClOperacionesPaciente();
        public FrmIngresarConsulta()
        {
            InitializeComponent();
        }

        private void CmbPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CmbMedicoAsignado.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbPaciente: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CmbMedicoAsignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    dateTimePickerFecha.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbMedicoAsignado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dateTimePickerFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    TxtDescripcion.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error DateTimeFecha: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    BtnRegistrar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtDescripcion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtDescripcion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"La consulta no ha sido registrada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIngresarConsulta_Load(object sender, EventArgs e)
        {
            List<string> tipos = objOperacionesMedico.CargarNombresMedicos();

            foreach (string tipo in tipos)
                CmbMedicoAsignado.Items.Add(tipo);

            tipos = objOperacionesPaciente.CargarNombresPacientes();

            foreach(string tipo in tipos)
                CmbPaciente.Items.Add(tipo);    
        }
    }
}
