namespace DesignPattern.Adapter_Bridge.DataGenerator
{
    public interface ICarDataGenerator
    {
        /// <summary>
        /// 取得車類型座位數
        /// </summary>
        /// <returns></returns>
        public int GetCarNumOfSeat();
        /// <summary>
        /// 取得車類型輪胎數
        /// </summary>
        /// <returns></returns>
        public int GetCarNumOfTire();
    }
}
