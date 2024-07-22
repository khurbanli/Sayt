using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int ProductCount { get; set; }
        public decimal Price { get; set; }
        public bool IsDiscount { get; set; } // endirim varmi ?
        public int DiscountRate { get; set; } // endirim faizi
    }
}
