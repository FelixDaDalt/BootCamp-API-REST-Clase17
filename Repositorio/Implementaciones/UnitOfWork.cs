using BootCamp_API_REST_Clase17.Context;
using BootCamp_API_REST_Clase17.Repositorio.Implementaciones;
using Microsoft.EntityFrameworkCore;

namespace BootCamp_API_REST_Clase17.Repositorio
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly context _context;
        public IRepoProductos RepoProductos { get; }
        public IRepoProveedores RepoProveedores { get; }

        public UnitOfWork(context contexto)
        {
            this._context = contexto;
            RepoProveedores = new RepoProveedores(contexto);
            RepoProductos = new RepoProductos(contexto);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
