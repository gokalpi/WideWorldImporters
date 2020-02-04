using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WideWorldImporters.Core.Entities;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Infrastructure.Data.Repositories
{
    public class Repository<T> : Repository<T, int> where T : Entity
    {
        public Repository(WideWorldImportersContext dbContext) : base(dbContext)
        {
        }
    }

    public class Repository<T, TId> : IRepository<T, TId> where T : Entity<TId>
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

        public virtual int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }

        public virtual async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public virtual IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeString = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return orderBy(query).ToList();

            return query.ToList();
        }

        public virtual IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>> includes = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return  orderBy(query).ToList();

            return  query.ToList();
        }

        public virtual IReadOnlyList<T> Get(ISpecification<T> spec)
        {
            return ApplySpecification(spec).ToList();
        }

        public virtual IReadOnlyList<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeString = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>> includes = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public virtual T GetById(TId id)
        {
            return _dbSet.Find(id);
        }

        public virtual async Task<T> GetByIdAsync(TId id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            _dbSet
                .Attach(entity)
                .State = EntityState.Modified;
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T, TId>.GetQuery(_dbSet.AsQueryable(), spec);
        }
    }
}