using BAKERY.Domain.Entites;

namespace BAKERY.Domain.Helpers
{
    /// <summary>
    /// Калькулятор рассчёт следующей стоимости булочки
    /// </summary>
    public static class BunNextCurrentPriceCalculator
    {
        public static double Calculate(Bun bun)
        {
            double nextCurrentPrice;
            switch (bun.Type)
            {
                case Enums.BunType.Pretzel:
                    nextCurrentPrice = bun.CurrentPrice - bun.AmountOfReductionPerHour * 2;
                    break;

                default :
                    nextCurrentPrice = bun.CurrentPrice - bun.AmountOfReductionPerHour;
                    break;
            }

            return (nextCurrentPrice > 0) ? nextCurrentPrice : 0;
        }
    }
}
