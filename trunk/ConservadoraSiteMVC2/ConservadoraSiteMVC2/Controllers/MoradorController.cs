using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConservadoraSiteMVC2.Models;

namespace ConservadoraSiteMVC2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MoradorController : Controller
    {
        //
        // GET: /Moradores/
        private static Moradores controle = new Moradores();
        public ActionResult Index()
        {
            return View(controle.RetornaLista());
        }

        //
        // GET: /Moradores/Details/5

        public ActionResult Details(int id)
        {
            return View(controle.RetornaItem(id));
        }

        //
        // GET: /Moradores/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Moradores/Create

        [HttpPost]
        public ActionResult Create(moradores collection)
        {
            try
            {
                Condominios controleCondominio = new Condominios();
                // TODO: Add insert logic here
                string[] s = Request.Params.GetValues("condominios");
                List<condominio> lista = new List<condominio>();
                
                foreach (string str in s)
                    lista.Add(controleCondominio.RetornaItem(Convert.ToInt32(str)));
                
                int id = controle.AdicionaMorador(collection);
                controle.Salvacondominios(lista, id);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Moradores/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(controle.RetornaItem(id));
        }

        //
        // POST: /Moradores/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, moradores collection)
        {
            try
            {
                // TODO: Add update logic here
                controle.SalvaMorador(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Moradores/Delete/5
 
        public ActionResult Delete(int id)
        {
         
            return View(controle.RetornaItem(id));
        }

        //
        // POST: /Moradores/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, moradores collection)
        {
            try
            {
                // TODO: Add delete logic here
                controle.Apagar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ResetarSenha(int id)
        {
            controle.ClearPassword(controle.RetornaItem(id));
            ViewData["Mensagem"] = "Senha redefinida com sucesso!";
            return RedirectToAction("Index");
        }
    }
}
