using System.Data.Entity;
using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using Core.Entities.Abstract;

namespace Core.DataAccess.Concrete
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using TContext context = new();
            var deleteEntity = context.Entry(entity);
            deleteEntity.State = EntityState.Modified; // MOdified isDelete false ve ya true oldugunu gosterir
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new ();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using TContext context = new();
            return context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            using TContext context = new ();
            var modifyEntity = context.Entry(entity);
            modifyEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
