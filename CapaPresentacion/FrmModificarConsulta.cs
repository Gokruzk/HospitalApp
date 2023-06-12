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
    public partial class FrmModificarConsulta : Form
    {
        Consulta objConsulta = new Consulta();
        readonly ClOperacionesConsultas objOperacionesConsulta = new ClOperacionesConsultas();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        readonly ClOperacionesPaciente objOperacionesPaciente = new ClOperacionesPaciente();

        public FrmModificarConsulta()
        {
            InitializeComponent();

            CmbPaciente.Enabled = false;
            CmbMedicoAsignado.Enabled = false;
            dateTimePickerFecha.Enabled = false;
            TxtDescripcion.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void TxtEleccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    BtnBuscar.Enabled = true;
                    BtnBuscar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtEleccion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void visibilizar() {
            CmbPaciente.Enabled = true;
            CmbMedicoAsignado.Enabled = true;
            dateTimePickerFecha.Enabled = true;
            TxtDescripcion.Enabled = true;
            BtnModificar.Enabled = true;
        }

        private void asignar() {
            CmbPaciente.SelectedItem = objOperacionesPaciente.CargarPacienteCedula(objConsulta.Paciente).Nombre;
            CmbMedicoAsignado.SelectedItem = objOperacionesMedico.CargarMedicoCedula(objConsulta.Medico).Nombre;
            dateTimePickerFecha.Value = objConsulta.Fecha;
            TxtDescripcion.Text = objConsulta.Descripcion;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                objConsulta = objOperacionesConsulta.BuscarConsulta(TxtEleccion.Text);

                if (objConsulta != null) {
                    visibilizar();
                    asignar();

                } else {
                    MessageBox.Show("No se encuentra la consulta con el id ingresado en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnBuscar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    BtnModificar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtDescripcion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                objConsulta.Paciente = objOperacionesPaciente.CargarCedulasPacientes()[CmbPaciente.SelectedIndex];
                objConsulta.Medico = objOperacionesMedico.CargarCedulasMedicos()[CmbMedicoAsignado.SelectedIndex];
                objConsulta.Fecha = dateTimePickerFecha.Value;
                objConsulta.Descripcion = TxtDescripcion.Text;

                objOperacionesConsulta.ActualizarConsulta(objConsulta);
                MessageBox.Show("Modificación realizada correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"La consulta no ha sido registrada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmModificarConsulta_Load(object sender, EventArgs e) {
            List<string> tipos = objOperacionesMedico.CargarNombresMedicos();

            foreach (string tipo in tipos)
                CmbMedicoAsignado.Items.Add(tipo);

            tipos = objOperacionesPaciente.CargarNombresPacientes();

            foreach (string tipo in tipos)
                CmbPaciente.Items.Add(tipo);
        }
    }
}
