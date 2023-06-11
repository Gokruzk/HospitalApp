﻿using System;
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


        }

        readonly Medico objMedico = new Medico();
        readonly ClOperacionesMedico objOperaciones = new ClOperacionesMedico();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPoblacion objCargaPoblacion = new ClOperacionesPoblacion();
        List<string> tiposPoblacion = new List<string>();

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                txtNombre.Focus();
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
                dateTimePickerFecNac.Focus();
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
                TxtNumSegSocial.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNumSegSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
<<<<<<< HEAD
             tiposPoblacion = objCargaPoblacion.CargarPoblaciones();

            foreach(string tipo in tiposPoblacion)
            {
                CmbPoblacionModificar.Items.Add(tipo);
=======
            try
            {
                CmbTipo.Focus();
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
                txtNumColegiado.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbTipoModificar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> Agregado KeyPress en formularios de Ingreso, Modificacion y Busqueda.
            }
        }

        private void txtNumColegiado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CmbPoblacion.Focus();
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
                dateTimePickerFecAlta.Focus();
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

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

