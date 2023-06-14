using DesignPattern.Factory.Business;
using DesignPattern.FactoryPattern.DataGenerator.Interface;
using DesignPattern.Models.Enums;

namespace DesignPattern.FactoryPattern.DataGenerator
{
    /// <summary>
    /// 正新發票資料生成器
    /// </summary>
    public class ChengShinInvoiceDataGenerator : IInvoiceDataGenerator
    {
        /// <summary>
        /// 正新發票日期
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public DateTime GenerateInvoiceDate(int? year, int? month)
        {
            var Day = TireProvider.ChengShin.TireProviderInvoiceDay();
            return InvoiceBusiness.GetDateTime(Day, year, month);
        }
        /// <summary>
        /// 正新發票單號
        /// </summary>
        /// <param name="No"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public string GenerateInvoiceNo(int No, int? year, int? month)
        {
            year ??= DateTime.UtcNow.Year;
            month ??= DateTime.UtcNow.Month;
            return $"CS{year}{month.ToString().PadLeft(2, '0')}{No.ToString().PadLeft(6, '0')}";
        }
    }
}