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
    public partial class FrmBuscarVacaciones : Form
    {
        ClOperacionesVacacion objOperacionesVacacion = new ClOperacionesVacacion();

        public FrmBuscarVacaciones()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Vacaciones> vacaciones = objOperacionesVacacion.CargarVacacionesCedula(TxtCedula.Text);

            int i = 0;
            foreach(Vacaciones vaca in vacaciones)
            {
                dataGridViewVacaciones.Rows.Add();
                dataGridViewVacaciones[0, i].Value = vaca.Cedula;
                dataGridViewVacaciones[1, i].Value = vaca.VID;
                dataGridViewVacaciones[2, i].Value = vaca.Estado;
                dataGridViewVacaciones[3, i].Value = vaca.FechaInicio;
                dataGridViewVacaciones[4, i].Value = vaca.FechaFin;
                    i++;
            }

        }
    }
}
