using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using annotations.Models;
using Microsoft.EntityFrameworkCore;

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
            // Artista _Artista = new Artista(){ CON ESTO CREEAS UNO
            //     Nombre="Jimmy Hendrix",
            //     IdGenero=1,
            //     Nacionalidad="EEUU",
            //     Altura= 1.78,
            //     FechaNacimiento=DateTime.Now,
            //     LugarNacimiento="Street 14",
            //     AnioInicio=1974
            // };
            // ctx.Artista.Add(_Artista);
            // ctx.SaveChanges();
            ViewBag.Artistas = ctx.Artista.Include("Genero").ToList();
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
