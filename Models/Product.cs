using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Products_and_Categories.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}