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
        
            comboCondominios.DataSource = condominioWeb.RetornaLista(Funcoes.Acesso);
            comboCondominios.DisplayMember = "nome";
            comboCondominios.ValueMember = "IdCondominios";

          
            condominioLista = new List<MoradoresWeb.condominio>();
            BindGrid();

        }

        public override void ClearFields()
        {          
            condominioLista.Clear();
            BindDetalhe();
        }

        public override void Populate()
        {
            MoradoresWeb.moradores morador = (MoradoresWeb.moradores)BDS.Current;                       

            condominioLista = moradoresWeb.Retornacondominios(morador.idmoradores,Funcoes.Acesso).ToList();

            BindDetalhe();
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
                BindDetalhe();
            }
        }

        private void comboCondominios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRmvCondominio_Click(object sender, EventArgs e)
        {
            if (FonteDeDados.Count > 0)
            {
                FonteDeDados.Remove(FonteDeDados.Current);
                condominioLista.RemoveAt(((MoradoresWeb.condominio)FonteDeDados.Current).idcondominios);
            }
        }

        public override void Atualizar(int id)
        {
            MoradoresWeb.moradores morador = (MoradoresWeb.moradores)BDS.Current;
     
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
            MoradoresWeb.moradores moradores = (MoradoresWeb.moradores)BDS.Current;
           
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
            id = (BDS.Current as MoradoresWeb.moradores).idmoradores;
            if (moradoresWeb.Apagar(id, Funcoes.Acesso))
            {
                MessageBox.Show("Excluido com sucesso!");
           
                base.Excluir(id);
            }
            else
            {
                MessageBox.Show("Falha ao excluir!");
            }
        }

        protected override void Paginas_SelectedIndexChanged(object sender, EventArgs e)
        {          
            base.Paginas_SelectedIndexChanged(sender, e);
        }

        public override void BindGrid()
        {
            BDS.Clear();
            foreach (MoradoresWeb.moradores morador in moradoresWeb.RetornaLista(Funcoes.Acesso))
                BDS.Add(morador);
            TabelaData.DataSource = BDS;
        }

        public void BindDetalhe()
        {
            FonteDeDados.Clear();
            foreach (MoradoresWeb.condominio condominio in condominioLista.ToArray())
                FonteDeDados.Add(condominio);
            gridControl1.DataSource = FonteDeDados;
        }

        private void isSindico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TabManutencao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(moradoresWeb.ResetarSenha((BDS.Current as MoradoresWeb.moradores).idmoradores, Funcoes.Acesso));
            MessageBox.Show("Senha redefinida com sucesso!");
        }
    }
}
