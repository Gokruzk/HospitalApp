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
        }

        Medico objMedico = new Medico();
        ClOperacionesMedico objOperaciones = new ClOperacionesMedico();

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmIngresoDatosMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarM_Click(object sender, EventArgs e)
        {
            /*objMedico.Nombre = txtNombre.Text;
            objMedico.Cedula = txtNIF.Text;
            objMedico.NumSegSocial = txtSeguridadSocial.Text;
            objMedico.NumColegiado = txtNumColegiado.Text;
            objMedico.Tipo = comboBoxTipoMed.Text;

            objDireccion.Direccion = txtDireccion.Text;
            objDireccion.Telefono = txtTelefono.Text;
            objDireccion.Provincia = comboBoxProvincia.Text;
            objDireccion.CodigoPostal = txtCodigoPostal.Text;

            objPoblacion.Descripcion = txtPoblacion.Text;*/

            objMedico.Nombre = "Prueba";
            objMedico.Cedula = "0604401919";
            objMedico.NumSegSocial = "546-53-9380";
            objMedico.NumColegiado = "123456789";
            objMedico.Tipo = "Médico Sustituto";
            objMedico.FechaA = DateTime.Now.AddDays(-6);
            objMedico.FechaB = DateTime.Now;
            objMedico.Poblacion = 1;
            objMedico.Direccion = "es por alla cerca de aquí";

            MessageBox.Show(objOperaciones.RegistrarMedico(objMedico).ToString());
            objMedico.Nombre = "FernandoNovillo";
            objMedico.Cedula = "0604401919";
            objMedico.NumSegSocial = "546-53-9380";
            objMedico.NumColegiado = "123456789";
            objMedico.Tipo = "Médico Sustituto";
            objMedico.FechaA = DateTime.Now.AddDays(-6);
            objMedico.FechaB = DateTime.Now;
            objMedico.Poblacion = 1;
            objMedico.Direccion = "es por alla cerca de aquí";

            MessageBox.Show(objOperaciones.ActualizarMedico(objMedico).ToString());
        }
    }
}
