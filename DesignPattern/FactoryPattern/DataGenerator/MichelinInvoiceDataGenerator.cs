using DesignPattern.Factory.Business;
using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.Service;
using DesignPattern.FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern.DataGenerator
{
    /// <summary>
    /// 米其林發票資料生成器
    /// </summary>
    public class MichelinInvoiceDataGenerator : IInvoiceDataGenerator
    {
        /// <summary>
        /// 米其林發票日期
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public DateTime GenerateInvoiceDate(int? year, int? month)
        {
            var Day = TireProvider.Michelin.TireProviderInvoiceDay();
            return InvoiceBusiness.GetDateTime(Day, year, month);
        }
    }
}
