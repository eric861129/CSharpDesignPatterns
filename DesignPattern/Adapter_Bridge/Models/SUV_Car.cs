using DesignPattern.Adapter_Bridge.Factory;
using DesignPattern.Models.Car;
using DesignPattern.Models.Enums;

namespace DesignPattern.Adapter_Bridge.Models
{
    public class SUV_Car : Car
    {
        private readonly CarType _carType;
        public SUV_Car(CarType carType, ICarDataFactory carDataFactory) : base(carDataFactory)
        {
            this._carType = carType;
        }
        public override void SetCarInfo()
        {
            this.NumOfSeat = _carDataFactory.GetCarNumOfSeat(_carType);
            this.NumOfTire = _carDataFactory.GetCarNumOfTire(_carType);
        }
    }
}
