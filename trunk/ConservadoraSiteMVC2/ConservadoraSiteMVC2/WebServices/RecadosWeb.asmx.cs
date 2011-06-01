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

        [WebMethod]
        public List<recado> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<recado> query = from p in model.recados select p;
            return query.ToList();
        }

        [WebMethod]
        public List<RecadosCompleto> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<RecadosCompleto> query = from p in model.recados select new RecadosCompleto 
            { 
              NomeCondominio = p.condominio.nome  
            };
            return query.ToList();
        }

        [WebMethod]
        public recado RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<recado> query = from p in model.recados where p.idrecados == id select p;
            return query.First();
        }

        [WebMethod]
        public bool SalvaRecado(recado recado, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<recado> query = from p in model.recados where p.idrecados == recado.idrecados select p;
                recado recado2 = query.First();
                recado2.idcondominios = recado.idcondominios;
                recado2.Título = recado.Título;
                recado2.Texto = recado.Texto;    
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        [WebMethod]
        public bool AdicionaRecado(recado recado, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<recado> i = from p in model.recados select p;
                IEnumerable<recado> max = i.OrderBy(p => p.idrecados);

                if (max.Count() > 0)
                    recado.idrecados = max.Last().idrecados == null ? 1 : max.Last().idrecados + 1;
                else
                    recado.idrecados = 1;

                model.AddTorecados(recado);

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
                IQueryable<recado> i = from p in model.recados where p.idrecados == id select p;
                recado recado = i.First();
                model.DeleteObject(recado);
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
