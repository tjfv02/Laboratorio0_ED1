using Lab0_Estructuras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab0_Estructuras.Controllers
{
    
    public class ClientesController : Controller
    {
        public static List<Cliente> Guardando = new List<Cliente>();

        // GET: Clientes
        public ActionResult Index()
        {
            return View(Guardando);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Cliente Ingreso = new Cliente()
                {

                    Nombre=collection["Nombre"],
                    Apellido=collection["Apellido"],
                    Telefono=collection["Telefono"],
                    Descripcion=collection["Descripcion"]

                };
                Guardando.Add(Ingreso);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
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

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Cliente Eliminado = new Cliente()
                {
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Telefono = collection["Telefono"],
                    Descripcion = collection["Descripcion"]

                };
                Guardando.Remove(Eliminado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();

            }
        }
        public ActionResult OrdenarNombre()
        {
            Guardando.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
            return View(Guardando);
        }
        public ActionResult OrdenarApellido()
        {
            Guardando.Sort((x, y) => x.Apellido.CompareTo(y.Apellido));
            return View(Guardando);
        }
    }
}
