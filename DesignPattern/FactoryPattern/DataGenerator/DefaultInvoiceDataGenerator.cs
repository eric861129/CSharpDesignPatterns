using DesignPattern.Factory.Business;
using DesignPattern.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern.DataGenerator
{
    /// <summary>
    /// 例外預設
    /// </summary>
    public class DefaultInvoiceDataGenerator : IInvoiceDataGenerator
    {
        public DateTime GenerateInvoiceDate(int? year, int? month)
        {
            return InvoiceBusiness.GetDateTime(1, year, month);
        }
    }
}
