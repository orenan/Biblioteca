using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca.Controllers {
    public class BookController : Controller {
        private readonly BookContext _context;

        public BookController(BookContext context)
        {
            _context = context;
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,ReleaseYear,Publisher")] Book book)
        {
            if(!ModelState.IsValid)
            {
                return NotFound();
            }

            _context.Add(book);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Show), new { id = book.Id});
        }

        public async Task<IActionResult> Show(int? id) {
            if(id == null) {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(book => book.Id == id);

            if(book == null) {
                return NotFound();
            }

            return View(book);
        }
    }
}