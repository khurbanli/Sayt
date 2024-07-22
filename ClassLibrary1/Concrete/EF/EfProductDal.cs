using System.Linq.Expressions;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EF
{
    public class EfProductDal : BaseRepository<Product, BaseProjectContext>, IProductDal
    {
       
    }
}
