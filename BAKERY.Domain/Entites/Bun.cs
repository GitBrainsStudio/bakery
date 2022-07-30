using BAKERY.Domain.Contracts;
using BAKERY.Domain.Enums;
using BAKERY.Domain.Helpers;

namespace BAKERY.Domain.Entites
{
    /// <summary>
    /// Доменная сущность: Булочка
    /// </summary>
    public class Bun : IEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Дата выпечки
        /// </summary>
        public DateTime BakingDate { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public BunType Type { get; set; }

        /// <summary>
        /// Количество часов, в течение
        /// которых булочка должна быть продана
        /// </summary>
        public int HoursCountForSale {get;set;}

        /// <summary>
        /// Контрольный срок продажи
        /// </summary>
        public DateTime SaleDeadline { get; set; }
        
        /// <summary>
        /// Стартовая стоимость
        /// </summary>
        public double BeginPrice { get; set; }

        /// <summary>
        /// Текущая стоимость
        /// </summary>
        public double CurrentPrice
            => BunCurrentPriceCalculator.Calculate(this);

        /// <summary>
        /// Сколько прошло часов после выпечки
        /// </summary>
        public int ElapsedHoursAfterBaking =>
            (int)(DateTime.Now - BakingDate).TotalHours;

        /// <summary>
        /// Просрочена ли булочка
        /// </summary>
        public bool IsOverdue =>
            ElapsedHoursAfterBaking < HoursCountForSale ? false : true;

        /// <summary>
        /// Следующее время смены текущей стоимости
        /// </summary>
        public DateTime TimeToChangeCurrentPrice 
            => BakingDate.AddHours(ElapsedHoursAfterBaking + 1);

        /// <summary>
        /// Сумма уменьшения текущий стоимости за один час
        /// </summary>
        public double AmountOfReductionPerHour =>
            BeginPrice / 100 * 2;

        /// <summary>
        /// Следующая стоимость
        /// </summary>
        public double NextCurrentPrice
            => BunNextCurrentPriceCalculator.Calculate(this);

        /// <summary>
        /// Испечь новую булочку
        /// </summary>
        /// <param name="type"></param>
        /// <param name="hoursCountForSale"></param>
        /// <param name="saleDeadline"></param>
        /// <param name="beginPrice"></param>
        public Bun(
            BunType type,
            int hoursCountForSale,
            DateTime saleDeadline,
            double beginPrice
            )
        {
            Id = Guid.NewGuid();
            BakingDate = DateTime.Now;
            Type = type;
            HoursCountForSale = hoursCountForSale;
            SaleDeadline = saleDeadline;
            BeginPrice = beginPrice;
        }

        protected Bun()
        {

        }
    }
}
