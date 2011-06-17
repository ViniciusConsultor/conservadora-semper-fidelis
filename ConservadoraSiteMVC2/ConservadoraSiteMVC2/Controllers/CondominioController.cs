using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConservadoraSiteMVC2.Models;

namespace ConservadoraSiteMVC2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CondominioController : Controller
    {
        //
        // GET: /Condominio/
        private static Condominios controle = new Condominios();
        
        public ActionResult Index()
        {

            return View(controle.RetornaLista());
        }

        //
        // GET: /Condominio/Details/5

        public ActionResult Details(int id)
        {
            return View(controle.RetornaItem(id));
        }

        //
        // GET: /Condominio/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Condominio/Create

        [HttpPost]
        public ActionResult Create(condominio modelo)
        {
            try
            {
                // TODO: Add insert logic here
                controle.AdicionaCondominio(modelo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Condominio/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(controle.RetornaItem(id));
        }

        //
        // POST: /Condominio/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, condominio collection)
        {
            try
            {
                // TODO: Add update logic here
                controle.SalvaCondominio(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Condominio/Delete/5
 
        public ActionResult Delete(int id)
        {
            
            return View(controle.RetornaItem(id));
        }

        //
        // POST: /Condominio/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, condominio modelo)
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
    }
}
