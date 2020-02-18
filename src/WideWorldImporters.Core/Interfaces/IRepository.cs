using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WideWorldImporters.Core.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        void Add(T entity);

        Task AddAsync(T entity);

        int Count(Expression<Func<T, bool>> predicate = null);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);

        void Delete(T entity);

        IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
                             Expression<Func<T, object>> groupBy = null,
                             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                             string includeString = null,
                             bool disableTracking = true,
                             int? page = null,
                             int? pageSize = null);

        IReadOnlyList<T> Get(Expression<Func<T, bool>> predicate = null,
                             Expression<Func<T, object>> groupBy = null,
                             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                             List<Expression<Func<T, object>>> includes = null,
                             bool disableTracking = true,
                             int? page = null,
                             int? pageSize = null);

        IReadOnlyList<T> GetAll(int? page = null, int? pageSize = null);

        Task<IReadOnlyList<T>> GetAllAsync(int? page = null, int? pageSize = null);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Expression<Func<T, object>> groupBy = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disableTracking = true,
                                        int? page = null,
                                        int? pageSize = null);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Expression<Func<T, object>> groupBy = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        List<Expression<Func<T, object>>> includes = null,
                                        bool disableTracking = true,
                                        int? page = null,
                                        int? pageSize = null);

        T GetById(object id);

        Task<T> GetByIdAsync(object id);

        void Update(T entity);
    }
}