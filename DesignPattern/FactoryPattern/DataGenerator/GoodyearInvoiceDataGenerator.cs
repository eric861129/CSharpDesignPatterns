using DesignPattern.Factory.Business;
using DesignPattern.FactoryPattern.DataGenerator.Interface;
using DesignPattern.Models.Enums;
using DesignPattern.Models.Invoice;

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
        public string GenerateInvoiceNo(InvoiceInfo InvoiceInfo)
        {
            InvoiceInfo.Year ??= DateTime.UtcNow.Year;
            InvoiceInfo.Month ??= DateTime.UtcNow.Month;
            return $"GY{InvoiceInfo.Year}{InvoiceInfo.Month.ToString().PadLeft(2, '0')}{InvoiceInfo.No.ToString().PadLeft(6, '0')}";
        }
    }
}