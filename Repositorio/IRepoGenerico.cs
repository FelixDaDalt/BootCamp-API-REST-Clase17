namespace BootCamp_API_REST_Clase17.Repositorio
{
    public interface IRepoGenerico<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(int id);
    }
}
