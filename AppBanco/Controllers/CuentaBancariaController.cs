using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppBanco.Models;
using AppBanco.Data; // Assuming you have a service layer

namespace AppBanco.Controllers
{
    public class CuentaBancariaController : Controller
    {
        private readonly ILogger<CuentaBancariaController> _logger;
        private readonly ApplicationDbContext _context;

        public CuentaBancariaController(ILogger<CuentaBancariaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context= context;
            
        }

        // GET: CuentaBancaria/Create
        
        public IActionResult Create()
        {
            return View();
        }

        // POST: CuentaBancaria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, and validate them if needed.
        [HttpPost]
 // Prevent CSRF attacks
        public IActionResult EnviarMensaje(CuentaBancaria objcontato)
        {
            _logger.LogDebug("Ingreso a Enviar Mensaje");

            //Se registran los datos del objeto a la base datos
            _context.Add(objcontato);
            _context.SaveChanges();

            ModelState.Clear();

            ViewData["Message"] = "Se registro el contacto";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
