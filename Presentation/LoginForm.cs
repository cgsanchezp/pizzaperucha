using PizzaPeruchaApp.Business;
using PizzaPeruchaApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPeruchaApp.Presentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var usuarioService = new UsuarioService(new PizzaPeruchaDbContext());
            var usuario = await usuarioService.AutenticarAsync(txtUsuario.Text, txtContrasenia.Text);

            if (usuario != null)
            {
                MessageBox.Show("Inicio de sesion exitoso.");
            }
            else
            {
                MessageBox.Show("usuario o contrasenia incorrectos");
            }
        }
    }
}
