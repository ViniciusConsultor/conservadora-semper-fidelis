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
        private static RecadosWeb.RecadosWebSoapClient recadosWeb = new RecadosWeb.RecadosWebSoapClient("RecadosWebSoap", Funcoes.Servidor + "RecadosWeb.asmx");
        private static CondominioWeb.CondominioWebSoapClient condominioWeb = new CondominioWeb.CondominioWebSoapClient("CondominioWebSoap", Funcoes.Servidor + "CondominioWeb.asmx");

        public FormCadRecados()
            : base()
        {
            InitializeComponent();
     
            cmbCondominio.DataSource = condominioWeb.RetornaLista(Funcoes.Acesso);
            cmbCondominio.DisplayMember = "nome";
            cmbCondominio.ValueMember = "idcondominios";
            BindGrid();
        }

        public override void ClearFields()
        {
           
        }
       
        public override void Populate()
        {
             
        }
        
        public override void Atualizar(int id)
        {
            RecadosWeb.recado recados = (RecadosWeb.recado)BDS.Current;                    

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
            
            base.Paginas_SelectedIndexChanged(sender, e);
        }

        public override void Adicionar()
        {
            RecadosWeb.recado recados = (RecadosWeb.recado)BDS.Current;
          
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
            id = (BDS.Current as RecadosWeb.recado).idrecados;
            if (recadosWeb.Apagar(id,Funcoes.Acesso))
            {
                MessageBox.Show("Excluido com sucesso!");
             
                base.Excluir(id);
            }
            else
            {
                MessageBox.Show("Falha ao excluir!");
            }
        }
        public override void BindGrid()
        {
            BDS.Clear();
            foreach (RecadosWeb.recado recado in recadosWeb.RetornaLista(Funcoes.Acesso))
                BDS.Add(recado);
            TabelaData.DataSource = BDS;
        }
     }
}
