using Aula1306.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1306.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            //Usando View Bag
            //List<string> categorias = new List<string>();

            //categorias.Add("Carros");
            //categorias.Add("Motos");
            //categorias.Add("Barcos");
            //categorias.Add("Aviões");
            //categorias.Add("Caminhões");

            //ViewBag.ListaCategorias = categorias;

            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria() { Nome = "Carros" });
            categorias.Add(new Categoria() { Nome = "Motos" });
            categorias.Add(new Categoria() { Nome = "Barcos" });
            categorias.Add(new Categoria() { Nome = "Aviões" });
            categorias.Add(new Categoria() { Nome = "Caminhões" });

            return View(categorias);
        }

        public ActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}