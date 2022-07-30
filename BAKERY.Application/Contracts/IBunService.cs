using BAKERY.Application.Dtos.Responses;

namespace BAKERY.Application.Contracts
{
    public interface IBunService
    {
        Task<IEnumerable<BunDto>> GetAll();

        Task GenerateRandomBunsByCount(int count);
    }
}
