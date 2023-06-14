﻿using DesignPattern.Factory.Business;
using DesignPattern.FactoryPattern.DataGenerator.Interface;
using DesignPattern.Models.Enums;
using DesignPattern.Models.Invoice;

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
        /// <summary>
        /// 米其林發票單號
        /// </summary>
        /// <param name="No"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public string GenerateInvoiceNo(InvoiceInfo InvoiceInfo)
        {
            InvoiceInfo.Year ??= DateTime.UtcNow.Year;
            InvoiceInfo.Month ??= DateTime.UtcNow.Month;
            return $"M{InvoiceInfo.Year}{InvoiceInfo.Month.ToString().PadLeft(2, '0')}{InvoiceInfo.No.ToString().PadLeft(6, '0')}";
        }
    }
}
