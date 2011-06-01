using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ConservadoraSiteMVC2.Models;
namespace ConservadoraSiteMVC2.WebServices
{
    /// <summary>
    /// Summary description for moradoresWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MoradoresWeb : System.Web.Services.WebService
    {
        private static Moradores controle = new Moradores();
        [WebMethod]
        public List<moradores> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaLista();
        }

        [WebMethod]
        public moradores RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaItem(id);
        }

        [WebMethod]
        public List<condominio> Retornacondominios(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.Retornacondominios(id);
        }

        [WebMethod]
        public condominio RetornaCondominio(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.RetornaCondominio(id);
        }

        [WebMethod]
        public bool SalvaMorador(moradores morador, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.SalvaMorador(morador);

        }

        [WebMethod]
        public bool Salvacondominios(List<condominio> condominios, int moradorid, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.Salvacondominios(condominios,moradorid);

        }

        [WebMethod]
        public int AdicionaMorador(moradores morador, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return controle.AdicionaMorador(morador);

        }

        [WebMethod]
        public bool Apagar(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
           return controle.Apagar(id);
        }
    }
}
