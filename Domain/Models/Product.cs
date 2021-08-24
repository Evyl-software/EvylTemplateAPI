using Repository;

namespace Domain.Models
{
    public class Product : Document
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}