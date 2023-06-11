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
    public partial class FrmModificarPaciente : Form
    {
        public FrmModificarPaciente()
        {
            InitializeComponent();
            txtNombreModificar.Enabled = false;
            dateTimePickerFecNac.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtNumSegSocial.Enabled = false;
            CmbMedicoAsignado.Enabled = false;
            CmbHabDes.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void CmbCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxtEleccion.Enabled = true;
                
                TxtEleccion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbCampo: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtEleccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                BtnBuscar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtEleccion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreModificar.Enabled = true;
                dateTimePickerFecNac.Enabled = true;
                TxtDireccion.Enabled = true;
                TxtNumSegSocial.Enabled = true;
                CmbMedicoAsignado.Enabled = true;
                CmbHabDes.Enabled = true;
                BtnModificar.Enabled = true;
                txtNombreModificar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnBuscar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dateTimePickerFecNac.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtModificarNombre: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxtDireccion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error DateTimeFechaInicio: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxtNumSegSocial.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtDireccion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNumSegSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CmbMedicoAsignado.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbMedicoAsignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CmbHabDes.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbMedicoAsignado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbHabDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                BtnModificar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbHabilitado/Deshabilitado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnModificar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"El Paciente no han sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
