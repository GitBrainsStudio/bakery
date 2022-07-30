using BAKERY.Domain.Entites;
using BAKERY.Domain.Enums;

namespace BAKERY.Application.Dtos.Responses
{
    /// <summary>
    /// Объект передачи данных: Булочка
    /// </summary>
    public class BunDto
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
        public int HoursCountForSale { get; set; }

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
        public double CurrentPrice { get; set; }

        /// <summary>
        /// Сколько прошло часов после выпечки
        /// </summary>
        public int ElapsedHoursAfterBaking { get; set; }

        /// <summary>
        /// Просрочена ли булочка
        /// </summary>
        public bool IsOverdue { get; set; }

        /// <summary>
        /// Следующее время смены текущей стоимости
        /// </summary>
        public DateTime TimeToChangeCurrentPrice { get; set; }

        /// <summary>
        /// Сумма уменьшения текущий стоимости за один час
        /// </summary>
        public double AmountOfReductionPerHour { get; set; }

        /// <summary>
        /// Следующая стоимость
        /// </summary>
        public double NextCurrentPrice { get; set; }

        public BunDto(
            Bun bun)
        {
            Id = bun.Id;
            BakingDate = bun.BakingDate;
            Type = bun.Type;
            HoursCountForSale = bun.HoursCountForSale;
            SaleDeadline = bun.SaleDeadline;
            BeginPrice = Math.Round(bun.BeginPrice, 2);
            CurrentPrice = Math.Round(bun.CurrentPrice, 2);
            ElapsedHoursAfterBaking = bun.ElapsedHoursAfterBaking;
            IsOverdue = bun.IsOverdue;
            TimeToChangeCurrentPrice = bun.TimeToChangeCurrentPrice;
            AmountOfReductionPerHour = Math.Round(bun.AmountOfReductionPerHour, 2);
            NextCurrentPrice = Math.Round(bun.NextCurrentPrice, 2);
        }
    }
}
