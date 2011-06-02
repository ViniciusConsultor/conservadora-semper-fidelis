using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConservadoraSiteMVC2.WebServices
{
    public class Conexao
    {
        public static string SenhaAcesso = "123abc789123";
        
        private Conexao()
        { 
        
        }

        private static Models.conservadoraEntities modelo = null;
       
        public static Models.conservadoraEntities getInstance()
        {
            if (modelo == null)
            {
                modelo = new Models.conservadoraEntities();     
            }
            return modelo;
        }
    }
}