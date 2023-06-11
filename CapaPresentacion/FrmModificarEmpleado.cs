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
    public partial class FrmModificarEmpleado : Form
    {
        public FrmModificarEmpleado()
        {
            InitializeComponent();

            //CmbCampo.Enabled = false;
            TxtEleccion.Enabled = false;
            BtnBuscar.Enabled = false;

            txtNombre.Enabled = false;
            dateTimePickerFecNac.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtNumSegSocialModificar.Enabled = false;
            CmbTipo.Enabled = false;
            CmbPoblacionModificar.Enabled = false;
            CmbHabilDeshabil.Enabled = false;
        }

        private void CmbCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxtEleccion.Enabled = true;
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
                txtNombre.Enabled = true;
                dateTimePickerFecNac.Enabled = true;
                TxtDireccion.Enabled = true;
                TxtNumSegSocialModificar.Enabled = true;
                CmbTipo.Enabled = true;
                CmbPoblacionModificar.Enabled = true;
                CmbHabilDeshabil.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnBuscar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtNombre: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dateTimePickerFecNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error DateTimeFechaNacimiento: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtDireccion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CmbPoblacionModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbPoblacion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbTipo: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void TxtNumSegSocialModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error txtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CmbHabilDeshabil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

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
                MessageBox.Show($"El empleado no ha sido modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
