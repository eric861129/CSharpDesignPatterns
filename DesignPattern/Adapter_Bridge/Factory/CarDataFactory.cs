using DesignPattern.Adapter_Bridge.DataGenerator;
using DesignPattern.Models.Enums;

namespace DesignPattern.Adapter_Bridge.Factory
{
    public class CarDataFactory : ICarDataFactory
    {
        public int GetCarNumOfSeat(CarType carType)
        {
            var CarDataGenerator = GetCarDataGenerator(carType);
            return CarDataGenerator.GetCarNumOfSeat();
        }

        public int GetCarNumOfTire(CarType carType)
        {
            var CarDataGenerator = GetCarDataGenerator(carType);
            return CarDataGenerator.GetCarNumOfTire();
        }
        private ICarDataGenerator GetCarDataGenerator(CarType carType)
        {
            switch (carType)
            {
                case CarType.SUV:
                    return new SUV_CarDataGenerator();
                case CarType.CUV:
                    return new CUV_CarDataGenerator();
                case CarType.RV:
                    return new RV_CarDataGenerator();
                case CarType.Truck:
                    return new Truck_CarDataGenerator();
                case CarType.ConstructionVehicle:
                    return new ConstructionVehicle_CarDataGenerator();
                default:
                    throw new Exception("CarType not found");

            }
        }
    }
}
