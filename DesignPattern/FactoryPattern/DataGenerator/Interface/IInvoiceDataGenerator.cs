namespace DesignPattern.FactoryPattern.DataGenerator.Interface
{
    /// <summary>
    /// 生產器介面
    /// </summary>
    public interface IInvoiceDataGenerator
    {
        public DateTime GenerateInvoiceDate(int? year, int? month);
        public string GenerateInvoiceNo(int No, int? year, int? month);
    }
}
