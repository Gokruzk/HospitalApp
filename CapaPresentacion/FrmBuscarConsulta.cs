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
    public partial class FrmBuscarConsulta : Form
    {
        Consulta objConsulta = new Consulta();
        ClOperacionesConsultas objOperacionesConsulta = new ClOperacionesConsultas();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        readonly ClOperacionesPaciente objOperacionesPaciente = new ClOperacionesPaciente();

        public FrmBuscarConsulta()
        {
            InitializeComponent();
        }

        private void TxtEleccion_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter)
                BtnBuscar.Focus();
        }

        private void asignar() {
            LblPaciente.Text = "PACIENTE:     " + objOperacionesPaciente.CargarPacienteCedula(objConsulta.Paciente).Nombre;
            LblMedico.Text = "MÉDICO ASIGNADO:     " + objOperacionesMedico.CargarMedicoCedula(objConsulta.Medico).Nombre;
            LblFecha.Text = "FECHA:     " + objConsulta.Fecha.ToShortDateString();
            TxtDescripcion.Text = objConsulta.Descripcion;
        }

        private void BtnBuscar_Click(object sender, EventArgs e) {
            objConsulta = objOperacionesConsulta.BuscarConsulta(TxtEleccion.Text);

            if (objConsulta != null) {
                asignar();
            } else {
                MessageBox.Show("No se encuentra la consulta con el id ingresado en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
