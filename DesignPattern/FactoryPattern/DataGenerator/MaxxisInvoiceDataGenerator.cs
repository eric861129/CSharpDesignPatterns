namespace DesignPattern.FactoryPattern.DataGenerator
{
    /// <summary>
    /// 馬吉斯發票資料生成器
    /// </summary>
    public class MaxxisInvoiceDataGenerator : ChengShinInvoiceDataGenerator
    {
        /// <summary>
        /// 馬吉斯發票單號
        /// </summary>
        /// <param name="No"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public new string GenerateInvoiceNo(int No, int? year, int? month)
        {
            year ??= DateTime.UtcNow.Year;
            month ??= DateTime.UtcNow.Month;
            return $"MX{year}{month.ToString().PadLeft(2, '0')}{No.ToString().PadLeft(6, '0')}";
        }
    }
}