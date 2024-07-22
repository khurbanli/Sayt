using Core.Entities.Abstract;

namespace Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
