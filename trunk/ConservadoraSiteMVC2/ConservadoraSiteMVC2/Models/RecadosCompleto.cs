using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConservadoraSiteMVC2.Models
{
    public class RecadosCompleto : recado
    {
        [NonSerialized]
        string nomeCondominio;

        public string NomeCondominio
        {
            get { return nomeCondominio; }
            set { nomeCondominio = condominio.nome; }
        }
        

        public RecadosCompleto() : base()
        {
             
        }
    }
}