namespace DesignPattern.FactoryPattern.Factory
{
    public interface IInvoiceDataFactory
    {
        public DateTime GenerateTireProviderInvoiceDate(string TireProvider, int? year = null, int? month = null);
    }
}
