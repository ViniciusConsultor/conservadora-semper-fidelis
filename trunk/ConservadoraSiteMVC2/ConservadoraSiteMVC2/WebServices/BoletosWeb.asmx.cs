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
    /// Summary description for BoletosWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BoletosWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string SalvaArquivo(byte[] dadosDoArquivo, string nomeArquivo,string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                FileStream arquivo = File.Create(Directory.GetCurrentDirectory() + "\\Boletos\\" + nomeArquivo);
                arquivo.Write(dadosDoArquivo, 0, dadosDoArquivo.Length);
                arquivo.Flush();
                arquivo.Close();
            }
            catch (Exception e)
            {
                nomeArquivo = e.Message;
            }
                return Directory.GetCurrentDirectory() + "\\Boletos\\" + nomeArquivo;


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
        public List<boleto> RetornaLista(string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<boleto> query = from p in model.boletos select p;
            return query.ToList();
        }

        [WebMethod]
        public boleto RetornaItem(int id, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<boleto> query = from p in model.boletos where p.idboletos == id select p;
            return query.First();
        }

        [WebMethod]
        public bool SalvaBoleto(boleto boletop, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<boleto> query = from p in model.boletos where p.idboletos == boletop.idboletos select p;
                boleto boleto2 = query.First();
                boleto2.idboletos = boletop.idboletos;
                boleto2.sitiuacao = boletop.sitiuacao;
                boleto2.data = boletop.data;
                boleto2.caminhoArquivo = boletop.caminhoArquivo;
                boleto2.idmoradores = boletop.idmoradores;
                model.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        [WebMethod]
        public bool AdicionaBoleto(boleto boletop, string acesso)
        {
            if (acesso != Conexao.SenhaAcesso) throw new Exception();
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<boleto> i = from p in model.boletos select p;
                IEnumerable<boleto> max = i.OrderBy(p => p.idboletos);

                if (max.Count() > 0)
                    boletop.idboletos = max.Last().idboletos == null ? 1 : max.Last().idboletos + 1;
                else
                    boletop.idboletos = 1;

                model.AddToboletos(boletop);

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
                IQueryable<boleto> i = from p in model.boletos where p.idboletos == id select p;
                boleto boletop = i.First();
                model.DeleteObject(boletop);
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
