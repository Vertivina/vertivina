using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vertivina.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.MvcContext;

namespace vertivina.Controllers
{
    public class HomeController : Controller
    {

    private readonly MvcContext _context;

         public HomeController(MvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Servicios()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
         public IActionResult Cita()
        {
            ViewData["Message"] = "Registra aqui tu cita";

            return View();
        }
        public IActionResult Comunidad()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Cita(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cita([Bind("Nombre,Mascota,Telefono,TipoTelefono,Doctor,Fecha,Hora,TipoMascota,TipoCita,Direccion")] Cita cita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cita);
                await _context.SaveChangesAsync();
                //return RedirectToAction("Index");
                return RedirectToAction("Confirmar");
            }
           return View(cita);
        }
        public IActionResult Confirmar(){
            return View();
        } 
        public IActionResult Faq(){
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Faq([Bind("contactoNombre,email,msj")] Faq faq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faq);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faq);
        }

          public IActionResult Adopcion()
        {
            //ViewData["Message"] = "Preguntas frecuentes";
            
            
            return View();

        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      

    }
}
