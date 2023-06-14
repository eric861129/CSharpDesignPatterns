using DesignPattern.Models.Enums;

namespace DesignPattern.Models.Invoice
{
    /// <summary>
    /// 發票資料
    /// </summary>
    public class InvoiceData
    {
        /// <summary>
        /// 供應商
        /// </summary>
        public TireProvider TireProvider { get; set; }
        /// <summary>
        /// 發票日期
        /// </summary>
        public DateTime InvoiceDate { get; set; }
        /// <summary>
        /// 發票單號
        /// </summary>
        public required string InvoiceNo { get; set; }
    }
}
