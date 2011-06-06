using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConservadoraSiteMVC2.Models;

namespace ConservadoraSiteMVC2.Controllers
{
    public class BoletosController : Controller
    {
        //
        // GET: /Boletos/

        public static Boletos controle = new Boletos();
        public static Moradores controleMorador = new Moradores();

        [Authorize]
        public ActionResult Index()       
        {

            moradores mor = controleMorador.RetornaItem(User.Identity.Name);

            boleto[] bols = controle.RetornaLista().Where(p => p.idmoradores == mor.idmoradores).ToArray();
            return View(bols);
        }

        //
        // GET: /Boletos/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Boletos/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Boletos/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Boletos/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Boletos/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Boletos/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Boletos/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
