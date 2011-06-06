using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using ConservadoraSiteMVC2.WebServices;

namespace ConservadoraSiteMVC2.Models
{
    public class Balancetes
    {
        
        public string SalvaArquivo(byte[] dadosDoArquivo, string nomeArquivo)
        {            
            try
            {
                FileStream arquivo = File.Create("C:\\inetpub\\vhosts\\conservadorasemperfidelis.com.br\\httpdocs\\sys\\Balancetes\\" + nomeArquivo);
                arquivo.Write(dadosDoArquivo, 0, dadosDoArquivo.Length);
                arquivo.Flush();
                arquivo.Close();
            }
            catch (Exception e)
            {
                nomeArquivo = e.Message;
            }
            return "C:\\inetpub\\vhosts\\conservadorasemperfidelis.com.br\\httpdocs\\sys\\Balancetes\\" + nomeArquivo;

        }

        
        public moradores teste()
        {
            return null;
        }

        
        public byte[] DownloadBytes(string nomeArquivo)
        {
            
            byte[] resultado;
            try
            {
                FileStream arquivo = File.OpenRead(nomeArquivo);
                resultado = new byte[arquivo.Length];
                arquivo.Read(resultado, 0, resultado.Length);
                arquivo.Close();
            }
            catch
            {
                return null;
            }
            return resultado;
        }

        
        public bool existeArquivo(string nomeArquivo)
        {
            
            return File.Exists(nomeArquivo);
        }


        
        public List<balancete> RetornaLista()
        {
            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<balancete> query = from p in model.balancetes select p;
            return query.ToList();
        }

        
        public balancete RetornaItem(int id)
        {
            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<balancete> query = from p in model.balancetes where p.idbalancete == id select p;
            return query.First();
        }

        
        public bool SalvaBalancete(balancete balancetesp)
        {
            
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<balancete> query = from p in model.balancetes where p.idbalancete == balancetesp.idbalancete select p;
                balancete balancetes2 = query.First();
                balancetes2.idbalancete = balancetesp.idbalancete;

                balancetes2.data = balancetesp.data;
                balancetes2.caminhoArquivo = balancetesp.caminhoArquivo;
                balancetes2.idcondominios = balancetesp.idcondominios;
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        
        public bool AdicionaBalancete(balancete balancetesp)
        {
            
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<balancete> i = from p in model.balancetes select p;
                IEnumerable<balancete> max = i.OrderBy(p => p.idbalancete);

                if (max.Count() > 0)
                    balancetesp.idbalancete = max.Last().idbalancete == null ? 1 : max.Last().idbalancete + 1;
                else
                    balancetesp.idbalancete = 1;

                model.AddTobalancetes(balancetesp);

                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var x = e.InnerException;
                return false;
            }

        }

        
        public bool Apagar(int id)
        {
            
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<balancete> i = from p in model.balancetes where p.idbalancete == id select p;
                balancete balancetesp = i.First();

                if ((File.Exists(balancetesp.caminhoArquivo)))
                    File.Delete(balancetesp.caminhoArquivo);

                model.DeleteObject(balancetesp);
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public List<balancete> RetornaBAlancetesPorMorador(moradores mor)
        {
            conservadoraEntities model = Conexao.getInstance();
            var q = from p in model.balancetes
                    join c in model.condominios_moradores on p.idcondominios equals c.idcondominios
                    join d in model.moradores on c.idmoradores equals d.idmoradores
                    where d.idmoradores == mor.idmoradores
                    || p.idcondominios == (from x in model.condominios where x.Sindico == mor.idmoradores select x.idcondominios).FirstOrDefault()
                    select p;
            return q.ToList();
        }
    }
}