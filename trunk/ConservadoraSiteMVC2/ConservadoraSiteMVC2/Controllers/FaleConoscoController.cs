using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConservadoraSiteMVC2.Models;
using System.Net.Mail;
using System.Net.Security;
using System.Net;

namespace ConservadoraSiteMVC2.Controllers
{
    public class FaleConoscoController : Controller
    {
        //
        // GET: /FaleConosco/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Index(FaleConoscoModel modelo)
        {
            try
            {
                Moradores contole = new Moradores();
                moradores mor = contole.RetornaItem(User.Identity.Name);

                MailMessage mail = new MailMessage();
                mail.Subject = modelo.Assunto;
                mail.Body = modelo.Texto;
                mail.From = new MailAddress(mor.email, mor.nome);
                mail.To.Add("atendimento@conservadorasemperfidelis.com.br");
                SmtpClient cliente = new SmtpClient("mail.conservadorasemperfidelis.com.br");
                cliente.Credentials = new NetworkCredential("atendimento", "cons123");
                cliente.Send(mail);
            }
            catch (Exception e)
            {
                ViewData["Mensagem"] = "Ocorreu um erro no envio de email, motivo :" + e.Message;
                return View();
            }
          
           return RedirectToAction("EmailSucesso");
        }

        [Authorize]
        public ActionResult EmailSucesso()
        {
            return View();
        }

    }
}
