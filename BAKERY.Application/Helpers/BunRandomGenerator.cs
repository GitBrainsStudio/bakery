using BAKERY.Domain.Enums;

namespace BAKERY.Application.Helpers
{
    /// <summary>
    /// Генератор рандомных свойств булочки
    /// </summary>
    public static class BunRandomGenerator
    {
        /// <summary>
        /// Сгенерировать рандомный тип
        /// </summary>
        /// <returns></returns>
        public static BunType GetRandomType()
        {
            Array values = Enum.GetValues(typeof(BunType));
            Random random = new Random();
            return (BunType)values.GetValue(random.Next(values.Length));
        }

        /// <summary>
        /// Сгенерировать рандомную текущую стоимость
        /// </summary>
        /// <returns></returns>
        public static double GetRandomBeginPrice()
        {
            Random random = new Random();
            return random.NextDouble() * (100 - 0) + 0;
        }

        /// <summary>
        /// Сгенерировать рандомное кол-часов для продажи
        /// </summary>
        /// <returns></returns>
        public static int GetRandomHoursCountForSale()
        {
            Random random = new Random();
            return random.Next(0, 50);
        }

        /// <summary>
        /// Сгенерировать рандомную дату создания
        /// </summary>
        /// <returns></returns>
        public static DateTime GetRandomBakingDate()
        {
            Random random = new Random();
            var dateTimeNow = DateTime.Now;

            return dateTimeNow.AddMinutes(random.Next(-10, 0));
        }

        /// <summary>
        /// Сгенерировать рандомную контрольную дату продажи
        /// </summary>
        /// <returns></returns>
        public static DateTime GetRandomSaleDeadline()
        {
            Random random = new Random();
            var dateTimeNow = DateTime.Now;

            return dateTimeNow.AddMinutes(random.Next(0, 200));
        }
    }
}
