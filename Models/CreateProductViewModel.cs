using System.Collections.Generic;

namespace Products_and_Categories.Models
{
    public class CreateProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}