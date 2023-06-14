using DesignPattern.Models.Invoice;

namespace DesignPattern.FactoryPattern.DataGenerator.Interface
{
    /// <summary>
    /// 生產器介面
    /// </summary>
    public interface IInvoiceDataGenerator
    {
        public DateTime GenerateInvoiceDate(int? year, int? month);
        public string GenerateInvoiceNo(InvoiceInfo InvoiceInfo);
    }
}
