using BAKERY.Domain.Entites;

namespace BAKERY.Domain.Repositories
{
    /// <summary>
    /// Репозиторий булочки
    /// </summary>
    public interface IBunRepository
    {
        /// <summary>
        /// Полный список
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Bun>> GetAll();


        /// <summary>
        /// Добавить новых булочек
        /// </summary>
        /// <param name="buns"></param>
        /// <returns></returns>
        Task Create(IEnumerable<Bun> buns);
    }
}
