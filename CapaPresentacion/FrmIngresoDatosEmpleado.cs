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
    public partial class FrmIngresoDatosEmpleado : Form
    {
        Empleado objEmpleado = new Empleado();
        ClOperacionesEmpleado objValidacionEmpleado = new ClOperacionesEmpleado();

        public FrmIngresoDatosEmpleado()
        {
            InitializeComponent();
            
            TxtNombre.Enabled = false;
            dateTimePickerFecNac.Enabled = false;
            TxtDireccion.Enabled = false;
            CmbPoblacion.Enabled = false;
            CmbTipo.Enabled = false;
            TxtNumSegSocial.Enabled = false;

            BtnRegistrar.Enabled = false;   
        }

        

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxtNombre.Enabled = true;
                TxtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error TxtCedula: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dateTimePickerFecNac.Enabled= true;
                dateTimePickerFecNac.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error txtNombre: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxtDireccion.Enabled= true;
                TxtDireccion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error DateTimeFechaNacimiento: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CmbPoblacion.Enabled= true;
                CmbPoblacion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error txtDireccion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbPoblacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CmbTipo.Enabled= true;
                CmbTipo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbPoblacion: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxtNumSegSocial.Enabled= true;
                TxtNumSegSocial.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error CmbTipo: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

<<<<<<< HEAD
        private void BtnRegistrar_Click(object sender, EventArgs e) {
            objEmpleado.Cedula = "0503959447";
            objEmpleado.Nombre = "Kevin Tapia";
            objEmpleado.Direccion = "Av. Canonigo Ramos";
            objEmpleado.NumSegSocial = "433-69-6684";
            //objEmpleado.Tipo = "Administrativo";
            objEmpleado.Poblacion = 1;
=======
        private void TxtNumSegSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                BtnRegistrar.Enabled= true;
                BtnRegistrar.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error txtNumeroSeguridadSocial: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
>>>>>>> Agregado KeyPress en formularios de Ingreso, Modificacion y Busqueda.
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnRegistrar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //objEmpleado.Cedula = "0503959447";
            //objEmpleado.Nombre = "Kevin Tapia";
            //objEmpleado.Direccion = "Av. Canonigo Ramos";
            //objEmpleado.NumSegSocial = "433-69-6684";
            //objEmpleado.Tipo = "Administrativo";
            //objEmpleado.Poblacion = 1;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"El empleado no ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error BtnCancelar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}