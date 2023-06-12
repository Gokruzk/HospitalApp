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
    public partial class FrmIngresarConsulta : Form
    {
        Consulta objConsulta = new Consulta();
        ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        ClOperacionesPaciente objOperacionesPaciente = new ClOperacionesPaciente();
        ClOperacionesConsultas objOperacionesConsulta = new ClOperacionesConsultas();

        public FrmIngresarConsulta()
        {
            InitializeComponent();
        }

        private void CmbPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CmbMedicoAsignado.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbPaciente: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CmbMedicoAsignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    dateTimePickerFecha.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error CmbMedicoAsignado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e) {
            try {
                dateTimePickerFecha.MinDate = DateTime.Today;
                dateTimePickerFecha.Format = DateTimePickerFormat.Short;
                TxtDescripcion.Focus();

            } catch (Exception ex) {
                MessageBox.Show($"Error DateTimeFecha: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (objOperacionesConsulta.ValidarDescripcion(TxtDescripcion.Text))
                        BtnRegistrar.Focus();
                    else
                        MessageBox.Show($"Error --: " + objMensajes.errores[8], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtDescripcion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objConsulta.Paciente = objOperacionesPaciente.CargarCedulasPacientes()[CmbPaciente.SelectedIndex];
                objConsulta.Medico = objOperacionesMedico.CargarCedulasMedicos()[CmbMedicoAsignado.SelectedIndex];
                objConsulta.Fecha = dateTimePickerFecha.Value;
                objConsulta.Descripcion = TxtDescripcion.Text;

                string estado = objOperacionesConsulta.RegistrarConsulta(objConsulta);

                if(estado == "CORRECTO")
                    MessageBox.Show("Registro realizado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(estado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtDescripcion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"La consulta no ha sido registrada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIngresarConsulta_Load(object sender, EventArgs e)
        {
            List<string> tipos = objOperacionesMedico.CargarNombresMedicos();

            foreach (string tipo in tipos)
                CmbMedicoAsignado.Items.Add(tipo);

            tipos = objOperacionesPaciente.CargarNombresPacientes();

            foreach(string tipo in tipos)
                CmbPaciente.Items.Add(tipo);    
        }
    }
}
