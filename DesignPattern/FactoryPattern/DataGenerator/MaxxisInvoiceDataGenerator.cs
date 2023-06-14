using DesignPattern.Models.Invoice;

namespace DesignPattern.FactoryPattern.DataGenerator
{
    /// <summary>
    /// 馬吉斯發票資料生成器
    /// </summary>
    public class MaxxisInvoiceDataGenerator : ChengShinInvoiceDataGenerator
    {
        /// <summary>
        /// 馬吉斯發票單號
        /// </summary>
        /// <param name="No"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static new string GenerateInvoiceNo(InvoiceInfo InvoiceInfo)
        {
            InvoiceInfo.Year ??= DateTime.UtcNow.Year;
            InvoiceInfo.Month ??= DateTime.UtcNow.Month;
            return $"MX{InvoiceInfo.Year}{InvoiceInfo.Month.ToString().PadLeft(2, '0')}{InvoiceInfo.No.ToString().PadLeft(6, '0')}";
        }
    }
}