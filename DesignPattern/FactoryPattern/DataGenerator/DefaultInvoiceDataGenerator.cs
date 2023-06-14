using DesignPattern.Factory.Business;
using DesignPattern.FactoryPattern.DataGenerator.Interface;
using DesignPattern.Models.Invoice;

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

        public string GenerateInvoiceNo(InvoiceInfo InvoiceInfo)
        {
            return "ERROR";

        }
    }
}
