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
    public partial class FormCadCondominio : FormCadastro
    {
        private static CondominioWeb.CondominioWebSoapClient condominioWeb = new CondominioWeb.CondominioWebSoapClient("CondominioWebSoap", Funcoes.Servidor + "CondominioWeb.asmx");

        public FormCadCondominio() : base()
        {
            InitializeComponent();
            TabelaData.DataSource = condominioWeb.RetornaLista(Funcoes.Acesso);
            TabelaData.Columns[TabelaData.Columns.Count - 1].Visible = false;
        }

        public override void ClearFields()
        {
            lblIdentificacao.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
        }
       
        public override void Populate()
        {
            CondominioWeb.condominio condominio = condominioWeb.RetornaItem(Convert.ToInt32(TabelaData.SelectedRows[0].Cells[0].Value),Funcoes.Acesso);
            lblIdentificacao.Text = condominio.idcondominios.ToString();
            txtNome.Text = condominio.nome;
            txtEndereco.Text = condominio.endereco;         
           
        }
        
        public override void Atualizar(int id)
        {
            CondominioWeb.condominio condominio = new CondominioWeb.condominio();
          
            condominio.idcondominios = Convert.ToInt32(lblIdentificacao.Text);
            condominio.nome = txtNome.Text;
            condominio.endereco = txtEndereco.Text;

            if(condominioWeb.SalvaCondominio(condominio,Funcoes.Acesso))
            {
                MessageBox.Show("Salvo com sucesso!");
                base.Atualizar(id);
            }
            else
            {
              MessageBox.Show("Erro ao adicionar!");
            }
        }

        protected override void Paginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabelaData.DataSource = condominioWeb.RetornaLista(Funcoes.Acesso);
            base.Paginas_SelectedIndexChanged(sender, e);
        }

        public override void Adicionar()
        {
            CondominioWeb.condominio condominio = new CondominioWeb.condominio();
            condominio.nome = txtNome.Text;
            condominio.endereco = txtEndereco.Text;
            if (condominioWeb.AdicionaCondominio(condominio,Funcoes.Acesso))
            {
                MessageBox.Show("Adicionado com sucesso!");
                base.Adicionar();
            }
            else
            {
                MessageBox.Show("Falha na adição");
            }
        }

        public override void Excluir(int id)
        {
            if (condominioWeb.Apagar(id,Funcoes.Acesso))
            {
                MessageBox.Show("Excluido com sucesso!");
                TabelaData.DataSource = condominioWeb.RetornaLista(Funcoes.Acesso);
                base.Excluir(id);
            }
            else
            {
                MessageBox.Show("Falha ao excluir!");
            }
        }
        
     }
}
