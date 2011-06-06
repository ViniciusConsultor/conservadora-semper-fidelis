using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using ConservadoraSiteMVC2.WebServices;

namespace ConservadoraSiteMVC2.Models
{
    public class Boletos
    {

        
        public string SalvaArquivo(byte[] dadosDoArquivo, string nomeArquivo)
        {            
            try
            {
                FileStream arquivo = File.Create("C:\\inetpub\\vhosts\\conservadorasemperfidelis.com.br\\httpdocs\\sys\\Boletos\\" + nomeArquivo);
                arquivo.Write(dadosDoArquivo, 0, dadosDoArquivo.Length);
                arquivo.Flush();
                arquivo.Close();
            }
            catch (Exception e)
            {
                nomeArquivo = e.Message;
            }
            return "C:\\inetpub\\vhosts\\conservadorasemperfidelis.com.br\\httpdocs\\sys\\Boletos\\" + nomeArquivo;
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
                
        public List<boleto> RetornaLista()
        {            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<boleto> query = from p in model.boletos select p;
            return query.ToList();
        }

        
        public boleto RetornaItem(int id)
        {            
            conservadoraEntities model = Conexao.getInstance();
            IQueryable<boleto> query = from p in model.boletos where p.idboletos == id select p;
            return query.First();
        }

        
        public bool SalvaBoleto(boleto boletop)
        {            
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

        
        public bool AdicionaBoleto(boleto boletop)
        {            
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

        
        public bool Apagar(int id)
        {            
            try
            {
                conservadoraEntities model = Conexao.getInstance();
                IQueryable<boleto> i = from p in model.boletos where p.idboletos == id select p;
                boleto boletop = i.First();

                if ((File.Exists(boletop.caminhoArquivo)))
                    File.Delete(boletop.caminhoArquivo);

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