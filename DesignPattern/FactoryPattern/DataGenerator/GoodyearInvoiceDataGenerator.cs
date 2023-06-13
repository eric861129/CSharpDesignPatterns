using DesignPattern.Factory.Business;
using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.Service;

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
    }
}