using BootCamp_API_REST_Clase17.Models;

namespace BootCamp_API_REST_Clase17.Repositorio
{
    public interface IRepoProductos : IRepoGenerico<Productos>
    {
        IEnumerable<Productos> ProdProv();
        Productos ProdProv(int id);
    }
}
