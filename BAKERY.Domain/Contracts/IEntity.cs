namespace BAKERY.Domain.Contracts
{
    /// <summary>
    /// Доменная сущность
    /// </summary>
    public interface IEntity
    {
       /// <summary>
       /// Идентификатор
       /// </summary>
       Guid Id { get; set; }
    }
}
