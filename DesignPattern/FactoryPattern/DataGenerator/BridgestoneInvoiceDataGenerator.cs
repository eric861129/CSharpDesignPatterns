using DesignPattern.Factory.Business;
using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.Service;

namespace DesignPattern.FactoryPattern.DataGenerator
{
    /// <summary>
    /// 普利司通發票資料生成器
    /// </summary>
    public class BridgestoneInvoiceDataGenerator : IInvoiceDataGenerator
    {
        /// <summary>
        /// 普利司通發票日期
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public DateTime GenerateInvoiceDate(int? year, int? month)
        {
            var Day = TireProvider.Bridgestone.TireProviderInvoiceDay();
            return InvoiceBusiness.GetDateTime(Day, year, month);
        }
    }
}