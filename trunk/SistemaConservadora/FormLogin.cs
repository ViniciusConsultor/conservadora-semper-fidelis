using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaConservadora
{
    public partial class FormLogin : Form
    {
        public bool   login;
        private static ConexaoWS.ConexaoWSSoapClient conexaoWS = new ConexaoWS.ConexaoWSSoapClient("ConexaoWSSoap", "http://localhost:1186/WebServices/ConexaoWS.asmx");
        public FormLogin()
        {
            InitializeComponent();
            login = false;
        }

   
        private void txtSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "Conservadora123")
            {
                login = true;
                conexaoWS.Conectar();
                this.Close();
            }
            else
            {
                login = false;
                MessageBox.Show("Usuário e senha inválidos!");
            }
        }
    }
}
