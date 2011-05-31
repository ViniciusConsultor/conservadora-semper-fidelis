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
    /// Summary description for BalancetesWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BalancetesWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string SalvaArquivo(byte[] dadosDoArquivo, string nomeArquivo,string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                FileStream arquivo = File.Create(Directory.GetCurrentDirectory() + "\\Balancetes\\" + nomeArquivo);
                arquivo.Write(dadosDoArquivo, 0, dadosDoArquivo.Length);
                arquivo.Flush();
                arquivo.Close();
            }
            catch (Exception e)
            {
                nomeArquivo = e.Message;
            }
                return Directory.GetCurrentDirectory() + "\\Balancetes\\" + nomeArquivo;


        }

        [WebMethod]
        public moradores teste()
        {
            return null;
        }

        [WebMethod]
        public byte[] DownloadBytes(string nomeArquivo, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
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

        [WebMethod]
        public bool existeArquivo(string nomeArquivo, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            return File.Exists(nomeArquivo);        
        }


        [WebMethod]
        public List<balancete> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<balancete> query = from p in model.balancetes select p;
            return query.ToList();
        }

        [WebMethod]
        public balancete RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<balancete> query = from p in model.balancetes where p.idbalancete == id select p;
            return query.First();
        }

        [WebMethod]
        public bool SalvaBalancete(balancete balancetesp, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
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

        [WebMethod]
        public bool AdicionaBalancete(balancete balancetesp, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
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

        [WebMethod]
        public bool Apagar(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
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
    }
}
