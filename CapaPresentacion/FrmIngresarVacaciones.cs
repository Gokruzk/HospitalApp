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
    public partial class FrmIngresarVacaciones : Form
    {
        public FrmIngresarVacaciones()
        {
            InitializeComponent();
            CmbEstado.Enabled = false;
            dateTimePickerFecInicio.Enabled = false;
            dateTimePickerFecFin.Enabled = false;
            
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CmbEstado.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtCedula: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dateTimePickerFecInicio.Enabled = true;   
                dateTimePickerFecInicio.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbEstado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dateTimePickerFecFin.Enabled = true;
                dateTimePickerFecFin.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error DataTimeFechaInicio: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                BtnRegistrar.Enabled = true;
                BtnRegistrar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error DataTimeFechaFin: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnIngresar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Las Vacaciones no han sido registradas", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
