using Business.Concrete;
using DataAccess.Concrete.EF;
using Entities.Concrete;

ProductManager productManager = new(new EfProductDal());
Product product1 = new() { Id = 1, ProductName = "Iphone", Description = "256ssd 6ram black", Price = 3500, ProductCount = 10, IsDiscount = false, DiscountRate = 0, IsDelete = false };
//productManager.Add(product1);
//productManager.Delete(product1);

/*var productAll = productManager.GetAllProduct();
foreach (var item in productAll)
{
    Console.WriteLine(item.ProductName); // list sekilinde oldugu ucun foreach saldig
}*/

/*foreach (var deleteProduct in productManager.GetAllProduct())
{
    if (deleteProduct.Id == 2)
        productManager.Delete(deleteProduct);
}

CustomerManager customerManager = new(new EfCustomerDal());
Customer customer1 = new() { Id = 1, FirstName = "adam" };
customerManager.Add(customer1);*/

/*Product getProduct = null;
foreach (var products in allgetProduct)
{
    if (product1.Id == 8)
        getProduct = productManager.GetProduct(products);
}*/
var allProduct = productManager.GetAllProduct();

Console.WriteLine(allProduct.Message);

foreach (var item in allProduct.Data)
{
    Console.WriteLine(item.ProductName);
}