using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Morgan_Bay.Models;

namespace Morgan_Bay.Controllers
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View("Views\\Home\\Reservations\\Index.cshtml");
        }

        [Route("Index/Create")]
        public IActionResult Create()
        {
            return View("Views\\Home\\Reservations\\Create.cshtml");
        }

        [HttpGet]
        [Route("Clients")]
        public IActionResult Clients()
        {
            return View("Views\\Home\\Clients\\Index.cshtml");
        }

        [Route("Clients/Create")]
        public IActionResult ClientsCreate()
        {
            return View("Views\\Home\\Clients\\Create.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
