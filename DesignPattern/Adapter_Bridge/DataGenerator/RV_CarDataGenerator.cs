namespace DesignPattern.Adapter_Bridge.DataGenerator
{
    public class RV_CarDataGenerator : ICarDataGenerator
    {
        public int GetCarNumOfSeat()
        {
            return 4;
        }

        public int GetCarNumOfTire()
        {
            return 4;
        }
    }
}