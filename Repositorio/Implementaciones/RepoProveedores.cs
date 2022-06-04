using BootCamp_API_REST_Clase17.Context;
using BootCamp_API_REST_Clase17.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCamp_API_REST_Clase17.Repositorio.Implementaciones
{
    public class RepoProveedores: RepoGenerico<Proveedores>, IRepoProveedores
    {
        public RepoProveedores(context context) : base(context)
        { 
        
        }

    }
}
