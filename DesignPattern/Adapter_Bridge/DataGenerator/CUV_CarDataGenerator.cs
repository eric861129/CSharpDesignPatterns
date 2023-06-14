namespace DesignPattern.Adapter_Bridge.DataGenerator
{
    /// <summary>
    /// 跨界休旅車資料產生器
    /// </summary>
    public class CUV_CarDataGenerator : ICarDataGenerator
    {
        /// <summary>
        /// 跨界休旅車座位數
        /// </summary>
        /// <returns></returns>
        public int GetCarNumOfSeat()
        {
            return 5;
        }
        /// <summary>
        /// 跨界休旅車輪胎數
        /// </summary>
        /// <returns></returns>
        public int GetCarNumOfTire()
        {
            return 4;
        }
    }
}