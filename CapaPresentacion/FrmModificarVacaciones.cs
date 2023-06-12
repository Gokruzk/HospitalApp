using CLogic;
using Entidades;
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
    public partial class FrmModificarVacaciones : Form
    {
        Vacaciones objVacacion = new Vacaciones();
        ClOperacionesVacacion objOperacionesVacacion = new ClOperacionesVacacion();
        ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        ClOperacionesEmpleado objOperacionesEmpleado = new ClOperacionesEmpleado();
        ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();

        public FrmModificarVacaciones()
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
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarCedula(TxtCedula.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        TxtIdVac.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtIdVac_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (objOperacionesEmpleado.BuscarEmpleado(TxtCedula.Text) == null && objOperacionesMedico.CargarMedicoCedula(TxtCedula.Text) == null)
                    {
                        CmbEstado.Enabled = false;
                        dateTimePickerFecInicio.Enabled = false;
                        dateTimePickerFecFin.Enabled = false;
                        MessageBox.Show("No se encuentra la vacación con el ID ingresado ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        CmbEstado.Enabled = true;
                        dateTimePickerFecInicio.Enabled = true;
                        dateTimePickerFecFin.Enabled = true;
                        CmbEstado.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtCedula: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                CmbEstado.Enabled = true;
                dateTimePickerFecInicio.Enabled = true;
                dateTimePickerFecFin.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnBuscar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    dateTimePickerFecInicio.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbEstado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dateTimePickerFecInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    dateTimePickerFecFin.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error DateTimeFechaInicio: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dateTimePickerFecFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    BtnModificar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error DateTimefechaFin: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Las Vacaciones no han sido registradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
