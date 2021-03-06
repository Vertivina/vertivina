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

        public void RecargarCitas(){
            var doctor=_context.Doctor.ToList();
            var servicio=_context.Servicio.ToList();
            ViewBag.Doctores= new SelectList(doctor,"ID","Nombre");
            ViewBag.Horarios= new SelectList(doctor,"ID","Horario");
            ViewBag.Servicios= new SelectList(servicio,"ID","Nombre");
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            ViewData["Message"] = "Registre aqui";

            return View();
        }
        

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult MenuUsuario()
        {

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

        public async Task<IActionResult> ListaCita(string searchString)
        {
             var citas = from m in _context.Cita select m;
               if (!String.IsNullOrEmpty(searchString))
            {
                citas = citas.Where(s => s.Nombre.Contains(searchString) || s.Mascota.Contains(searchString));
            }
            ViewData["Local"]="En el local";

            return View(await citas.ToListAsync());
        }
       
         public async Task<IActionResult> ListaAdopcion(string searchString)
        {
             var adopciones = from m in _context.Adopcion
             select m;
               if (!String.IsNullOrEmpty(searchString))
            {
                adopciones= adopciones.Where(s => s.NombreDueño.Contains(searchString));
            }

            return View(await adopciones.ToListAsync());
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
        public async Task<IActionResult> EditarCita(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicio = await _context.Cita.SingleOrDefaultAsync(m => m.ID == id);
            if (servicio == null)
            {
                return NotFound();
            }
            return View(servicio);
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarCita(int id, [Bind("ID,Nombre,Mascota,Telefono,TipoTelefono,Doctor,Fecha,Hora,TipoMascota,TipoCita,Direccion")] Cita cita)
        {
            if (id != cita.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                //await TryUpdateModelAsync(cita);

                //var citaN = await _context.Cita.SingleOrDefaultAsync(m => m.ID == id);
               /* if(citaN!=null){
                    _context.Entry(citaN).CurrentValues.SetValues(cita);

                }*/
             
                try
                {
                    _context.Update(cita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CitaExists(cita.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ListaCita");
            }
            return View(cita);
        }

         private bool CitaExists(int id)
        {
            return _context.Cita.Any(e => e.ID == id);
        }

         public async Task<IActionResult> EliminarCita(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicio = await _context.Cita
                .SingleOrDefaultAsync(m => m.ID == id);
            if (servicio == null)
            {
                return NotFound();
            }

            return View(servicio);
        }

        [HttpPost, ActionName("EliminarCita")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicio = await _context.Cita.SingleOrDefaultAsync(m => m.ID == id);
            _context.Cita.Remove(servicio);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListaCita");
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registrar([Bind("names,email,user,pass,pass2")] Registrar registrar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrar);
                await _context.SaveChangesAsync();

                return RedirectToAction("ConfirmarRegistrar", "Home");
            }
            return View(registrar); /*  sss */
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
        /*Para la conexion con la base de datos
         public  async Task<IActionResult> Adopcion(String buscar)
        {
             var adopciones = from m in _context.Mascota
                 select m;
             if (!String.IsNullOrEmpty(buscar))
            {
               adopciones  = adopciones .Where(s => s.nombre.Contains(buscar));
            }

            return View(await adopciones.ToListAsync());
        }*/
      
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
