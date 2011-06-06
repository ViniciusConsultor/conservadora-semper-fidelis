using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConservadoraSiteMVC2.WebServices;

namespace ConservadoraSiteMVC2.Models
{
    public class Condominios
    {
        
        public List<condominio> RetornaLista()
        {            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<condominio> query = from p in model.condominios select p;
            return query.ToList();
        }

        
        public condominio RetornaItem(int id)
        {           
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<condominio> query = from p in model.condominios where p.idcondominios == id select p;
            return query.First();
        }

       
        public bool SalvaCondominio(condominio condominio)
        {
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<condominio> query = from p in model.condominios where p.idcondominios == condominio.idcondominios select p;
                condominio condominio2 = query.First();
                condominio2.nome = condominio.nome;
                condominio2.endereco = condominio.endereco;
                condominio2.Sindico = condominio.Sindico;
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        
        public bool AdicionaCondominio(condominio condominio)
        {
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

      
        public bool Apagar(int id)
        {            
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