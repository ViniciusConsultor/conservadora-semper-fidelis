using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConservadoraSiteMVC2.WebServices;
namespace ConservadoraSiteMVC2.Models
{
    public class Moradores
    { 
        
        public List<moradores> RetornaLista()
        {
            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<moradores> query = from p in model.moradores select p;
            return query.ToList();
        }

       
        public moradores RetornaItem(int id)
        {            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<moradores> query = from p in model.moradores where p.idmoradores == id select p;
            return query.First();
        }

        public moradores RetornaItem(string id)
        {
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<moradores> query = from p in model.moradores where p.login == id select p;
            try
            {
                return query.First();
            }
            catch (Exception e)
            {
                var a = e.InnerException;
                return null;
            }
        }

       
        public List<condominio> Retornacondominios(int id)
        {           
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<condominio> query = from p in model.condominios_moradores where p.idmoradores == id select p.condominio;
            return query.ToList();
        }

       
        public condominio RetornaCondominio(int id)
        {        
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<condominio> query = from p in model.condominios where p.idcondominios == id select p;
            return query.First();
        }

      
        public bool SalvaMorador(moradores morador)
        {            
            try
            {             
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<moradores> query = from p in model.moradores where p.idmoradores == morador.idmoradores select p;
                moradores morador2 = query.First();
                morador2.nome = morador.nome;
                morador2.cpf = morador.cpf;
                morador2.login = morador.login;
                morador2.email = morador.email;
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

       
        public bool Salvacondominios(List<condominio> condominios, int moradorid)
        {
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

        
        public int AdicionaMorador(moradores morador)
        {           
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

                RegisterModel rm = new RegisterModel();
                rm.UserName = morador.login;
                rm.Password = morador.cpf;
                rm.Email = morador.email;
               
                AccountMembershipService ac = new AccountMembershipService();
                ac.CreateUser(rm.UserName, rm.Password, rm.Email);
               

                return morador.idmoradores;
            }
            catch (Exception e)
            {
                return -1;
            }

        }
   
        public bool Apagar(int id)
        {         
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<moradores> i = from p in model.moradores where p.idmoradores == id select p;
                moradores condo = i.First();
                model.DeleteObject(condo);
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool ClearPassword(moradores morador)
        {

            RegisterModel rm = new RegisterModel();
            rm.UserName = morador.login;
            rm.Password = morador.cpf;
            rm.Email = morador.email;
            AccountMembershipService ac = new AccountMembershipService();
            return ac.ResertarSenha(rm.UserName, rm.Password);                   
            
        }
    }
    }
