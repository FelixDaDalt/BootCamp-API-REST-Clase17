using BootCamp_API_REST_Clase17.Context;
using BootCamp_API_REST_Clase17.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCamp_API_REST_Clase17.Repositorio.Implementaciones
{
    public class RepoProductos: RepoGenerico<Productos>, IRepoProductos
    {
        private context context;

        public RepoProductos(context context) : base(context)
        { 
            this.context = context;
        }

        public IEnumerable<Productos> ProdProv()
        {
            var aux = context.Productos.Include(x => x.Proveedor).ToList();
            return aux;
        }

        public Productos ProdProv(int id)
        {
            var aux = context.Productos.Where(x => x.Id == id).Include(x => x.Proveedor).FirstOrDefault();
            return aux;
        }
    }
}
