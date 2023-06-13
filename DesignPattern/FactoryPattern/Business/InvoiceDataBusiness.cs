using DesignPattern.Factory.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Business
{
    public static class InvoiceBusiness
    {
        /// <summary>
        /// 取得對應供應商日 DAY
        /// </summary>
        /// <returns></returns>
        public static int TireProviderInvoiceDay(this TireProvider TireProvider)
        {
            var InvoiceProviderDay = new Dictionary<TireProvider, int>
            {
                { TireProvider.Michelin, 6 },
                { TireProvider.MAXXIS, 7 },
                { TireProvider.Bridgestone, 15 },
                { TireProvider.Goodyear, 20 },
            };
            return InvoiceProviderDay.GetValueOrDefault(TireProvider);
        }
        /// <summary>
        /// 日期
        /// </summary>
        /// <param name="Day"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static DateTime GetDateTime(int Day, int? year, int? month)
        {
            return new DateTime(year ?? DateTime.Today.Year, month ?? DateTime.Today.Month, Day);
        }
    }
}
