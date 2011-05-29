﻿using System;
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
         private static BoletosWeb.BoletosWebSoapClient boletosWeb = new BoletosWeb.BoletosWebSoapClient("BoletosWebSoap", Funcoes.Servidor + "BoletosWeb.asmx");
         private static MoradoresWeb.MoradoresWebSoapClient moradoresWeb = new MoradoresWeb.MoradoresWebSoapClient("MoradoresWebSoap", Funcoes.Servidor + "MoradoresWeb.asmx");
         private string nomeArquivo;
        public FormCadBoletos()
            : base()
        {
            InitializeComponent();
      
            cmbMorador.DataSource = moradoresWeb.RetornaLista(Funcoes.Acesso);
            cmbMorador.DisplayMember = "nome";
            cmbMorador.ValueMember = "idmoradores";
            BindGrid();
        }

        public override void ClearFields()
        {
            (BDS.Current as BoletosWeb.boleto).data = dtReferenteA.Value;
        }
       
        public override void Populate()
        {
          
        }
        
        public override void Atualizar(int id)
        {
            BoletosWeb.boleto boletos = (BoletosWeb.boleto)BDS.Current;          
           

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
         
            base.Paginas_SelectedIndexChanged(sender, e);
        }

        public override void Adicionar()
        {
            BoletosWeb.boleto boletos = (BoletosWeb.boleto)BDS.Current;
       
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
            id = (BDS.Current as BoletosWeb.boleto).idboletos;

            if (boletosWeb.Apagar(id,Funcoes.Acesso))
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
           
            this.nomeArquivo = boletosWeb.SalvaArquivo(dados, 
                               "boletos" + cmbMorador.SelectedValue + dtReferenteA.Text.Replace('/','_') + ".pdf"
                              , Funcoes.Acesso);

            arquivo.Close();
            txtArquivo.Text = "";
            (BDS.Current as BoletosWeb.boleto).caminhoArquivo = this.nomeArquivo;
            lblDownload.Enabled = true;           
        }

        private void lblDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            byte[] dadosArquivo = boletosWeb.DownloadBytes((BDS.Current as BoletosWeb.boleto).caminhoArquivo, Funcoes.Acesso);
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
            foreach (BoletosWeb.boleto boleto in boletosWeb.RetornaLista(Funcoes.Acesso))
                BDS.Add(boleto);
            TabelaData.DataSource = BDS;
        }
    }
}
