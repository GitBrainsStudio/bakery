using BAKERY.Domain.Entites;
using BAKERY.Domain.Enums;

namespace BAKERY.Domain.Helpers
{
    /// <summary>
    /// Калькулятор рассчета текущей стоимости булочки
    /// </summary>
    public static class BunCurrentPriceCalculator
    {
        public static double Calculate(Bun bun)
        {
            double currentPrice;
            switch (bun.Type)
            {
                case BunType.SourCreamCake:
                    currentPrice = SourCreamCakeCurrentPriceCalculate(bun);
                    break;

                case BunType.Pretzel:
                    currentPrice = PretzelCurrentPriceCalculate(bun);
                    break;

                default:
                    currentPrice = DefaultCurrentPriceCalculate(bun);
                    break;
            }

            return (currentPrice > 0) ? currentPrice : 0;
        }

        /// <summary>
        /// Рассчёт текущий стоимости для сметанника
        /// </summary>
        /// <param name="bun"></param>
        /// <returns></returns>
        private static double SourCreamCakeCurrentPriceCalculate(Bun bun)
            => bun.BeginPrice - bun.AmountOfReductionPerHour * bun.ElapsedHoursAfterBaking * 2;

        /// <summary>
        /// Рассчёт текущий стоимости для кренделя
        /// </summary>
        /// <param name="bun"></param>
        /// <returns></returns>
        private static double PretzelCurrentPriceCalculate(Bun bun)
        {
            double currentPrice;
            currentPrice = bun.BeginPrice - bun.AmountOfReductionPerHour * bun.ElapsedHoursAfterBaking;
            if (DateTime.Now >= bun.SaleDeadline)
            {
                currentPrice = currentPrice / 2;
            }
            return currentPrice;
        }

        /// <summary>
        /// Рассчёт текущий стоимости по умолчанию
        /// </summary>
        /// <param name="bun"></param>
        /// <returns></returns>
        private static double DefaultCurrentPriceCalculate(Bun bun)
            => bun.BeginPrice - bun.AmountOfReductionPerHour * bun.ElapsedHoursAfterBaking;
    }
}
