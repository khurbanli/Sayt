using Business.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager(IProductDal productDal) : IProductService
    {
        private readonly IProductDal _productDal = productDal;
        public IResult Add(Product product)
        {
            if (product.ProductName.Length > 2)
            {
                _productDal.Add(product);
                return new SuccessResult("product elave olundu");
            }
            else
                return new ErrorResult("product name lenght 2den boyuk olmalidir"); // mesaj gondermeyede bilersen
        }

        public IResult Delete(Product product)
        {
            Product deleteProduct = null;
            Product resultProduct = _productDal.GetAll().SingleOrDefault(p => p.Id == product.Id);
            if (resultProduct != null)
                resultProduct = deleteProduct;
            deleteProduct.IsDelete = true;
            _productDal.Delete(deleteProduct);
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAllProduct()
        {
            var products = productDal.GetAll(p => p.IsDelete == false).ToList();
            if (products.Count > 0)
                return new SuccessDataResult<List<Product>>(products, "products loaded successfuly");
            else
                return new ErrorDataResult<List<Product>>(products, "xeta bas verdi");
        }

        public IDataResult<Product> GetProduct(Product product)
        {
            var products = _productDal.Get(p => p.Id == product.Id);
            return new SuccessDataResult<Product>(products, "get product loaded");
        }

        public IResult Update(Product product)
        {
            Product updateProduct;
            updateProduct = _productDal.Get(p => p.Id == product.Id && p.IsDelete == false);
            updateProduct.ProductName = product.ProductName;
            updateProduct.ProductCount = product.ProductCount;
            updateProduct.Price = product.Price;
            updateProduct.Description = product.Description;
            _productDal.Update(product);
            return new SuccessResult();
        }
    }

}
