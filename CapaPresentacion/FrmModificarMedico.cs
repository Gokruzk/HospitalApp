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
    public partial class FrmModificarMedico : Form
    {
        Medico objMedico = new Medico();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        readonly ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPoblacion objOperacionesPoblacion = new ClOperacionesPoblacion();

        public FrmModificarMedico()
        {
            InitializeComponent();


            txtNombreModificar.Enabled = false;
            dateTimePickerFecNac.Enabled = false;
            txtDireccion.Enabled = false;  
            TxtNumSegSocial.Enabled = false;
            CmbTipoModificar.Enabled = false;
            txtNumColegiado.Enabled = false;
            CmbPoblacionModificar.Enabled = false;
            GbxTipo.Enabled = false;
            dateTimePickerFecAlta.Enabled = false;
            dateTimePickerFecBaja.Enabled = false;
            CmbHabDes.Enabled = false;
        }

        private void CmbCampo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void visibilizar()
        {
            txtNombreModificar.Enabled = true;
            dateTimePickerFecNac.Enabled = true;
            txtDireccion.Enabled = true;
            TxtNumSegSocial.Enabled = true;
            CmbTipoModificar.Enabled = true;
            txtNumColegiado.Enabled = true;
            CmbPoblacionModificar.Enabled = true;
            GbxTipo.Enabled = true;
            dateTimePickerFecAlta.Enabled = true;
            dateTimePickerFecBaja.Enabled = true;
            CmbHabDes.Enabled = true;
        }

        private void asignar()
        {
            txtNombreModificar.Text = objMedico.Nombre;
            dateTimePickerFecNac.Value = objMedico.FechaNacimiento;
            txtDireccion.Text = objMedico.Direccion;
            TxtNumSegSocial.Text = objMedico.NumSegSocial;
            CmbTipoModificar.SelectedIndex = objMedico.Tipo - 1;
            txtNumColegiado.Text = objMedico.NumColegiado;
            CmbPoblacionModificar.SelectedIndex = objMedico.Poblacion - 1;
            dateTimePickerFecAlta.Value = objMedico.FechaA;
            dateTimePickerFecBaja.Value = objMedico.FechaB;
            CmbHabDes.SelectedIndex = objMedico.Estado - 1;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(CmbCampo.SelectedItem.ToString() == "CÉDULA") //|| CmbCampo.SelectedItem.ToString() == "NUM.SEGURIDAD SOCIAL")
                {
                    objMedico = objOperacionesMedico.CargarMedicoCedula(TxtEleccion.Text);

                    if (objMedico != null)
                    {
                        visibilizar();
                        asignar();
                    }
                }    
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnBuscar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error txtNombreModificar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error DateTimeFechaNaciemiento: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtDireccion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNumSegSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbTipoModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

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

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtNumeroColediado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbPoblacionModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

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

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error DateTimeFechaBaja: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbHabDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbHabilitadoDeshabilitado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"El medico no ha sido modificado", "Cancalar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmModificarMedico_Load(object sender, EventArgs e)
        {
            List<string> tipos = objOperacionesPoblacion.CargarPoblaciones();

            foreach (string tipo in tipos)
                CmbPoblacionModificar.Items.Add(tipo);
            tipos = objOperacionesMedico.CargarTiposMedicos();

            foreach (string tipo in tipos)
                CmbTipoModificar.Items.Add(tipo);


        }
    }
}
