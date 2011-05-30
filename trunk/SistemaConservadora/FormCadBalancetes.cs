using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SistemaConservadora
{
    public partial class FormCadBalancetes : SistemaConservadora.FormCadastro
    {
         private static BalancetesWeb.BalancetesWebSoapClient balancetesWeb = new BalancetesWeb.BalancetesWebSoapClient("BalancetesWebSoap", Funcoes.Servidor + "BalancetesWeb.asmx");
         private static CondominioWeb.CondominioWebSoapClient condominiosWeb = new CondominioWeb.CondominioWebSoapClient("CondominioWebSoap", Funcoes.Servidor + "CondominioWeb.asmx");
         private string nomeArquivo;
         public FormCadBalancetes()
            : base()
        {
            InitializeComponent();
      
            cmbCondominios.DataSource = condominiosWeb.RetornaLista(Funcoes.Acesso);
            cmbCondominios.DisplayMember = "nome";
            cmbCondominios.ValueMember = "idcondominios";
            BindGrid();
        }

        public override void ClearFields()
        {
            (BDS.Current as BalancetesWeb.balancete).data = dtReferenteA.Value;
        }
       
        public override void Populate()
        {
          
        }
        
        public override void Atualizar(int id)
        {
            BalancetesWeb.balancete balancete = (BalancetesWeb.balancete)BDS.Current;


            if (balancetesWeb.SalvaBalancete(balancete, Funcoes.Acesso))
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
            BalancetesWeb.balancete balancete = (BalancetesWeb.balancete)BDS.Current;

            if (balancetesWeb.AdicionaBalancete(balancete, Funcoes.Acesso))
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
            id = (BDS.Current as BalancetesWeb.balancete).idbalancete;

            if (balancetesWeb.Apagar(id,Funcoes.Acesso))
            {
                MessageBox.Show("Excluido com sucesso!");
         
                base.Excluir(id);
            }
            else
            {
                MessageBox.Show("Falha ao excluir!");
            }
        }
        
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            dlgArquivo.ShowDialog();
            txtArquivo.Text = dlgArquivo.FileName;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {           
            FileStream arquivo = File.OpenRead(txtArquivo.Text);
            byte[] dados = new byte[arquivo.Length];
            arquivo.Read(dados, 0, dados.Length);
           
            this.nomeArquivo = balancetesWeb.SalvaArquivo(dados, 
                               "boletos" + cmbCondominios.SelectedValue + dtReferenteA.Text.Replace('/','_') + ".pdf"
                              , Funcoes.Acesso);

            arquivo.Close();
            txtArquivo.Text = "";
            (BDS.Current as BalancetesWeb.balancete).caminhoArquivo = this.nomeArquivo;
            lblDownload.Enabled = true;           
        }

        private void lblDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            byte[] dadosArquivo = balancetesWeb.DownloadBytes((BDS.Current as BalancetesWeb.balancete).caminhoArquivo, Funcoes.Acesso);
            SalvarArquivo.ShowDialog();
            if (SalvarArquivo.FileName != "")
            {
                FileStream stream = File.Create(SalvarArquivo.FileName);
                stream.Write(dadosArquivo, 0, dadosArquivo.Length);
                stream.Flush();
                stream.Close();
            }
        }

        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public override void BindGrid()
        {
            BDS.Clear();
            foreach (BalancetesWeb.balancete ata in balancetesWeb.RetornaLista(Funcoes.Acesso))
                BDS.Add(ata);
            TabelaData.DataSource = BDS;
        }
    }
}
