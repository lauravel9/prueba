using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace prueba.Controllers.Quotes
{
    [Route("[controller]")]
    public class QuoteRemoveController : Controller
    {
        private readonly ILogger<QuoteRemoveController> _logger;

        public QuoteRemoveController(ILogger<QuoteRemoveController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}