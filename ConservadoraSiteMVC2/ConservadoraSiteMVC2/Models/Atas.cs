using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConservadoraSiteMVC2.WebServices;
using System.IO;

namespace ConservadoraSiteMVC2.Models
{
    public class Atas
    {

      
        public string SalvaArquivo(byte[] dadosDoArquivo, string nomeArquivo)
        {
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

    
        public List<ata> RetornaLista()
        {           
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<ata> query = from p in model.atas select p;
            return query.ToList();
        }

     
        public ata RetornaItem(int id)
        {
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<ata> query = from p in model.atas where p.idata == id select p;
            return query.First();
        }

  
        public bool SalvaAta(ata atap)
        {
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

      
        public bool AdicionaAta(ata atap)
        {
          
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

     
        public bool Apagar(int id)
        {
          
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