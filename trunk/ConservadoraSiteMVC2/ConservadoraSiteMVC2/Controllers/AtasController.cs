using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConservadoraSiteMVC2.Models;
using System.IO;

namespace ConservadoraSiteMVC2.Controllers
{
    public class AtasController : Controller
    {
        //
        // GET: /Atas/
        public static Atas controle = new Atas();
        public static Moradores controleMorador = new Moradores();

        [Authorize]
        public ActionResult Index()
        {

            moradores mor = controleMorador.RetornaItem(User.Identity.Name);
            ata[] atas = controle.RetornaAtasPorMorador(mor).ToArray();
            return View("Index",atas);
        }

        //
        // GET: /Atas/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Atas/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Atas/Create

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
        // GET: /Atas/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Atas/Edit/5

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
        // GET: /Atas/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Atas/Delete/5

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
            ata ataa = controle.RetornaItem(id);
            
            FileStreamResult f = new FileStreamResult(new FileStream(ataa.caminhoArquivo,FileMode.Open), Path.GetExtension(ataa.caminhoArquivo));
            f.FileDownloadName = Path.GetFileName(ataa.caminhoArquivo);
            return f;
        }
    }
}
