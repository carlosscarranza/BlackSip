using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BS.Infrastructure
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private readonly BlackSipContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(BlackSipContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public EntityEntry<TEntity> CreateReturn(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities) Create(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await _dbSet.FindAsync(keyValues);
        }

        public TEntity FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IQueryable<TEntity> SelectQuery(string query, params object[] parameters)
        {
            return _context.Set<TEntity>().FromSql(query, parameters).AsQueryable();
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached) _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }

        public async Task Delete(params object[] id)
        {
            var entity = await FindAsync(id);
            if (entity != null) Delete(entity);
        }

        public IEnumerable<TEntity> SqlQuery(string sql, params object[] parameters)
        {
            return _context.Set<TEntity>().FromSql(sql, parameters).ToList();
        }

        public TEntity Find(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includeProperties = "")
        {
            try
            {
                IQueryable<TEntity> query = _dbSet;
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

                if (orderby != null)
                {
                    query = orderby(query);
                }

                return query?.FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
