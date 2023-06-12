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

namespace CapaPresentacion
{
    public partial class FrmIngreso : Form
    {
        ClOperacionesAdmin Usuario = new ClOperacionesAdmin();
        //string User, Pasw;
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    TxtContrasenia.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtUsuario: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    BtnIngresar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error TxtContraseña: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (Usuario.VerificarUsuario(TxtUsuario.Text, TxtContrasenia.Text))
            {
                FrmMenu objMenu = new FrmMenu();
                objMenu.ShowDialog();
                MessageBox.Show($"Bienvenido {TxtUsuario.Text}", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show($"Credenciales incorrectas...", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
