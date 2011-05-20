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
    public partial class FormCadMoradores : FormCadastro
    {
        private static MoradoresWeb.MoradoresWebSoapClient moradoresWeb = new MoradoresWeb.MoradoresWebSoapClient("MoradoresWebSoap", Funcoes.Servidor + "MoradoresWeb.asmx");
        private static CondominioWeb.CondominioWebSoapClient condominioWeb = new CondominioWeb.CondominioWebSoapClient("CondominioWebSoap", Funcoes.Servidor + "CondominioWeb.asmx");
        
        private List<MoradoresWeb.condominio> condominioLista;
       
        public FormCadMoradores():base()
        {
            InitializeComponent();
            TabelaData.DataSource = moradoresWeb.RetornaLista(Funcoes.Acesso);
            TabelaData.Columns[TabelaData.Columns.Count - 1].Visible = false;
            TabelaData.Columns["senha"].Visible = false;
        
            comboCondominios.DataSource = condominioWeb.RetornaLista(Funcoes.Acesso);
            comboCondominios.DisplayMember = "nome";
            comboCondominios.ValueMember = "IdCondominios";
            condominioLista = new List<MoradoresWeb.condominio>();

        }

        public override void ClearFields()
        {
            lblIdentificacao.Text = "";
            txtCPF.Text = "";
            txtLogin.Text = "";
            txtNome.Text = ""; 
            comboCondominios.Text = "";
            condominioLista.Clear();
            TabelaCondominioData.DataSource = condominioLista;
        }

        public override void Populate()
        {
            MoradoresWeb.moradores morador = moradoresWeb.RetornaItem(Convert.ToInt32(TabelaData.SelectedRows[0].Cells[0].Value), Funcoes.Acesso);
            
            lblIdentificacao.Text = morador.idmoradores.ToString();
            
            txtNome.Text = morador.nome;
            txtCPF.Text = morador.cpf;
            txtLogin.Text = morador.login;

            condominioLista = moradoresWeb.Retornacondominios(morador.idmoradores,Funcoes.Acesso).ToList();

            TabelaCondominioData.DataSource = condominioLista.ToArray();
        }

        private void btnAddCondominio_Click(object sender, EventArgs e)
        {          
            MoradoresWeb.condominio condo = moradoresWeb.RetornaCondominio(Convert.ToInt32(comboCondominios.SelectedValue), Funcoes.Acesso);
       
            if (condominioLista.Where(p => p.idcondominios == condo.idcondominios).Count() > 0) 
            {
                MessageBox.Show("Condominio já cadastrado para este morador!", "Atenção!");
            }
            else
            {
                condominioLista.Add(condo);
                TabelaCondominioData.DataSource = condominioLista.ToArray();
                TabelaCondominioData.Columns[TabelaCondominioData.Columns.Count - 1].Visible = false;
                TabelaCondominioData.Refresh();
            }
        }

        private void comboCondominios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRmvCondominio_Click(object sender, EventArgs e)
        {
            if (TabelaCondominioData.SelectedRows.Count > 0)
            {
                condominioLista.RemoveAt(TabelaCondominioData.SelectedRows[0].Index);

                TabelaCondominioData.DataSource = condominioLista.ToArray();
                TabelaCondominioData.Columns[TabelaCondominioData.Columns.Count - 1].Visible = false;
                TabelaCondominioData.Refresh();
            }
        }

        public override void Atualizar(int id)
        {
            MoradoresWeb.moradores morador = new MoradoresWeb.moradores();
            morador.idmoradores = id;
            morador.nome = txtNome.Text;
            morador.cpf = txtCPF.Text;
            morador.login = txtLogin.Text;

            if (moradoresWeb.SalvaMorador(morador, Funcoes.Acesso))
            {
                if (moradoresWeb.Salvacondominios(condominioLista.ToArray(), morador.idmoradores, Funcoes.Acesso))
                {
                    MessageBox.Show("Gravado com sucesso!");
                    base.Atualizar(id);
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar os condomínios");
                }
            }
            else
            {

                MessageBox.Show("Erro ao Atualizar o Morador");
            }
        }

        public override void Adicionar()
        {
            MoradoresWeb.moradores moradores = new MoradoresWeb.moradores();
            moradores.idmoradores = 0;
            moradores.nome = txtNome.Text;
            moradores.cpf = txtCPF.Text;
            moradores.login = txtLogin.Text;
            int id;
            if ((id = moradoresWeb.AdicionaMorador(moradores, Funcoes.Acesso)) > 0)
            {
                if (moradoresWeb.Salvacondominios(condominioLista.ToArray(), id, Funcoes.Acesso))
                {
                    MessageBox.Show("Salvo com sucesso!");
               
                    base.Adicionar();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar os condomínios!");
                }
            }
            else
            {
                MessageBox.Show("Erro ao adicionar!");
            }
        }
        public override void Excluir(int id)
        {
            if (moradoresWeb.Apagar(id, Funcoes.Acesso))
            {
                MessageBox.Show("Excluido com sucesso!");
                TabelaData.DataSource = moradoresWeb.RetornaLista(Funcoes.Acesso);
                base.Excluir(id);
            }
            else
            {
                MessageBox.Show("Falha ao excluir!");
            }
        }

        protected override void Paginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabelaData.DataSource = moradoresWeb.RetornaLista(Funcoes.Acesso);
            base.Paginas_SelectedIndexChanged(sender, e);
        }
    }
}
