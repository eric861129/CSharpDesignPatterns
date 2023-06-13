using System.ComponentModel.DataAnnotations;

namespace DesignPattern.FactoryPattern.Enum
{
    /// <summary>
    /// 輪胎供應商
    /// </summary>
    public enum TireProvider
    {
        /// <summary>
        /// 米其林輪胎
        /// </summary>
        [Display(Name = "米其林")]
        Michelin = 1,
        /// <summary>
        /// 馬吉斯輪胎
        /// </summary>
        [Display(Name = "馬吉斯")]
        MAXXIS = 2,
        /// <summary>
        /// 普利司通輪胎
        /// </summary>
        [Display(Name = "普利司通")]
        Bridgestone = 3,
        /// <summary>
        /// 固特異輪胎
        /// </summary>
        [Display(Name = "固特異")]
        Goodyear = 4,
        /// <summary>
        /// 正新輪胎
        /// </summary>
        [Display(Name = "正新輪胎")]
        ChengShin = 5,
    }
}
