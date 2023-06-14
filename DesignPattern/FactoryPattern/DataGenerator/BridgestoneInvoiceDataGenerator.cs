using DesignPattern.Factory.Business;
using DesignPattern.FactoryPattern.DataGenerator.Interface;
using DesignPattern.Models.Enums;

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
        /// <summary>
        /// 普利司通發票單號
        /// </summary>
        /// <param name="No"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public string GenerateInvoiceNo(int No, int? year, int? month)
        {
            year ??= DateTime.UtcNow.Year;
            month ??= DateTime.UtcNow.Month;
            return $"B{year}{month.ToString().PadLeft(2, '0')}{No.ToString().PadLeft(6, '0')}";
        }
    }
}