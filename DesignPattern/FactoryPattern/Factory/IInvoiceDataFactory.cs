using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern.Factory
{
    public interface IInvoiceDataFactory
    {
        public DateTime GenerateTireProviderInvoiceDate(string TireProvider, int? year = null, int? month = null);
    }
}
