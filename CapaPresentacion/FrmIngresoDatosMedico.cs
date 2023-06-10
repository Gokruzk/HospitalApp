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
        /*Entidades objEntidades = new Entidades();
        ClOperaciones objOperaciones = new ClOperaciones();*/

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmIngresoDatosMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarM_Click(object sender, EventArgs e)
        {
          /*  objEntidades.IdMedico = txtID.Text;
            objEntidades.Nombre = txtNombre.Text;
            objEntidades.Direccion = txtDireccion.Text;
            objEntidades.Telefono = txtTelefono.Text;
            objEntidades.Poblacion = txtPoblacion.Text;
            objEntidades.Provincia = comboBoxProvincia.Text;
            objEntidades.CodigoPostal = txtCodigoPostal.Text;
            objEntidades.NIF = txtNIF.Text;
            objEntidades.NumSegSocial = txtSeguridadSocial.Text;
            objEntidades.Colegiado = txtNumColegiado.Text;
            objEntidades.TipoMedico = comboBoxTipoMed.Text;*/
          
        }
    }
}
