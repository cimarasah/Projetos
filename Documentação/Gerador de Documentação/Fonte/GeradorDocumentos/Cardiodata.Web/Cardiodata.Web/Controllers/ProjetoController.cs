using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GeradorDocumentos.Modelo.ConfiguracaoDocumento;
using GeradorDocumentos.Web.Models;

namespace GeradorDocumentos.Web.Controllers
{
    public class ProjetoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Projeto
        public ActionResult Index()
        {
            return View(db.ProjetoModels.ToList());
        }

        // GET: Projeto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjetoModel projetoModel = db.ProjetoModels.Find(id);
            if (projetoModel == null)
            {
                return HttpNotFound();
            }
            return View(projetoModel);
        }

        // GET: Projeto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projeto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Resumo")] ProjetoModel projetoModel)
        {
            if (ModelState.IsValid)
            {
                db.ProjetoModels.Add(projetoModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projetoModel);
        }

        // GET: Projeto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjetoModel projetoModel = db.ProjetoModels.Find(id);
            if (projetoModel == null)
            {
                return HttpNotFound();
            }
            return View(projetoModel);
        }

        // POST: Projeto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Resumo")] ProjetoModel projetoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projetoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projetoModel);
        }

        // GET: Projeto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjetoModel projetoModel = db.ProjetoModels.Find(id);
            if (projetoModel == null)
            {
                return HttpNotFound();
            }
            return View(projetoModel);
        }

        // POST: Projeto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjetoModel projetoModel = db.ProjetoModels.Find(id);
            db.ProjetoModels.Remove(projetoModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
