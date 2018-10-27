using System.Collections.Generic;

namespace Products_and_Categories.Models
{
    public class CreateCategoryViewModel
    {
        public Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}