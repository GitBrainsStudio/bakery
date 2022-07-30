import { BunType } from "../enums/bun-type.enum";

/**
 * Булочка
 */
export interface Bun {

    /**
     * Идентификатор
     */
    id: string;

    /**
     * Дата выпечки
     */
    bakingDate: string;

    /**
     * Тип
     */
    type: BunType;

    /**
     * Количество часов, в течение которых булочка должна быть продана
     */
    hoursCountForSale: number;

    /**
     * Контрольный срок продажи
     */
    saleDeadline: string;

    /**
     * Стартовая стоимость
     */
    beginPrice: number;

    /**
     * Текущая стоимость
     */
    currentPrice: number;

    /**
     * Сколько прошло часов после выпечки
     */
    elapsedHoursAfterBaking:number;

    /**
     * Просрочена ли булочка
     */
    isOverdue:boolean;

    /**
     * Следующее время смены текущей стоимости
     */
    timeToChangeCurrentPrice:string;

    /**
     * Сумма уменьшения текущий стоимости за один час
     */
    amountOfReductionPerHour:string;

    /**
     * Следующая стоимость
     */
    nextCurrentPrice:string;
}