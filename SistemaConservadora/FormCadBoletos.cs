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
    public partial class FormCadBoletos : SistemaConservadora.FormCadastro
    {
         private static BoletosWeb.BoletosWebSoapClient boletosWeb = new BoletosWeb.BoletosWebSoapClient("BoletosWebSoap", "http://localhost:1186/WebServices/BoletosWeb.asmx");
         private static MoradoresWeb.MoradoresWebSoapClient moradoresWeb = new MoradoresWeb.MoradoresWebSoapClient("MoradoresWebSoap", "http://localhost:1186/WebServices/MoradoresWeb.asmx");
         private string nomeArquivo;
        public FormCadBoletos()
            : base()
        {
            InitializeComponent();
            TabelaData.DataSource = boletosWeb.RetornaLista(Funcoes.Acesso);
            TabelaData.Columns[TabelaData.Columns.Count - 1].Visible = false;
            cmbMorador.DataSource = moradoresWeb.RetornaLista(Funcoes.Acesso);
            cmbMorador.DisplayMember = "nome";
            cmbMorador.ValueMember = "idmoradores";
        }

        public override void ClearFields()
        {
            lblIdentificacao.Text = "";
            cmbMorador.Text = "";
            txtArquivo.Text = "";
            dtReferenteA.Value = DateTime.Now;
            lblDownload.Enabled = false;
        }
       
        public override void Populate()
        {
            BoletosWeb.boleto boletos = boletosWeb.RetornaItem(Convert.ToInt32(TabelaData.SelectedRows[0].Cells[0].Value),Funcoes.Acesso);
            lblIdentificacao.Text = boletos.idboletos.ToString();
            lblCaminhoArquivo.Text = boletos.caminhoArquivo;
            lblDownload.Enabled = true;
            cmbMorador.SelectedValue = boletos.idmoradores;
            dtReferenteA.Value = Convert.ToDateTime(boletos.data);
            cmbSituacao.Text = boletos.sitiuacao;
        }
        
        public override void Atualizar(int id)
        {
            BoletosWeb.boleto boletos = new BoletosWeb.boleto();
          
            boletos.idboletos = Convert.ToInt32(lblIdentificacao.Text);
            boletos.caminhoArquivo = txtArquivo.Text == null ? lblCaminhoArquivo.Text : txtArquivo.Text;
            boletos.idmoradores = Convert.ToInt32(cmbMorador.SelectedValue);
            boletos.data = dtReferenteA.Value;
            boletos.sitiuacao = cmbSituacao.Text;

            if(boletosWeb.SalvaBoleto(boletos,Funcoes.Acesso))
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
            TabelaData.DataSource = boletosWeb.RetornaLista(Funcoes.Acesso);
            base.Paginas_SelectedIndexChanged(sender, e);
        }

        public override void Adicionar()
        {
            BoletosWeb.boleto boletos = new BoletosWeb.boleto();
                 
            boletos.caminhoArquivo = this.nomeArquivo;
            boletos.idmoradores = Convert.ToInt32(cmbMorador.SelectedValue);
            boletos.data = dtReferenteA.Value;
            boletos.sitiuacao = cmbSituacao.Text;

            if (boletosWeb.AdicionaBoleto(boletos,Funcoes.Acesso))
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
            if (boletosWeb.Apagar(id,Funcoes.Acesso))
            {
                MessageBox.Show("Excluido com sucesso!");
                TabelaData.DataSource = boletosWeb.RetornaLista(Funcoes.Acesso);
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
           
            this.nomeArquivo = boletosWeb.SalvaArquivo(dados, 
                               "boletos" + cmbMorador.SelectedValue + dtReferenteA.Text.Replace('/','_') + ".pdf"
                              , Funcoes.Acesso);

            arquivo.Close();
            txtArquivo.Text = "";
            lblCaminhoArquivo.Text = this.nomeArquivo;
            lblDownload.Enabled = true;           
        }

        private void lblDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            byte[] dadosArquivo = boletosWeb.DownloadBytes(this.nomeArquivo, Funcoes.Acesso);
            SalvarArquivo.ShowDialog();
            if (SalvarArquivo.FileName != "")
            {
                FileStream stream = File.Create(SalvarArquivo.FileName);
                stream.Write(dadosArquivo, 0, dadosArquivo.Length);
                stream.Flush();
                stream.Close();
            }
        }
    }
}
