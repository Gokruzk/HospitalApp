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
    public partial class FrmModificarMedico : Form
    {
        public FrmModificarMedico()
        {
            InitializeComponent();
            CmbCampo.Enabled = false;
            TxtEleccion.Enabled = false;
            BtnBuscar.Enabled = false;

            txtNombreModificar.Enabled = false;
            dateTimePickerFecNac.Enabled = false;
            txtDireccion.Enabled = false;  
            TxtNumSegSocial.Enabled = false;
            CmbTipoModificar.Enabled = false;
            txtNumColegiado.Enabled = false;
            CmbPoblacionModificar.Enabled = false;
            dateTimePickerFecAlta.Enabled = false;
            dateTimePickerFecBaja.Enabled = false;
            CmbHabDes.Enabled = false;
        }

        private void CmbCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            
        }

        private void TxtEleccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreModificar.Enabled = true;
                dateTimePickerFecNac.Enabled = true;
                txtDireccion.Enabled = true;
                TxtNumSegSocial.Enabled = true;
                CmbTipoModificar.Enabled = true;
                txtNumColegiado.Enabled = true;
                CmbPoblacionModificar.Enabled = true;
                
                dateTimePickerFecAlta.Enabled = true;
                dateTimePickerFecBaja.Enabled = true;
                CmbHabDes.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnBuscar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


            }

        }

        private void dateTimePickerFecNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    txtDireccion.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error DateTimeFechaNaciemiento: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            
        }

        private void TxtNumSegSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CmbTipoModificar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CmbTipoModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    txtNumColegiado.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbTipoModificar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void txtNumColegiado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CmbPoblacionModificar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtNumeroColediado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CmbPoblacionModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    dateTimePickerFecAlta.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbPoblacionModificar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dateTimePickerFecAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    dateTimePickerFecBaja.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error DateTimeFechaAlta: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dateTimePickerFecBaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CmbHabDes.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error DateTimeFechaBaja: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CmbHabDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    BtnModificar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbHabilitadoDeshabilitado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                MessageBox.Show($"El medico no ha sido modificado", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
