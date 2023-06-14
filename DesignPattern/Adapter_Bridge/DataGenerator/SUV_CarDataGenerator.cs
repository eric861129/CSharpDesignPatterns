namespace DesignPattern.Adapter_Bridge.DataGenerator
{
    /// <summary>
    /// 休旅車資料產生器
    /// </summary>
    public class SUV_CarDataGenerator : ICarDataGenerator
    {
        /// <summary>
        /// 休旅車座位數
        /// </summary>
        /// <returns></returns>
        public int GetCarNumOfSeat()
        {
            return 7;
        }
        /// <summary>
        /// 休旅車輪胎數
        /// </summary>
        /// <returns></returns>
        public int GetCarNumOfTire()
        {
            return 4;
        }
    }
}