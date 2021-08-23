using System.Collections.Generic;

namespace Domain.Models
{
    public class Order
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
