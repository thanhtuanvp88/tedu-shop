﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        void DeleteMulti(Expression<Func<T, bool>> where);
        T GetSingleById(int id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);
        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> condition, string[] includes = null);
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> condition,out int total, int index = 0, int size = 50, string[] includes = null);
        int Count(Expression<Func<T, bool>> condition);
    }
}
