using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Helpers.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product prduct);
        IResult Update(Product prduct);
        IResult Delete(Product prduct);
        IDataResult<List<Product>> GetAllProduct();
        IDataResult<Product> GetProduct(Product product);
    }
}
