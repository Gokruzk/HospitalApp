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
    public partial class FrmBuscarEmpleado : Form
    {
        Empleado objEmpleado = new Empleado();
        readonly ClOperacionesEmpleado objOperacionesEmpleado = new ClOperacionesEmpleado();
        readonly ClOperacionesPoblacion objOperacionPoblacion = new ClOperacionesPoblacion();

        public FrmBuscarEmpleado()
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCampo.SelectedIndex == 0) //|| CmbCampo.SelectedItem.ToString() == "NUM.SEGURIDAD SOCIAL")
                {
                    objEmpleado = objOperacionesEmpleado.BuscarEmpleado(TxtEleccion.Text);

                    if (objEmpleado != null) {
                        asignar();
                    } else {
                        MessageBox.Show("No se encuentra a un empleado con la cédula ingresada en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (CmbCampo.SelectedIndex == 1) {
                    objEmpleado = objOperacionesEmpleado.BuscarEmpleadoNumSocial(TxtEleccion.Text);

                    if (objEmpleado != null) {
                        asignar();
                    } else {
                        MessageBox.Show("No se encuentra a un empleado con el NSS ingresado en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnBuscar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void asignar() {
            lblNombre.Text = "NOMBRE:     " + objEmpleado.Nombre;
            LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:     " + objEmpleado.FechaNacimiento.ToShortDateString();
            LblDireccion.Text = "DIRECCIÓN:     " + objEmpleado.Direccion;
            LblPoblacion.Text = "POBLACIÓN:     " + objOperacionPoblacion.CargarPoblacion(objEmpleado.Poblacion - 1);
            LblTipo.Text = "TIPO EMPLEADO:   " + objOperacionesEmpleado.CargarTiposEmpleado()[objEmpleado.Tipo - 1];
            LblNumSegSocial.Text = "NÚMERO DE\nSEGURIDAD SOCIAL:    " + objEmpleado.NumSegSocial;

            string[] estado = { "Habilitado", "No habilitado" };

            LblEstado.Text = "ESTADO:     " + estado[objEmpleado.Estado - 1];
        }
    }
}