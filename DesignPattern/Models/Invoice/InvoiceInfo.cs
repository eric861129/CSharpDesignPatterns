using DesignPattern.Models.Enums;

namespace DesignPattern.Models.Invoice
{
    public class InvoiceInfo
    {
        /// <summary>
        /// 供應商
        /// </summary>
        public TireProvider TireProvider { get; set; }
        /// <summary>
        /// 發票年份
        /// </summary>
        public int? Year { get; set; }
        /// <summary>
        /// 發票月份
        /// </summary>
        public int? Month { get; set; }
        /// <summary>
        /// 編號
        /// </summary>
        public int? No { get; set; }
        /// <summary>
        /// 產品別
        /// </summary>
        public TireType? ProductType { get; set; }
    }
}
