namespace DesignPattern.Adapter_Bridge.DataGenerator
{
    public class ConstructionVehicle_CarDataGenerator : ICarDataGenerator
    {

        /// <summary>
        /// 工程車座位數
        /// </summary>
        /// <returns></returns>
        public int GetCarNumOfSeat()
        {
            return 1;
        }
        /// <summary>
        /// 工程車輪胎數
        /// </summary>
        /// <returns></returns>
        public int GetCarNumOfTire()
        {
            return 8;
        }
    }
}