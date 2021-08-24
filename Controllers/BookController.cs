using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Biblioteca.Controllers {
    public class BookController : Controller {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger) {
            _logger = logger;
        }

        public IActionResult New() {
            return View();
        }
    }
}