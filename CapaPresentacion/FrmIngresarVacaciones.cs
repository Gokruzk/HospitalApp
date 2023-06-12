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
    public partial class FrmIngresarVacaciones : Form
    {
        Vacaciones objVacacion = new Vacaciones();
        ClOperacionesVacacion objOperacionesVacacion = new ClOperacionesVacacion();
        ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        ClOperacionesEmpleado objOperacionesEmpleado = new ClOperacionesEmpleado();
        ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
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
                if(e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (objOperacionesEmpleado.BuscarEmpleado(TxtCedula.Text) == null && objOperacionesMedico.CargarMedicoCedula(TxtCedula.Text) == null)
                    {
                        CmbEstado.Enabled = false;
                        dateTimePickerFecInicio.Enabled = false;
                        dateTimePickerFecFin.Enabled = false;
                        MessageBox.Show("No se encuentra la cédula ingresada en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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
                objVacacion.Cedula = TxtCedula.Text;
                objVacacion.FechaInicio = dateTimePickerFecInicio.Value;
                objVacacion.FechaFin = dateTimePickerFecFin.Value;
                objVacacion.Estado = CmbEstado.SelectedIndex + 1;

                string estado = objOperacionesVacacion.RegistrarVacacion(objVacacion);
                if (estado == "CORRECTO")
                    MessageBox.Show("Registro realizado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(estado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnRegistrar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dateTimePickerFecFin_CloseUp(object sender, EventArgs e)
        {
            if (!objOperacionesVacacion.ValidarFechas(dateTimePickerFecInicio.Value, dateTimePickerFecFin.Value))
            {
                MessageBox.Show($"Error --: " + objMensajes.errores[13], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerFecFin.Value = DateTime.Today;
            }
            else
                BtnRegistrar.Focus();
        }
    }
}
