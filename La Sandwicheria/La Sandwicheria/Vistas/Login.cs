using La_Sandwicheria.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Sandwicheria
{
    public partial class Login : Form
    {
        private readonly PresentadorLogin _presentador;

        public Login()
        {
            _presentador = new PresentadorLogin();
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (_presentador.InicarSesion(txtUsuario.Text, txtContraseña.Text))
            {
                //var vistaMenu = new VistaMenu();
                //vistaMenu.Show();
            }
            else
            {
                MessageBox.Show("NO SE PUDO INICIAR SESIÓN \nUsuario o contraseña mal ingresados","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
