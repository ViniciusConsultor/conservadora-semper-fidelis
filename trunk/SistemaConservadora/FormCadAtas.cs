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
    public partial class FormCadAtas : SistemaConservadora.FormCadastro
    {
         private static AtasWeb.AtasWebSoapClient atasWeb = new AtasWeb.AtasWebSoapClient("AtasWebSoap", Funcoes.Servidor + "AtasWeb.asmx");
         private static CondominioWeb.CondominioWebSoapClient condominiosWeb = new CondominioWeb.CondominioWebSoapClient("CondominioWebSoap", Funcoes.Servidor + "CondominioWeb.asmx");
         private string nomeArquivo;
        public FormCadAtas()
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
            (BDS.Current as AtasWeb.ata).data = dtReferenteA.Value;
        }
       
        public override void Populate()
        {
          
        }
        
        public override void Atualizar(int id)
        {
            AtasWeb.ata atas = (AtasWeb.ata)BDS.Current;          
          

            if(atasWeb.AdicionaAta(atas,Funcoes.Acesso))
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
            AtasWeb.ata atas = (AtasWeb.ata)BDS.Current;   
       
            if (atasWeb.AdicionaAta(atas,Funcoes.Acesso))
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
            id = (BDS.Current as AtasWeb.ata).idata;

            if (atasWeb.Apagar(id,Funcoes.Acesso))
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
           
            this.nomeArquivo = atasWeb.SalvaArquivo(dados, 
                               "boletos" + cmbCondominios.SelectedValue + dtReferenteA.Text.Replace('/','_') + ".pdf"
                              , Funcoes.Acesso);

            arquivo.Close();
            txtArquivo.Text = "";
            (BDS.Current as AtasWeb.ata).caminhoArquivo = this.nomeArquivo;
            lblDownload.Enabled = true;           
        }

        private void lblDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            byte[] dadosArquivo = atasWeb.DownloadBytes((BDS.Current as AtasWeb.ata).caminhoArquivo, Funcoes.Acesso);
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
            foreach (AtasWeb.ata ata in atasWeb.RetornaLista(Funcoes.Acesso))
                BDS.Add(ata);
            TabelaData.DataSource = BDS;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
