using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConservadoraSiteMVC2.WebServices;

namespace ConservadoraSiteMVC2.Models
{
    public class Recados
    {

        
        public List<recado> RetornaLista()
        {            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<recado> query = from p in model.recados select p;
            return query.ToList();
        }

           
        public recado RetornaItem(int id)
        {
            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<recado> query = from p in model.recados where p.idrecados == id select p;
            return query.First();
        }

        
        public bool SalvaRecado(recado recado)
        {
            
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

        
        public bool AdicionaRecado(recado recado)
        {
            
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

        
        public bool Apagar(int id)
        {
            
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