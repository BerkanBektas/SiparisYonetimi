using SiparisYonetimi.Data;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi.Business.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        internal DatabaseContext _context;
        internal DbSet<T> _dbSet;
        public Repository()
        {
            if (_context == null)
            {
                _context = new DatabaseContext();//_context'i doldur 
                _dbSet = _context.Set<T>();//Yukarda tanımladığımız _dbset'i parametreyle gelen class'a göre ayarla 

            }
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToList();
        }

        public int SaveChanges(T entity)
        {
            return _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
