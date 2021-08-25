using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Data {
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}