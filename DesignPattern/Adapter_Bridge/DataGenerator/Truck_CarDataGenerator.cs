namespace DesignPattern.Adapter_Bridge.DataGenerator
{
    public class Truck_CarDataGenerator : ICarDataGenerator
    {
        public int GetCarNumOfSeat()
        {
            return 2;
        }

        public int GetCarNumOfTire()
        {
            return 6;
        }
    }
}