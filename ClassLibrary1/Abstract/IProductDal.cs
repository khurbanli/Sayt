using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal : IBaseRepository<Product>
    {
        //List<Product> GetProductsByCategory(int categortId);
    }
}
