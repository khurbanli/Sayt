using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
