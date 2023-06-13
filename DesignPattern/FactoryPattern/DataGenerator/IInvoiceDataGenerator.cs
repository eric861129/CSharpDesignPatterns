using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Interfaces
{ 
    /// <summary>
    /// 生產器介面
    /// </summary>
    public interface IInvoiceDataGenerator
    {
        public DateTime GenerateInvoiceDate(int? year, int? month);
    }
}
