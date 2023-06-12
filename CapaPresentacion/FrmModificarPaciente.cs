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
    public partial class FrmModificarPaciente : Form
    {
        Paciente objPaciente = new Paciente();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        readonly ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPaciente objOperacionesPaciente = new ClOperacionesPaciente();

        public FrmModificarPaciente()
        {
            InitializeComponent();
            txtNombreModificar.Enabled = false;
            dateTimePickerFecNac.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtNumSegSocial.Enabled = false;
            CmbMedicoAsignado.Enabled = false;
            CmbHabDes.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void CmbCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            
        }

        private void TxtEleccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            
        }

        private void visibilizar()
        {
            txtNombreModificar.Enabled = true;
            dateTimePickerFecNac.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtNumSegSocial.Enabled = true;
            CmbMedicoAsignado.Enabled = true;
            CmbHabDes.Enabled = true;
            BtnModificar.Enabled = true;
        }

        private void asignar()
        {
            txtNombreModificar.Text = objPaciente.Nombre;
            dateTimePickerFecNac.Value = objPaciente.FechaNacimiento;
            TxtDireccion.Text = objPaciente.Direccion;
            TxtNumSegSocial.Text = objPaciente.NumSegSocial;
            CmbMedicoAsignado.SelectedItem = objOperacionesMedico.CargarMedicoCedula(objPaciente.Medico).Nombre;
            CmbHabDes.SelectedIndex = objPaciente.Estado - 1;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (CmbCampo.SelectedIndex == 0) 
                {
                    objPaciente = objOperacionesPaciente.CargarPacienteCedula(TxtEleccion.Text);

                    if (objPaciente != null)
                    {
                        visibilizar();
                        asignar();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra a un paciente con la cédula ingresada en la base de datos","INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (CmbCampo.SelectedIndex == 1)
                {
                    objPaciente = objOperacionesPaciente.CargarPacienteNS(TxtEleccion.Text);

                    if (objPaciente != null)
                    {
                        visibilizar();
                        asignar();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra a un paciente con el NSS ingresado en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (!objOperacionesPersona.ValidarNombre(txtNombreModificar.Text))
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    TxtDireccion.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error DateTimeFechaInicio: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                        CmbMedicoAsignado.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbMedicoAsignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CmbHabDes.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbMedicoAsignado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CmbHabDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    BtnModificar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbHabilitado/Deshabilitado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    objPaciente.Nombre = txtNombreModificar.Text;
                    objPaciente.NumSegSocial = TxtNumSegSocial.Text;

                    objPaciente.FechaNacimiento = dateTimePickerFecNac.Value;

                    objPaciente.Estado = CmbHabDes.SelectedIndex + 1;
                    objPaciente.Medico = objOperacionesMedico.CargarCedulasMedicos()[CmbMedicoAsignado.SelectedIndex];
                    objPaciente.Direccion = TxtDireccion.Text;


                    objOperacionesPaciente.ActualizarPaciente(objPaciente);
                    MessageBox.Show("Modificación realizada correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"El Paciente no han sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmModificarPaciente_Load(object sender, EventArgs e)
        {
            List<string> tipos = objOperacionesMedico.CargarNombresMedicos();

            foreach (string tipo in tipos)
                CmbMedicoAsignado.Items.Add(tipo);

            CmbMedicoAsignado.SelectedItem = "";
        }
    }
}
