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

        readonly Medico objMedico = new Medico();
        readonly ClOperacionesMedico objOperaciones = new ClOperacionesMedico();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPoblacion objCargaPoblacion = new ClOperacionesPoblacion();
        List<string> tiposPoblacion = new List<string>();

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmIngresoDatosMedico_Load(object sender, EventArgs e)
        {
             tiposPoblacion = objCargaPoblacion.CargarPoblaciones();

            foreach(string tipo in tiposPoblacion)
            {
                CmbPoblacionModificar.Items.Add(tipo);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            objMedico.Nombre = "Fern";
            objMedico.Cedula = "0604401919";
            objMedico.NumSegSocial = "546-53-9380";
            objMedico.NumColegiado = "123456789";
            objMedico.Tipo = 1;
            objMedico.FechaA = DateTime.Now.AddDays(-9);
            objMedico.FechaB = DateTime.Now;
            objMedico.Poblacion = 1;
            objMedico.Direccion = "es por alla cerca de aquí";

            //string estado = objOperaciones.ActualizarMedico(objMedico);
            string estado = objOperaciones.RegistrarMedico(objMedico);
            //string estado = objOperaciones.EliminarMedico(objMedico.Cedula);
            if (estado == "CORRECTO")
                MessageBox.Show("Registro realizado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (estado == "2627")
                MessageBox.Show(objMensajes.errores[16], "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(estado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void LblTituloInicio_Click(object sender, EventArgs e)
        {
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //objMedico.Nombre = txtNombre.Text;
            //objMedico.Cedula = txtNIF.Text;
            //objMedico.NumSegSocial = txtSeguridadSocial.Text;
            //objMedico.NumColegiado = txtNumColegiado.Text;
            //objMedico.Tipo = cm;
            //objMedico.FechaNacimiento = dateTimePickerFecNac.Value;
            //objMedico.FechaA = DateTime.Now.AddDays(-6);
            //objMedico.FechaB = DateTime.Now;
            //objMedico.Poblacion = 1; //debe ser de un combobox;
            //objMedico.Estado = 1;
            //objMedico.Direccion = txtDireccion.Text;

            string estado = objOperaciones.RegistrarMedico(objMedico).ToString();
            if (estado == "CORRECTO")
                MessageBox.Show("Registro realizado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(estado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

