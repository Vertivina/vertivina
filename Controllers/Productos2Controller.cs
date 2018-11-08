using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models.MvcContext;

namespace vertivina.Controllers
{
    public class Productos2Controller : Controller
    {
        private readonly MvcContext _context;
        public Productos2Controller(MvcContext context){
            this._context = context;
        }
        public IActionResult Index()
        {
            //var productos = from m in _context.Productos2 select m;
            //return View(productos);
            return View();
        }
        
        //Por si se quiere conectar a la base de datos aqui está el codigo
        /* 
         public async Task<IActionResult> Index(searchString){
              var productos = from m in _context.Productos2
                 select m;
             if (!String.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.Nombre.Contains(searchString));
            }

            return View(await productos.ToListAsync());
         }
        */


    }
}