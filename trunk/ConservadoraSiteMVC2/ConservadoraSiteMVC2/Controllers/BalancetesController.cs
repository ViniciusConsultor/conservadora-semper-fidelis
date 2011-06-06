using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConservadoraSiteMVC2.Models;
using System.IO;

namespace ConservadoraSiteMVC2.Controllers
{
    public class BalancetesController : Controller
    {
        //
        // GET: /Balancetes
        private static Balancetes controle = new Balancetes();
        private static Moradores controleMorador = new Moradores();

        [Authorize]
        public ActionResult Index()
        {
            moradores mor = controleMorador.RetornaItem(User.Identity.Name);
            balancete[] bal = controle.RetornaBAlancetesPorMorador(mor).ToArray();
            return View(bal);
        }

        //
        // GET: /Balancetes/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Balancetes/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Balancetes/Create

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
        // GET: /Balancetes/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Balancetes/Edit/5

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
        // GET: /Balancetes/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Balancetes/Delete/5

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

        [Authorize]
        public FileStreamResult Download(int id)
        {
            balancete ataa = controle.RetornaItem(id);

            FileStreamResult f = new FileStreamResult(new FileStream(ataa.caminhoArquivo, FileMode.Open), Path.GetExtension(ataa.caminhoArquivo));
            f.FileDownloadName = Path.GetFileName(ataa.caminhoArquivo);
            return f;
        }
    }
}
