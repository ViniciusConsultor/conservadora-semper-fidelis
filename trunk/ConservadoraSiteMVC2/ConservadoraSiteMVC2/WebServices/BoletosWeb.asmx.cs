using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using ConservadoraSiteMVC2.Models;

namespace ConservadoraSiteMVC2.WebServices
{
    /// <summary>
    /// Summary description for BoletosWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BoletosWeb : System.Web.Services.WebService
    {
        private static Boletos controle = new Boletos();
        [WebMethod]
        public string SalvaArquivo(byte[] dadosDoArquivo, string nomeArquivo,string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.SalvaArquivo(dadosDoArquivo, nomeArquivo);
        }

      
        [WebMethod]
        public byte[] DownloadBytes(string nomeArquivo, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.DownloadBytes(nomeArquivo);
        }

        [WebMethod]
        public bool existeArquivo(string nomeArquivo, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.existeArquivo(nomeArquivo);
        }


        [WebMethod]
        public List<boleto> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaLista();
        }

        [WebMethod]
        public boleto RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaItem(id);
        }

        [WebMethod]
        public bool SalvaBoleto(boleto boletop, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.SalvaBoleto(boletop);
        }

        [WebMethod]
        public bool AdicionaBoleto(boleto boletop, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.AdicionaBoleto(boletop);
        }

        [WebMethod]
        public bool Apagar(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.Apagar(id);
        }
    }
}
