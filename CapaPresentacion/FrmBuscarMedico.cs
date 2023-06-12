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
    public partial class FrmBuscarMedico : Form
    {
        Medico objMedico = new Medico();
        readonly ClOperacionesMedico objOperacionesMedico = new ClOperacionesMedico();
        readonly ClOperacionesPoblacion objOperacionPoblacion = new ClOperacionesPoblacion();
        public FrmBuscarMedico()
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtElección: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void asignar()
        {
            lblNombre.Text = "NOMBRE:     " + objMedico.Nombre;
            LblFechaNacimiento.Text = "FECHA DE NACIMIENTO:     " + objMedico.FechaNacimiento.ToShortDateString();
            LblDireccion.Text = "DIRECCIÓN:     " + objMedico.Direccion;
            LblNumSegSocial.Text = "NÚMERO DE\nSEGURIDAD SOCIAL:    " + objMedico.NumSegSocial;
            LblTipoMedico.Text = "TIPO MÉDICO:   " + objOperacionesMedico.CargarTiposMedicos()[objMedico.Tipo - 1];
            lblColegiado.Text = "NÚMERO DE COLEGIADO:    " + objMedico.NumColegiado;
            LblPoblacion.Text = "POBLACIÓN:     " + objOperacionPoblacion.CargarPoblacion(objMedico.Poblacion - 1);

            string[] estado = { "Habilitado", "No habilitado" };

            LblEstado.Text = "ESTADO:     " + estado[objMedico.Estado - 1];  
            
            if(objMedico.Tipo == 3)
            {
                LblFechaBaja.Visible = true;
                LblFechaAlta.Visible = true;
                LblFechaAlta.Text = "FECHA DE ALTA:\n" + objMedico.FechaA.ToShortDateString();
                LblFechaBaja.Text = "FECHA DE BAJA:\n" + objMedico.FechaB.ToShortDateString();
            }
            else
            {
                LblFechaBaja.Visible = false;
                LblFechaAlta.Visible = false;
            }
           
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCampo.SelectedIndex == 0) //|| CmbCampo.SelectedItem.ToString() == "NUM.SEGURIDAD SOCIAL")
                {
                    objMedico = objOperacionesMedico.CargarMedicoCedula(TxtEleccion.Text);

                    if (objMedico != null)
                    {
                        asignar();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra a un médico con la cédula ingresada en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (CmbCampo.SelectedIndex == 1)
                {
                    objMedico = objOperacionesMedico.CargarMedicoNS(TxtEleccion.Text);

                    if (objMedico != null)
                    {
                        asignar();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra a un médico con el NSS ingresado en la base de datos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
