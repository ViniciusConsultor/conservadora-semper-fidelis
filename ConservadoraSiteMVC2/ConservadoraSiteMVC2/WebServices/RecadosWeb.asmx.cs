using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ConservadoraSiteMVC2.Models;

namespace ConservadoraSiteMVC2.WebServices
{
    /// <summary>
    /// Summary description for RecadosWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RecadosWeb : System.Web.Services.WebService
    {
        private static Recados controle = new Recados();

        [WebMethod]
        public List<recado> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaLista();
        }

        [WebMethod]
        public recado RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaItem(id);
        }

        [WebMethod]
        public bool SalvaRecado(recado recado, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.SalvaRecado(recado);
        }

        [WebMethod]
        public bool AdicionaRecado(recado recado, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.AdicionaRecado(recado);

        }

        [WebMethod]
        public bool Apagar(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.Apagar(id);
        }
    }
}
