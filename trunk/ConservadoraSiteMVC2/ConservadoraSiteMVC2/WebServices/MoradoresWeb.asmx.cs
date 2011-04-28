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
        [WebMethod]
        public List<moradores> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<moradores> query = from p in model.moradores select p;
            return query.ToList();
        }

        [WebMethod]
        public moradores RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<moradores> query = from p in model.moradores where p.idmoradores == id select p;
            return query.First();
        }

        [WebMethod]
        public List<condominio> Retornacondominios(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<condominio> query = from p in model.condominios_moradores where p.idmoradores == id select p.condominio;
            return query.ToList();
        }

        [WebMethod]
        public condominio RetornaCondominio(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<condominio> query = from p in model.condominios where p.idcondominios == id select p;
            return query.First();
        }

        [WebMethod]
        public bool SalvaMorador(moradores morador, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {             
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<moradores> query = from p in model.moradores where p.idmoradores == morador.idmoradores select p;
                moradores morador2 = query.First();
                morador2.nome = morador.nome;
                morador2.cpf = morador.cpf;
                morador2.login = morador.login;
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        [WebMethod]
        public bool Salvacondominios(List<condominio> condominios, int moradorid, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
               
                IQueryable<condominios_moradores> query = from p 
                                                      in model.condominios_moradores 
                                                      where p.moradore.idmoradores == moradorid 
                                                      select p;
                foreach (condominios_moradores c in query.ToArray())
                          model.DeleteObject(c);    
                model.SaveChanges();

                foreach (condominio c in condominios.ToArray())
                {
                    condominios_moradores condo = new condominios_moradores();
                    condo.idcondominios = c.idcondominios;
                    condo.idmoradores = moradorid;
                    model.AddTocondominios_moradores(condo);
                    model.SaveChanges();
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        [WebMethod]
        public int AdicionaMorador(moradores morador, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {

                conservadoraEntities model = Conexao.getInstance();
                IQueryable<moradores> i = from p in model.moradores select p;
                IEnumerable<moradores> max = i.OrderBy(p => p.idmoradores);
              
                if (max.Count() > 0)
                    morador.idmoradores = max.Last().idmoradores == null ? 1 : max.Last().idmoradores + 1;
                else
                    morador.idmoradores = 1;

                model.AddTomoradores(morador);
               
                model.SaveChanges();
                return morador.idmoradores;
            }
            catch (Exception e)
            {
                return -1;
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
