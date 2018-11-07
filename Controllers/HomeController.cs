﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vertivina.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.MvcContext;
using System.Threading;

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
        public IActionResult Registrar()
        {
            ViewData["Message"] = "Your Registrar description page.";

            return View();
        }
        

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Resetpass()
        {
            ViewData["Message"] = "Your reset page.";

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

        public IActionResult ListaCita()
        {
           

            return View();
        }


        public IActionResult Faq()
        {
            ViewData["Message"] = "Tienes dudas?";

            return View();
        }

        public IActionResult Comunidad()
        {
            ViewData["Message"] = "Your contact page.";

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Faq([Bind("contactoNombre,tlf,email,msj,nombrePersonal,respuesta,motivos,solicito,fechaInc")] Faq faq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faq);
                await _context.SaveChangesAsync();
                
                return RedirectToAction("ConfirmarFaq","Home");
            }
            return View(faq);
        }

        public async Task<IActionResult> Registrar([Bind("names,email,user,pass,pass2")] Registrar registrar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrar);
                await _context.SaveChangesAsync();

                return RedirectToAction("ConfirmarRegistrar", "Home");
            }
            return View(registrar);
        }
        public IActionResult ConfirmarRegistrar()
        {
            return View();
        }
        public IActionResult ConfirmarFaq()
        {
            return View();
        }
        public IActionResult Confirmar()
        {
            return View();    
        }
        public IActionResult Adopcion()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adopcion([Bind("NombreDueño,Mascota,Telefono,TipoTelefono,NombreMascota,FechaAdop,TipoMascota,TipoMascota,Ocupacion,Direccion,Motivo1,Motivo2,Motivo3")] Adopcion adopcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adopcion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Confirmar");
            }
            return View(adopcion);
        }
      
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      

    }
}
