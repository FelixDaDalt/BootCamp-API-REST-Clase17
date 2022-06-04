using BootCamp_API_REST_Clase17.Context;
using Microsoft.EntityFrameworkCore;

namespace BootCamp_API_REST_Clase17.Repositorio.Implementaciones
{
    public class RepoGenerico<TEntity> : IRepoGenerico<TEntity> where TEntity : class
    {
        protected readonly context _context;

        public RepoGenerico(context _context) 
        { 
            this._context = _context;
        }


        public TEntity Delete(int id)
        {
           var model = GetById(id);
           _context.Set<TEntity>().Remove(model);
           _context.SaveChanges();
           return model;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            var model = _context.Set<TEntity>().Find(id);
            return model;
        }

        public TEntity Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
