using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using annotations.Models;

namespace annotations.Controllers
{
    public class HomeController : Controller
    {

        MusicCTX ctx;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,MusicCTX _context)
        {
            _logger = logger;
            ctx=_context;
        }

        public IActionResult Index()
        {
            ViewBag.Generos = ctx.Genero.ToList(); // esto es igual a un select * from genero

            return View();
        }

        
        [BindProperty]
        public Usuarios _Usuario {get;set;}
        public IActionResult SetUsuario()
        {
            return Json(_Usuario);
            // return View();
        }

    }
}
