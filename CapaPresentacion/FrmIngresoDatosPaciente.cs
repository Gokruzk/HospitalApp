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

        readonly Paciente objMedico = new Paciente();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        readonly ClOperacionesPersona objOperacionesPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPoblacion objOperacionesPoblacion = new ClOperacionesPoblacion();

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void CmbMedicoAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmIngresoDatosPaciente_Load(object sender, EventArgs e)
        {
            List<string> tipos = objOperacionesMedico.CargarNombresMedicos();

            foreach (string tipo in tipos)
                CmbMedicoAsignado.Items.Add(tipo);
        }
    }
}
