using DesignPattern.Models.Invoice;

namespace DesignPattern.FactoryPattern.Factory
{
    public interface IInvoiceDataFactory
    {
        /// <summary>
        /// 產生完整發票資料檔
        /// </summary>
        /// <param name="TireProvider"></param>
        /// <param name="No"></param>
        /// <param name="Year"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        public InvoiceData GenInvoiceData(InvoiceInfo InvoiceInfo);
        /// <summary>
        /// 依據供應商和年份、月份生成發票日期
        /// </summary>
        /// <param name="TireProvider">供應商名稱</param>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <returns>生成的發票日期</returns>
        public DateTime GenerateTireProviderInvoiceDate(InvoiceInfo InvoiceInfo);
    }
}
