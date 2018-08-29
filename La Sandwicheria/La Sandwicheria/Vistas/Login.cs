using La_Sandwicheria.Presentadores;
using La_Sandwicheria.Vistas;
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
            var cajeroSesion = _presentador.InicarSesion(txtUsuario.Text, txtContraseña.Text);
            if (cajeroSesion != null)
            {
                var vistaMenu = new Vistas.Menu(cajeroSesion);
                Hide();
                vistaMenu.ShowDialog();
                Application.Exit();
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
