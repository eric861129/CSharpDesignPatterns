using DesignPattern.Factory.Business;
using DesignPattern.Factory.Interfaces;

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

        public string GenerateInvoiceNo(int No, int? year, int? month)
        {
            return "ERROR";
        }
    }
}
