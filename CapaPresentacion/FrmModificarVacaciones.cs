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
        readonly ClOperacionesVacacion objOperacionesVacacion = new ClOperacionesVacacion();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();

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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                objVacacion = objOperacionesVacacion.CargarVacacionCedulaId(TxtCedula.Text, int.Parse(TxtIdVac.Text));

                if (objVacacion != null)
                {
                    CmbEstado.Enabled = true;
                    dateTimePickerFecInicio.Enabled = true;
                    dateTimePickerFecFin.Enabled = true;

                    string[] estado = { "Realizada", "Planificada" };
                    CmbEstado.SelectedIndex = objVacacion.Estado - 1;
                    dateTimePickerFecInicio.Value = objVacacion.FechaInicio;
                    dateTimePickerFecFin.Value = objVacacion.FechaFin;

                    TxtCedula.Enabled = false;
                    TxtIdVac.Enabled = false;
                }
                else
                {
                    CmbEstado.Enabled = false;
                    dateTimePickerFecInicio.Enabled = false;
                    dateTimePickerFecFin.Enabled = false;
                    MessageBox.Show("No se encuentra en la base de datos un registro de vacación correspondiente a la cédula y id ingresados", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
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
                try
                {
                    objVacacion.FechaInicio = dateTimePickerFecInicio.Value;
                    objVacacion.FechaFin = dateTimePickerFecFin.Value;
                    objVacacion.Estado = CmbEstado.SelectedIndex + 1;

                    string estado = objOperacionesVacacion.ActualizarVacacion(objVacacion);
                    if (estado == "CORRECTO")
                    {
                        MessageBox.Show("Modificación realizada correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show(estado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error BtnRegistrar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void dateTimePickerFecFin_CloseUp(object sender, EventArgs e)
        {
            if (!objOperacionesVacacion.ValidarFechas(dateTimePickerFecInicio.Value, dateTimePickerFecFin.Value))
            {
                MessageBox.Show($"Error --: " + objMensajes.errores[13], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerFecFin.Value = DateTime.Today;
            }
            else
                BtnModificar.Focus();
        }
    }
}
