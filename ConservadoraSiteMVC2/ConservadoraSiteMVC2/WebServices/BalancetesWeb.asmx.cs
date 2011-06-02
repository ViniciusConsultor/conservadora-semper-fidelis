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
    /// Summary description for BalancetesWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BalancetesWeb : System.Web.Services.WebService
    {
        private static Balancetes controle = new Balancetes();
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
        public List<balancete> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaLista();
        }

        [WebMethod]
        public balancete RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaItem(id);
        }

        [WebMethod]
        public bool SalvaBalancete(balancete balancetesp, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.SalvaBalancete(balancetesp);

        }

        [WebMethod]
        public bool AdicionaBalancete(balancete balancetesp, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.AdicionaBalancete(balancetesp);
        }

        [WebMethod]
        public bool Apagar(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.Apagar(id);

        }
    }
}
