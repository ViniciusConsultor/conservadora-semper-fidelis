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
    /// Summary description for AtasWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AtasWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string SalvaArquivo(byte[] dadosDoArquivo, string nomeArquivo,string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                FileStream arquivo = File.Create(Directory.GetCurrentDirectory() + "\\Atas\\" + nomeArquivo);
                arquivo.Write(dadosDoArquivo, 0, dadosDoArquivo.Length);
                arquivo.Flush();
                arquivo.Close();
            }
            catch (Exception e)
            {
                nomeArquivo = e.Message;
            }
                return Directory.GetCurrentDirectory() + "\\Atas\\" + nomeArquivo;


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
        public List<ata> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<ata> query = from p in model.atas select p;
            return query.ToList();
        }

        [WebMethod]
        public ata RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<ata> query = from p in model.atas where p.idata == id select p;
            return query.First();
        }

        [WebMethod]
        public bool SalvaAta(ata atap, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<ata> query = from p in model.atas where p.idata == atap.idata select p;
                ata ata2 = query.First();
                ata2.idata = atap.idata;
               
                ata2.data = atap.data;
                ata2.caminhoArquivo = atap.caminhoArquivo;
                ata2.idcondominios = atap.idcondominios;
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
        public bool AdicionaAta(ata atap, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<ata> i = from p in model.atas select p;
                IEnumerable<ata> max = i.OrderBy(p => p.idata);

                if (max.Count() > 0)
                    atap.idata = max.Last().idata == null ? 1 : max.Last().idata + 1;
                else
                    atap.idata = 1;

                atap.condominio = (from p in model.condominios where p.idcondominios == atap.idcondominios select p).FirstOrDefault();

                model.AddToatas(atap);

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
                IQueryable<ata> i = from p in model.atas where p.idata == id select p;
                ata atap = i.First();

                if ((File.Exists(atap.caminhoArquivo)))
                    File.Delete(atap.caminhoArquivo);

                model.DeleteObject(atap);
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
