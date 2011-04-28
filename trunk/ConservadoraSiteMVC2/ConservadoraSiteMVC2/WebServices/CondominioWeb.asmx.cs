using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ConservadoraSiteMVC2.Models;

namespace ConservadoraSiteMVC2.WebServices
{
    /// <summary>
    /// Summary description for CondominioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CondominioWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public List<condominio> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<condominio> query = from p in model.condominios select p;
            return query.ToList(); 
        }

        [WebMethod]
        public condominio RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<condominio> query = from p in model.condominios where p.idcondominios == id select p;
            return query.First();
        }

        [WebMethod]
        public bool SalvaCondominio(condominio condominio, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<condominio> query = from p in model.condominios where p.idcondominios == condominio.idcondominios select p;
                condominio condominio2 = query.First();
                condominio2.nome = condominio.nome;
                condominio2.endereco = condominio.endereco;
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
          
        }

        [WebMethod]
        public bool AdicionaCondominio(condominio condominio, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {

                conservadoraEntities model = Conexao.getInstance();
                IQueryable<condominio> i = from p in model.condominios select p;
                IEnumerable<condominio> max = i.OrderBy(p => p.idcondominios);

                if (max.Count() > 0)
                    condominio.idcondominios = max.Last().idcondominios == null ? 1 : max.Last().idcondominios + 1;
                else
                    condominio.idcondominios = 1;

                model.AddTocondominios(condominio);
                
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        [WebMethod]
        public bool Apagar(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<condominio> i = from p in model.condominios where p.idcondominios == id select p;
                condominio condo = i.First();
                model.DeleteObject(condo);
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
