using BAKERY.Application.Contracts;
using BAKERY.Application.Dtos.Responses;
using BAKERY.Application.Helpers;
using BAKERY.Domain.Entites;
using BAKERY.Domain.Repositories;

namespace BAKERY.Application.Services
{
    public class BunService : IBunService
    {
        private readonly IBunRepository _bunRepository;
        public BunService(IBunRepository bunRepository)
        {
            _bunRepository = bunRepository;
        }

        public async Task<IEnumerable<BunDto>> GetAll()
        {
            var entities = await _bunRepository.GetAll();
            return entities.OrderByDescending(x => x.BakingDate).Select(x => new BunDto(x));
        }

        public async Task GenerateRandomBunsByCount(int count)
        {
            var randomBuns = new List<Bun>();
            for (int i = 0; i < count; i++)
            {
                var bun = new Bun(
                    BunRandomGenerator.GetRandomType(),
                    BunRandomGenerator.GetRandomHoursCountForSale(),
                    BunRandomGenerator.GetRandomSaleDeadline(),
                    BunRandomGenerator.GetRandomBeginPrice());

                randomBuns.Add(bun);
            };

            await _bunRepository.Create(randomBuns);
        }
    }
}
