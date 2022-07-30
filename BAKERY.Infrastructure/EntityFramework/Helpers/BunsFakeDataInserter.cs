using BAKERY.Application.Helpers;
using BAKERY.Domain.Entites;
using BAKERY.Infrastructure.EntityFramework.Contexts;

namespace BAKERY.Infrastructure.EntityFramework.Helpers
{
    public static class BunsFakeDataInserter
    {
        public static void Insert(DataBaseContext dataBaseContext)
        {
            var bun = new Bun(
                BunRandomGenerator.GetRandomType(),
                BunRandomGenerator.GetRandomHoursCountForSale(),
                BunRandomGenerator.GetRandomSaleDeadline(),
                BunRandomGenerator.GetRandomBeginPrice()
                );

            dataBaseContext.Add(bun);
            dataBaseContext.SaveChanges();
        }
    }
}
