using System.ComponentModel.DataAnnotations;
using DesignPattern.Factory.Business;
using DesignPattern.Factory.Interfaces;
using DesignPattern.FactoryPattern.DataGenerator;
using DesignPattern.FactoryPattern.Factory;
using Extensions;
namespace DesignPattern.Factory.Service
{
    /// <summary>
    /// 輪胎供應商
    /// </summary>
    public enum TireProvider
    {
        /// <summary>
        /// 米其林輪胎
        /// </summary>
        [Display(Name = "米其林")]
        Michelin = 1,
        /// <summary>
        /// 馬吉斯輪胎
        /// </summary>
        [Display(Name = "馬吉斯")]
        MAXXIS = 2,
        /// <summary>
        /// 普利司通輪胎
        /// </summary>
        [Display(Name = "普利司通")]
        Bridgestone = 3,
        /// <summary>
        /// 固特異輪胎
        /// </summary>
        [Display(Name = "固特異")]
        Goodyear = 4,
    }

    #region InvoiceDateFactory

    public class InvoiceDataFactory : IInvoiceDataFactory
    {
        /// <summary>
        /// 依據供應商和年份、月份生成發票日期
        /// </summary>
        /// <param name="TireProvider">供應商名稱</param>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <returns>生成的發票日期</returns>
        public DateTime GenerateTireProviderInvoiceDate(string TireProvider, int? year = null, int? month = null)
        {
            var provider = TireProvider.ToEnum<TireProvider>();
            var invoiceDateGenerator = GetInvoiceDateGenerator(provider);
            return invoiceDateGenerator.GenerateInvoiceDate(year, month);
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
                _ => new DefaultInvoiceDataGenerator()
            };
        }
    }

    #endregion InvoiceDateFactory

}