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
    public partial class FrmBuscarPaciente : Form
    {
        Paciente objPaciente = new Paciente();
        readonly ClOperacionesPaciente objOperacionesPaciente = new ClOperacionesPaciente();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        public FrmBuscarPaciente()
        {
            InitializeComponent();
        }

        private void CmbCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
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
                    BtnBuscar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtElección: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void asignar()
        {
            lblNombre.Text = "NOMBRE:     " + objPaciente.Nombre;
            LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:     " + objPaciente.FechaNacimiento.ToShortDateString();
            LblDireccion.Text = "DIRECCIÓN:     " + objPaciente.Direccion;
            LblNumSegSocial.Text = "NÚMERO DE SEGURIDAD SOCIAL:    " + objPaciente.NumSegSocial;
            LblMedicoAsignado.Text = "MÉDICO ASIGNADO:      " + objOperacionesMedico.CargarMedicoCedula(objPaciente.Medico).Nombre;
            string[] estado = { "Habilitado", "No habilitado" };

            LblEstado.Text = "ESTADO:     " + estado[objPaciente.Estado - 1];


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
                        asignar();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra a un paciente con la cédula ingresada en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (CmbCampo.SelectedIndex == 1)
                {
                    objPaciente = objOperacionesPaciente.CargarPacienteNS(TxtEleccion.Text);

                    if (objPaciente != null)
                    {
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
    }
}
