using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models.MvcContext;

namespace vertivina.Controllers
{
    public class ComunidadController : Controller
    {
        private readonly MvcContext _context;
        public ComunidadController(MvcContext context){
            this._context = context;
        }
        public IActionResult Index()
        {
            //var productos = from m in _context.Productos2 select m;
            //return View(productos);
            return View();
        }


    }
}