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
    /// Summary description for AtasWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AtasWeb : System.Web.Services.WebService 
    {
        private static Atas controle = new Atas();

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
        public List<ata> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaLista();
        }

        [WebMethod]
        public ata RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaItem(id);
        }

        [WebMethod]
        public bool SalvaAta(ata atap, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.SalvaAta(atap);
        }

        [WebMethod]
        public bool AdicionaAta(ata atap, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.AdicionaAta(atap);
        }

        [WebMethod]
        public bool Apagar(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.Apagar(id);

        }
    }
}
