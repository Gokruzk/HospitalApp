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
        }

        private void BtnRegistrar_Click(object sender, EventArgs e) {
            objEmpleado.Cedula = "0503959447";
            objEmpleado.Nombre = "Kevin Tapia";
            objEmpleado.Direccion = "Av. Canonigo Ramos";
            objEmpleado.NumSegSocial = "433-69-6684";
            objEmpleado.Tipo = "Administrativo";
            objEmpleado.Poblacion = 1;
        }
    }
}