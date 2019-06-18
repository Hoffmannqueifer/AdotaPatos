﻿using AdotaPatos.DAO;
using AdotaPatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdotaPatos.Controllers
{
    public class AdocaoController : Controller
    {

        AdocaoDAO adocaoDAO = new AdocaoDAO();


        // GET: Adocao
        public ActionResult Index()
        {
            var teste = adocaoDAO.Listar();
            return View(teste);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Adocao adocao)
        {
            if (!ModelState.IsValid)
            {
                return View(adocao);
            }

            adocaoDAO.Salvar(adocao);
            return RedirectToAction(nameof(Index));
        }


        public ActionResult Details(long id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }

            var teste = adocaoDAO.PorId(id);
            return View(teste);
        }


        public ActionResult Edit(long id)
        {
            var teste = adocaoDAO.PorId(id);
            return View(teste);
        }


        [HttpPost]
        public ActionResult Edit(Adocao adocao)
        {
            if (!ModelState.IsValid)
            {
                return View(adocao);
            }

            adocaoDAO.Atualizar(adocao);
            return RedirectToAction(nameof(Index));
        }


        public ActionResult Delete(long id)
        {
            var teste = adocaoDAO.PorId(id);
            return View(teste);
        }


        [HttpPost]
        public ActionResult Delete(long? id)
        {
            adocaoDAO.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}