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
    public class Productos2Controller : Controller
    {
        private readonly MvcContext _context;
        public Productos2Controller(MvcContext context){
            this._context = context;
        }
        /* 
        public IActionResult Index()
        {
           
            return View();
        }
        */
       
         public async Task<IActionResult> Index(String searchString){
              var productos = from m in _context.Producto2
                 select m;
             if (!String.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.Nombre.Contains(searchString));
            }

            return View(await productos.ToListAsync());
         }
       

        public async Task<IActionResult> Vista(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto2
                .SingleOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }


    }
}