using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConservadoraSiteMVC2.Models;

namespace ConservadoraSiteMVC2.Controllers
{
    public class RecadosController : Controller
    {
        //
        // GET: /Recados/
        public static Recados controle = new Recados();
        public static Moradores controleMorador = new Moradores();

        [Authorize]
        public ActionResult Index()
        {
            moradores mor = controleMorador.RetornaItem(User.Identity.Name);
            recado[] rec = controle.RetornaRecadosPorMorador(mor).ToArray();
            return View(rec);
        }

        //
        // GET: /Recados/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Recados/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Recados/Create

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
        // GET: /Recados/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Recados/Edit/5

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
        // GET: /Recados/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Recados/Delete/5

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
