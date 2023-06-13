using DesignPattern.Factory.Business;
using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.Service;

namespace DesignPattern.FactoryPattern.DataGenerator
{
    /// <summary>
    /// 馬吉斯發票資料生成器
    /// </summary>
    public class MaxxisInvoiceDataGenerator : IInvoiceDataGenerator
    {
        /// <summary>
        /// 馬吉斯發票日期
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public DateTime GenerateInvoiceDate(int? year, int? month)
        {
            var Day = TireProvider.MAXXIS.TireProviderInvoiceDay();
            return InvoiceBusiness.GetDateTime(Day, year, month);
        }
    }
}