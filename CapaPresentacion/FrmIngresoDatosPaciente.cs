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
    public partial class FrmIngresoDatosPaciente : Form
    {

        public FrmIngresoDatosPaciente()
        {
            InitializeComponent();
        }

        readonly Paciente objPaciente = new Paciente();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        readonly ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPaciente objOperacionesPaciente = new ClOperacionesPaciente();

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
                        TxtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error --: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objPaciente.Nombre = TxtNombre.Text;
                objPaciente.Cedula = TxtCedula.Text;
                objPaciente.NumSegSocial = TxtNumSegSocial.Text;

                objPaciente.FechaNacimiento = dateTimePickerFecNac.Value;

                objPaciente.Estado = 1;
                objPaciente.Direccion = TxtDireccion.Text;
                objPaciente.Medico = objOperacionesMedico.CargarCedulasMedicos()[CmbMedicoAsignado.SelectedIndex];

                string estado = objOperacionesPaciente.RegistrarPaciente(objPaciente).ToString();
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

        private void CmbMedicoAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmIngresoDatosPaciente_Load(object sender, EventArgs e)
        {
            List<string> tipos = objOperacionesMedico.CargarNombresMedicos();

            foreach (string tipo in tipos)
                CmbMedicoAsignado.Items.Add(tipo);

            CmbMedicoAsignado.SelectedIndex = 0;
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
                        BtnRegistrar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
