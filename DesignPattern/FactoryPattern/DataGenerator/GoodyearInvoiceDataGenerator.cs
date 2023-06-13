using DesignPattern.Factory.Business;
using DesignPattern.Factory.Interfaces;
using DesignPattern.FactoryPattern.Enum;

namespace DesignPattern.FactoryPattern.DataGenerator
{
    /// <summary>
    /// 固特異發票資料生成器
    /// </summary>
    public class GoodyearInvoiceDataGenerator : IInvoiceDataGenerator
    {
        /// <summary>
        /// 固特異發票日期
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public DateTime GenerateInvoiceDate(int? year, int? month)
        {
            var Day = TireProvider.Goodyear.TireProviderInvoiceDay();
            month = DateTime.UtcNow.Month;
            if (month > 6)
                Day = 25;
            return InvoiceBusiness.GetDateTime(Day, year, month);
        }
        /// <summary>
        /// 固特異發票單號
        /// </summary>
        /// <param name="No"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public string GenerateInvoiceNo(int No, int? year, int? month)
        {
            return $"GY{year}{month.ToString().PadLeft(2, '0')}{No.ToString().PadLeft(4, '0')}";
        }
    }
}