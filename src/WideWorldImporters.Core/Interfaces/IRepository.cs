using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WideWorldImporters.Core.Entities;

namespace WideWorldImporters.Core.Interfaces
{
    public interface IRepository<T> : IRepository<T, int> where T : Entity
    {
    }

    public interface IRepository<T, TId> where T : Entity<TId>
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        List<Expression<Func<T, object>>> includes = null,
                                        bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec);

        Task<T> GetByIdAsync(TId id);

        Task<int> CountAsync(ISpecification<T> spec);

        IReadOnlyList<T> GetAll();

        IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate);

        IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disableTracking = true);

        IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        List<Expression<Func<T, object>>> includes = null,
                                        bool disableTracking = true);

        IReadOnlyList<T> Get(ISpecification<T> spec);

        int Count(ISpecification<T> spec);

        T GetById(TId id);

        Task AddAsync(T entity);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}