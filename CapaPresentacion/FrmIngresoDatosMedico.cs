using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

using CLogic;

namespace CapaPresentacion
{
    public partial class FrmIngresoDatosMedico : Form
    {
        public FrmIngresoDatosMedico()
        {
            InitializeComponent();
            GbxFechas.Visible = false;

        }

        readonly Medico objMedico = new Medico();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        readonly ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPoblacion objOperacionesPoblacion = new ClOperacionesPoblacion();

        private void FrmIngresoDatosMedico_Load(object sender, EventArgs e)
        {
            List<string> tipos = objOperacionesPoblacion.CargarPoblaciones();

            foreach (string tipo in tipos)
                CmbPoblacion.Items.Add(tipo);
            tipos = objOperacionesMedico.CargarTiposMedicos();

            foreach (string tipo in tipos)
                CmbTipo.Items.Add(tipo);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarCedula(TxtCedula.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarNombre(txtNombre.Text))
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

        private void dateTimePickerFecNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxtDireccion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarDireccion(TxtDireccion.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[3], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        TxtNumSegSocial.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNumSegSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarNumeroSeguroSocial(TxtNumSegSocial.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[2], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        CmbTipo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesMedico.ValidarTipoMedico(CmbTipo.SelectedIndex + 1))
                        MessageBox.Show($"Error --: " + objMensajes.errores[9], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        txtNumColegiado.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbTipoModificar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumColegiado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesMedico.ValidarNumColegiado(txtNumColegiado.Text))
                        MessageBox.Show($"Error --: " + objMensajes.errores[11], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        CmbPoblacion.Focus();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtNumeroColediado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbPoblacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesPoblacion.ValidarPoblacion(CmbTipo.SelectedIndex + 1))
                        MessageBox.Show($"Error --: " + objMensajes.errores[11], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dateTimePickerFecAlta.Focus();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbPoblacionModificar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecAlta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dateTimePickerFecBaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                BtnRegistrar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error DateTimeFechaBaja: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecBaja_ValueChanged(object sender, EventArgs e)
        {

            
        }
        private void dateTimePickerFecBaja_CloseUp(object sender, EventArgs e)
        {
            if (!objOperacionesMedico.ValidarFechasSutituto(CmbTipo.SelectedIndex + 1, dateTimePickerFecAlta.Value, dateTimePickerFecBaja.Value))
            {
                MessageBox.Show($"Error --: " + objMensajes.errores[13], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerFecBaja.Value = DateTime.Today;
            }
            else
                dateTimePickerFecAlta.Focus();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objMedico.Nombre = txtNombre.Text;
                objMedico.Cedula = TxtCedula.Text;
                objMedico.NumSegSocial = TxtNumSegSocial.Text;
                objMedico.NumColegiado = txtNumColegiado.Text;
                objMedico.Tipo = CmbTipo.SelectedIndex + 1;

                if(objMedico.Tipo == 3)
                {
                    objMedico.FechaA = dateTimePickerFecAlta.Value;
                    objMedico.FechaB = dateTimePickerFecBaja.Value;
                }
                else
                {
                    objMedico.FechaA = DateTime.Now;
                    objMedico.FechaB = DateTime.Now;
                }
                objMedico.FechaNacimiento = dateTimePickerFecNac.Value;
                
                objMedico.Poblacion = CmbPoblacion.SelectedIndex + 1; //debe ser de un combobox;
                objMedico.Estado = 1 ;
                objMedico.Direccion = TxtDireccion.Text;

                string estado = objOperacionesMedico.RegistrarMedico(objMedico).ToString();
                if (estado == "CORRECTO")
                {
                    MessageBox.Show("Registro realizado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (estado == "2627")
                    MessageBox.Show(objMensajes.errores[19], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"El medico no ha sido modificado", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CmbTipo.SelectedIndex == 2)
            {
                GbxFechas.Visible = true;
                dateTimePickerFecAlta.Enabled = true;
                dateTimePickerFecBaja.Enabled = true;
            }
            else
            {
                GbxFechas.Visible = false;
            }
        }

        







        //private void txtNIF_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void FrmIngresoDatosMedico_Load(object sender, EventArgs e)
        //{

        //}

        //private void BtnIngresar_Click(object sender, EventArgs e)
        //{
        //    objMedico.Nombre = "Fern";
        //    objMedico.Cedula = "0604401919";
        //    objMedico.NumSegSocial = "546-53-9380";
        //    objMedico.NumColegiado = "123456789";
        //    objMedico.Tipo = 1;
        //    objMedico.FechaA = DateTime.Now.AddDays(-9);
        //    objMedico.FechaB = DateTime.Now;
        //    objMedico.Poblacion = 1;
        //    objMedico.Direccion = "es por alla cerca de aquí";

        //    //string estado = objOperaciones.ActualizarMedico(objMedico);
        //    string estado = objOperaciones.RegistrarMedico(objMedico);
        //    //string estado = objOperaciones.EliminarMedico(objMedico.Cedula);
        //    if (estado == "CORRECTO")
        //        MessageBox.Show("Registro realizado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    else if (estado == "2627")
        //        MessageBox.Show(objMensajes.errores[16], "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    else
        //        MessageBox.Show(estado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //}

        //private void LblTituloInicio_Click(object sender, EventArgs e)
        //{
        //}

        //private void BtnRegistrar_Click(object sender, EventArgs e)
        //{
        //    //objMedico.Nombre = txtNombre.Text;
        //    //objMedico.Cedula = txtNIF.Text;
        //    //objMedico.NumSegSocial = txtSeguridadSocial.Text;
        //    //objMedico.NumColegiado = txtNumColegiado.Text;
        //    //objMedico.Tipo = cm;
        //    //objMedico.FechaNacimiento = dateTimePickerFecNac.Value;
        //    //objMedico.FechaA = DateTime.Now.AddDays(-6);
        //    //objMedico.FechaB = DateTime.Now;
        //    //objMedico.Poblacion = 1; //debe ser de un combobox;
        //    //objMedico.Estado = 1;
        //    //objMedico.Direccion = txtDireccion.Text;

        //    string estado = objOperaciones.RegistrarMedico(objMedico).ToString();
        //    if (estado == "CORRECTO")
        //        MessageBox.Show("Registro realizado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    else
        //        MessageBox.Show(estado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //}
    }
}



