using DesignPattern.FactoryPattern.DataGenerator;
using DesignPattern.FactoryPattern.DataGenerator.Interface;
using DesignPattern.FactoryPattern.Factory;
using DesignPattern.Models.Enums;
using DesignPattern.Models.Invoice;
namespace DesignPattern.Factory.Service
{


    #region InvoiceDateFactory

    public class InvoiceDataFactory : IInvoiceDataFactory
    {
        /// <summary>
        /// 產生完整發票資料檔
        /// </summary>
        /// <param name="TireProvider"></param>
        /// <param name="No"></param>
        /// <param name="Year"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        public InvoiceData GenInvoiceData(InvoiceInfo InvoiceInfo)
        {
            var invoiceDateGenerator = GetInvoiceDateGenerator(InvoiceInfo.TireProvider);
            var result = new InvoiceData
            {
                TireProvider = InvoiceInfo.TireProvider,
                InvoiceDate = invoiceDateGenerator.GenerateInvoiceDate(InvoiceInfo.Year, InvoiceInfo.Month),
                InvoiceNo = invoiceDateGenerator.GenerateInvoiceNo(InvoiceInfo)
            };
            return result;
        }

        /// <summary>
        /// 依據供應商和年份、月份生成發票日期
        /// </summary>
        /// <param name="TireProvider">供應商名稱</param>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <returns>生成的發票日期</returns>
        public DateTime GenerateTireProviderInvoiceDate(InvoiceInfo InvoiceInfo)
        {
            var invoiceDateGenerator = GetInvoiceDateGenerator(InvoiceInfo.TireProvider);
            return invoiceDateGenerator.GenerateInvoiceDate(InvoiceInfo.Year, InvoiceInfo.Month);
        }

        /// <summary>
        /// 根據供應商獲取對應的InvoiceData生成器
        /// </summary>
        /// <param name="provider">供應商</param>
        /// <returns>對應的發票日期生成器</returns>
        private static IInvoiceDataGenerator GetInvoiceDateGenerator(TireProvider provider)
        {
            return provider switch
            {
                TireProvider.Michelin => new MichelinInvoiceDataGenerator(),
                TireProvider.MAXXIS => new MaxxisInvoiceDataGenerator(),
                TireProvider.Bridgestone => new BridgestoneInvoiceDataGenerator(),
                TireProvider.Goodyear => new GoodyearInvoiceDataGenerator(),
                TireProvider.ChengShin => new ChengShinInvoiceDataGenerator(),
                _ => new DefaultInvoiceDataGenerator()
            };
        }
    }

    #endregion InvoiceDateFactory

}