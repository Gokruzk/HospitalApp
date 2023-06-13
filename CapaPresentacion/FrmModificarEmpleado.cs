using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLogic;
using Entidades;

namespace CapaPresentacion
{
    public partial class FrmModificarEmpleado : Form
    {
        Empleado objEmpleado = new Empleado();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();
        readonly ClOperacionesEmpleado objOperacionesEmpleado = new ClOperacionesEmpleado();
        readonly ClOperacionesPoblacion objOperacionesPoblacion = new ClOperacionesPoblacion();

        public FrmModificarEmpleado()
        {
            InitializeComponent();

            txtNombre.Enabled = false;
            dateTimePickerFecNac.Enabled = false;
            TxtDireccion.Enabled = false;
            CmbPoblacionModificar.Enabled = false;
            CmbTipo.Enabled = false;
            TxtNumSegSocialModificar.Enabled = false;
            CmbHabilDeshabil.Enabled = false;
        }

        private void FrmModificarEmpleado_Load(object sender, EventArgs e) {
            List<string> tipos = objOperacionesPoblacion.CargarPoblaciones();

            foreach (string tipo in tipos)
                CmbPoblacionModificar.Items.Add(tipo);
            tipos = objOperacionesEmpleado.CargarTiposEmpleado();

            foreach (string tipo in tipos)
                CmbTipo.Items.Add(tipo);
        }

        private void CmbCampo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                try {
                    TxtEleccion.Focus();

                } catch (Exception ex) {
                    MessageBox.Show($"Error CmbCampo: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtEleccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                try {
                    BtnBuscar.Enabled = true;

                } catch (Exception ex) {
                    MessageBox.Show($"Error TxtEleccion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void visibilizar() {
            txtNombre.Enabled = true;
            dateTimePickerFecNac.Enabled = true;
            TxtDireccion.Enabled = true;
            CmbPoblacionModificar.Enabled = true;
            CmbTipo.Enabled = true;
            TxtNumSegSocialModificar.Enabled = true;
            CmbHabilDeshabil.Enabled = true;
        }

        private void asignar() {
            txtNombre.Text = objEmpleado.Nombre;
            dateTimePickerFecNac.Value = objEmpleado.FechaNacimiento;
            TxtDireccion.Text = objEmpleado.Direccion;
            CmbPoblacionModificar.SelectedIndex = objEmpleado.Poblacion - 1;
            CmbTipo.SelectedIndex = objEmpleado.Tipo - 1;
            TxtNumSegSocialModificar.Text = objEmpleado.NumSegSocial;
            CmbHabilDeshabil.SelectedIndex = objEmpleado.Estado - 1;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCampo.Text == "CÉDULA")
                {
                    objEmpleado = objOperacionesEmpleado.BuscarEmpleado(TxtEleccion.Text);

                    if (objEmpleado != null) {
                        visibilizar();
                        asignar();
                        CmbCampo.Enabled = false;
                        TxtEleccion.Enabled = false;

                    } else {
                        MessageBox.Show("No se encuentra a un empleado con la cédula ingresada en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (CmbCampo.Text == "NUM. SEGURIDAD SOCIAL") {
                    objEmpleado = objOperacionesEmpleado.BuscarEmpleadoNumSocial(TxtEleccion.Text);

                    if (objEmpleado != null) {
                        visibilizar();
                        asignar();

                    } else {
                        MessageBox.Show("No se encuentra a un empleado con el NSS ingresado en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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
                    if (e.KeyChar == (char)Keys.Enter) {
                        e.Handled = true;
                        if (!objOperacionesPersona.ValidarNombre(txtNombre.Text))
                            MessageBox.Show($"Error --: " + objMensajes.errores[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            dateTimePickerFecNac.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtNombre: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dateTimePickerFecNac_ValueChanged(object sender, EventArgs e) {
            try {
                dateTimePickerFecNac.MaxDate = DateTime.Today.AddYears(-18);
                dateTimePickerFecNac.MinDate = DateTime.Today.AddYears(-100);

                TxtDireccion.Focus();

            } catch (Exception ex) {
                MessageBox.Show($"Error DateTimeFechaNacimiento: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (e.KeyChar == (char)Keys.Enter) {
                        e.Handled = true;
                        if (!objOperacionesPersona.ValidarDireccion(TxtDireccion.Text))
                            MessageBox.Show($"Error --: " + objMensajes.errores[3], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            CmbPoblacionModificar.Focus();
                    }
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
                    CmbTipo.Focus();
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
                    if (e.KeyChar == (char)Keys.Enter) {
                        e.Handled = true;
                        if (!objOperacionesEmpleado.ValidarTipoEmpleado(CmbTipo.SelectedIndex + 1))
                            MessageBox.Show($"Error --: " + objMensajes.errores[7], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            TxtNumSegSocialModificar.Focus();
                    }
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
                    if (e.KeyChar == (char)Keys.Enter) {
                        e.Handled = true;
                        if (!objOperacionesPersona.ValidarNumeroSeguroSocial(TxtNumSegSocialModificar.Text))
                            MessageBox.Show($"Error --: " + objMensajes.errores[2], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            CmbHabilDeshabil.Focus();
                    }
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
                    if (e.KeyChar == (char)Keys.Enter) {
                        e.Handled = true;
                        if (!objOperacionesPersona.ValidarEstado(CmbHabilDeshabil.SelectedIndex + 1))
                            MessageBox.Show($"Error --: " + objMensajes.errores[6], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            BtnModificar.Focus();
                    }
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
                objEmpleado.Nombre = txtNombre.Text;
                objEmpleado.FechaNacimiento = dateTimePickerFecNac.Value;
                objEmpleado.Direccion = TxtDireccion.Text;
                objEmpleado.Poblacion = CmbPoblacionModificar.SelectedIndex + 1;
                objEmpleado.Tipo = CmbTipo.SelectedIndex + 1;
                objEmpleado.NumSegSocial = TxtNumSegSocialModificar.Text;
                objEmpleado.Estado = CmbHabilDeshabil.SelectedIndex + 1;

                string estado = objOperacionesEmpleado.ActualizarEmpleado(objEmpleado);
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
