using CRUD_ASP_NET_CORE.Data;
using CRUD_ASP_NET_CORE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP_NET_CORE.Controllers
{
    public class LibrosController : Controller
    {
        private readonly AplicationDbContext _context;

        public LibrosController(AplicationDbContext context)
        {

            _context = context;

        }
        //
        public IActionResult Index()
        {
            IEnumerable<Libro> listaLibros = _context.Libro;
            return View(listaLibros);
        }

        //http get create
        public IActionResult Create()
        {
        
            return View();
        }

        //http post create
        [HttpPost]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "El libro se a creado correctamente";
            }

            return View();
        }

        //http get edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener el libro

            var libro = _context.Libro.Find(id);

            if (libro == null)
            {
                return NotFound();
            }


            return View(libro);
        }

        //http post edit
        [HttpPost]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Update(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "El libro se a actualizado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }



        //http get delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener el libro

            var libro = _context.Libro.Find(id);

            if (libro == null)
            {
                return NotFound();
            }


            return View(libro);
        }

        //http post delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(int? id)
        {
            //Obtener el libro id
            var libro = _context.Libro.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            
                _context.Libro.Remove(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "El libro se a borrado correctamente";
                return RedirectToAction("Index");
          
        }


    }
}
