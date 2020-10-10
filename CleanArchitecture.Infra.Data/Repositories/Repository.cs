using CleanArchitecture.App.Interfaces;
using CleanArchitecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CleanArchitecture.Infra.Data.Repositories
{
    class Repository<T> : IRepository<T> where T : EntityBase
    {
        readonly PrimaryDBContext _context;


        public Repository(PrimaryDBContext context)
        {
            _context = context;
        }


        public virtual T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> List()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsEnumerable();
        }



        public virtual  void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }



        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }


      
    }
}
