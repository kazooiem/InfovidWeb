using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfovidWeb.Models;
using System.Web.Mvc;

namespace InfovidWeb.Controllers
{
    public class ComunaController : Controller
    {
        // GET: Comuna
        public ActionResult Index()
        {
            List<ComunaCLS> listaComuna = null;
            using (var bd=new BDComuna())
            {
                listaComuna = (from comuna in bd.Comuna
                              select new ComunaCLS
                              {
                                  idcomuna = comuna.IdComuna,
                                  nombre = comuna.Nombre,
                                  fase = comuna.Fase
                              }).ToList();
            }
                return View(listaComuna);
        }
    }
}