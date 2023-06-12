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
    public partial class FrmIngresoDatosEmpleado : Form
    {
        readonly Empleado objEmpleado = new Empleado();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();
        readonly ClOperacionesEmpleado objOperacionesEmpleado = new ClOperacionesEmpleado();
        readonly ClOperacionesPoblacion objOperacionesPoblacion = new ClOperacionesPoblacion();

        public FrmIngresoDatosEmpleado()
        {
            InitializeComponent();
        }

        private void FrmIngresoDatosEmpleado_Load(object sender, EventArgs e) {
            List<string> tipos = objOperacionesPoblacion.CargarPoblaciones();

            foreach (string tipo in tipos)
                CmbPoblacion.Items.Add(tipo);
            tipos = objOperacionesEmpleado.CargarTiposEmpleado();

            foreach (string tipo in tipos)
                CmbTipo.Items.Add(tipo);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter) {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarCedula(TxtCedula.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        TxtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter) {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarNombre(TxtNombre.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dateTimePickerFecNac.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecNac_ValueChanged(object sender, EventArgs e) {
            try {
                dateTimePickerFecNac.MaxDate = DateTime.Today.AddYears(-18);
                dateTimePickerFecNac.MinDate = DateTime.Today.AddYears(-100);

                dateTimePickerFecNac.Format = DateTimePickerFormat.Short;

                TxtDireccion.Focus();
            } catch (Exception ex) {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter) {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarDireccion(TxtDireccion.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[3], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        CmbPoblacion.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbPoblacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter) {
                    e.Handled = true;
                    if (!objOperacionesPoblacion.ValidarPoblacion(CmbTipo.SelectedIndex + 1))
                        MessageBox.Show($"Error --: " + objMensajes.errores[11], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        CmbTipo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbPoblacion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter) {
                    e.Handled = true;
                    if (!objOperacionesEmpleado.ValidarTipoEmpleado(CmbTipo.SelectedIndex + 1))
                        MessageBox.Show($"Error --: " + objMensajes.errores[7], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        TxtNumSegSocial.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbTipo: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNumSegSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter) {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarNumeroSeguroSocial(TxtNumSegSocial.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[2], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        BtnRegistrar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error txtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrar_Click_1(object sender, EventArgs e)
        {
            try {
                objEmpleado.Cedula = TxtCedula.Text;
                objEmpleado.Nombre = TxtNombre.Text;
                objEmpleado.FechaNacimiento = dateTimePickerFecNac.Value;
                objEmpleado.Direccion = TxtDireccion.Text;
                objEmpleado.Poblacion = CmbPoblacion.SelectedIndex + 1;
                objEmpleado.Tipo = CmbTipo.SelectedIndex + 1;
                objEmpleado.NumSegSocial = TxtNumSegSocial.Text;
                objEmpleado.Estado = 1;

                string estado = objOperacionesEmpleado.RegistrarEmpleado(objEmpleado).ToString();

                if (estado == "CORRECTO")
                    MessageBox.Show("Registro realizado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(estado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error BtnRegistrar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            try {
                MessageBox.Show($"El empleado no ha sido registrado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}