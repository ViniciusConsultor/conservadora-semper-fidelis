using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConservadoraSiteMVC2.Models
{
    public class FaleConoscoModel
    {
        [Required]
        [DisplayName("Assunto:")]
        public string Assunto { get; set; }

        [Required]
        [DisplayName("Mensagem:")]
        public string Texto { get; set; }
    }
}