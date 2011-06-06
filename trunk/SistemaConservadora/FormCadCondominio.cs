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
        private static MoradoresWeb.MoradoresWebSoapClient moradoresWeb = new MoradoresWeb.MoradoresWebSoapClient("MoradoresWebSoap", Funcoes.Servidor + "MoradoresWeb.asmx");
     
        public FormCadCondominio() : base()
        {
            InitializeComponent();
            BindGrid();
            comboBox1.DataSource = moradoresWeb.RetornaLista(Funcoes.Acesso);
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "idmoradores";
        }
        
        public override void ClearFields()
        {
         
        }
       
        public override void Populate()
        {
                
           
        }
        
        public override void Atualizar(int id)
        {
            CondominioWeb.condominio condominio = (CondominioWeb.condominio)BDS.Current;
         
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
       
            base.Paginas_SelectedIndexChanged(sender, e);
        }

        public override void Adicionar()
        {
            CondominioWeb.condominio condominio = (CondominioWeb.condominio)BDS.Current;
       
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
            id = ((CondominioWeb.condominio)BDS.Current).idcondominios;
            if (condominioWeb.Apagar(id,Funcoes.Acesso))
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
            foreach (CondominioWeb.condominio condominio in condominioWeb.RetornaLista(Funcoes.Acesso))
                BDS.Add(condominio);
            TabelaData.DataSource = BDS;
        
        }

        private void TabelaData_DoubleClick(object sender, EventArgs e)
        {

        }
        
     }
}
