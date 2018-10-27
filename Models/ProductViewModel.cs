using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Products_and_Categories.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories {get;set;}
    }
}