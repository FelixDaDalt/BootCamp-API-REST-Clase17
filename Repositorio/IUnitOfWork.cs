namespace BootCamp_API_REST_Clase17.Repositorio
{
    public interface IUnitOfWork : IDisposable
    {
        IRepoProductos RepoProductos{ get; }
        IRepoProveedores RepoProveedores { get; }
        void Save();
    }
}
