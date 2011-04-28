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
    public partial class FormCadRecados : FormCadastro
    {
        private static RecadosWeb.RecadosWebSoapClient recadosWeb = new RecadosWeb.RecadosWebSoapClient("RecadosWebSoap", "http://localhost:1186/WebServices/RecadosWeb.asmx");
        private static CondominioWeb.CondominioWebSoapClient condominioWeb = new CondominioWeb.CondominioWebSoapClient("CondominioWebSoap", "http://localhost:1186/WebServices/CondominioWeb.asmx");

        public FormCadRecados()
            : base()
        {
            InitializeComponent();
            TabelaData.DataSource = recadosWeb.RetornaLista(Funcoes.Acesso);
            TabelaData.Columns[TabelaData.Columns.Count - 1].Visible = false;
            cmbCondominio.DataSource = condominioWeb.RetornaLista(Funcoes.Acesso);
            cmbCondominio.DisplayMember = "nome";
            cmbCondominio.ValueMember = "idcondominios";
        }

        public override void ClearFields()
        {
            lblIdentificacao.Text = "";
            txtTitulo.Text = "";
            rchTexto.Text = "";
            cmbCondominio.Text = "";
        }
       
        public override void Populate()
        {
            RecadosWeb.recado recados = recadosWeb.RetornaItem(Convert.ToInt32(TabelaData.SelectedRows[0].Cells[0].Value),Funcoes.Acesso);
            lblIdentificacao.Text = recados.idrecados.ToString();
            txtTitulo.Text = recados.Título;
            rchTexto.Text = recados.Texto;
            cmbCondominio.SelectedValue = recados.idcondominios;
           
        }
        
        public override void Atualizar(int id)
        {
            RecadosWeb.recado recados = new RecadosWeb.recado();
          
            recados.idrecados = Convert.ToInt32(lblIdentificacao.Text);
            recados.Título = txtTitulo.Text;
            recados.Texto = rchTexto.Text;
            recados.idcondominios = Convert.ToInt32(cmbCondominio.SelectedValue);

            if(recadosWeb.SalvaRecado(recados,Funcoes.Acesso))
            {
                MessageBox.Show("Salvo com sucesso!");
                base.Atualizar(id);
            }
            else
            {
              MessageBox.Show("Erro ao salvar!");
            }
        }

        protected override void Paginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabelaData.DataSource = recadosWeb.RetornaLista(Funcoes.Acesso);
            base.Paginas_SelectedIndexChanged(sender, e);
        }

        public override void Adicionar()
        {
            RecadosWeb.recado recados = new RecadosWeb.recado();
            
            recados.Título = txtTitulo.Text;
            recados.Texto = rchTexto.Text;
            recados.idcondominios = Convert.ToInt32(cmbCondominio.SelectedValue);

            if (recadosWeb.AdicionaRecado(recados,Funcoes.Acesso))
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
            if (recadosWeb.Apagar(id,Funcoes.Acesso))
            {
                MessageBox.Show("Excluido com sucesso!");
                TabelaData.DataSource = recadosWeb.RetornaLista(Funcoes.Acesso);
                base.Excluir(id);
            }
            else
            {
                MessageBox.Show("Falha ao excluir!");
            }
        }
        
     }
}
