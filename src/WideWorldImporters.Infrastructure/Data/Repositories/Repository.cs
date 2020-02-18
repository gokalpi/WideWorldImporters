using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly WideWorldImportersContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(WideWorldImportersContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _dbSet = _dbContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual int Count(Expression<Func<T, bool>> predicate = null)
        {
            return _dbSet.Count(predicate);
        }

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await _dbSet.CountAsync(predicate);
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
                                            Expression<Func<T, object>> groupBy = null,
                                            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                            string includeString = null,
                                            bool disableTracking = true,
                                            int? page = null,
                                            int? pageSize = null)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(includeString))
                query = query.Include(includeString);

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                return orderBy(query).ToList();

            if (groupBy != null)
                query = query.GroupBy(groupBy).SelectMany(x => x);

            if (page.HasValue && pageSize.HasValue)
            {
                query = query.Skip(page.Value * pageSize.Value)
                             .Take(pageSize.Value);
            }

            return query.ToList();
        }

        public virtual IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
                                            Expression<Func<T, object>> groupBy = null,
                                            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                            List<Expression<Func<T, object>>> includes = null,
                                            bool disableTracking = true,
                                            int? page = null,
                                            int? pageSize = null)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return orderBy(query).ToList();

            if (groupBy != null)
                query = query.GroupBy(groupBy).SelectMany(x => x);

            if (page.HasValue && pageSize.HasValue)
            {
                query = query.Skip(page.Value * pageSize.Value)
                             .Take(pageSize.Value);
            }

            return query.ToList();
        }

        public virtual IReadOnlyList<T> GetAll(int? page = null, int? pageSize = null)
        {
            IQueryable<T> query = _dbSet;

            if (page.HasValue && pageSize.HasValue)
            {
                query = query.Skip(page.Value * pageSize.Value)
                             .Take(pageSize.Value);
            }

            return query.ToList();
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync(int? page = null, int? pageSize = null)
        {
            IQueryable<T> query = _dbSet;

            if (page.HasValue && pageSize.HasValue)
            {
                query = query.Skip(page.Value * pageSize.Value)
                             .Take(pageSize.Value);
            }

            return await query.ToListAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                                             Expression<Func<T, object>> groupBy = null,
                                                             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                             string includeString = null,
                                                             bool disableTracking = true,
                                                             int? page = null,
                                                             int? pageSize = null)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            if (groupBy != null)
                query = query.GroupBy(groupBy).SelectMany(x => x);

            if (page.HasValue && pageSize.HasValue)
            {
                query = query.Skip(page.Value * pageSize.Value)
                             .Take(pageSize.Value);
            }

            return await query.ToListAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                                             Expression<Func<T, object>> groupBy = null,
                                                             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                             List<Expression<Func<T, object>>> includes = null,
                                                             bool disableTracking = true,
                                                             int? page = null,
                                                             int? pageSize = null)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            if (groupBy != null)
                query = query.GroupBy(groupBy).SelectMany(x => x);

            if (page.HasValue && pageSize.HasValue)
            {
                query = query.Skip(page.Value * pageSize.Value)
                             .Take(pageSize.Value);
            }

            return await query.ToListAsync();
        }

        public virtual T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            _dbSet
                .Attach(entity)
                .State = EntityState.Modified;
        }
    }
}