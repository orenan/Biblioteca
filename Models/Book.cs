using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models {
    public class Book {
        public uint Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        
        [StringLength(14, MinimumLength = 3)]
        [RegularExpression(@"[0-9]{3}-[0-9]{10}|[0-9]{13}")]
        [Required]
        public string ISBN { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Author { get; set; }
        
        [Range(1, 2021)]
        public uint ReleaseYear { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Publisher { get; set; }
    }
}