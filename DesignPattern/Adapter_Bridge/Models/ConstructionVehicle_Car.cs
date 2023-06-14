using DesignPattern.Adapter_Bridge.Factory;
using DesignPattern.Models.Car;
using DesignPattern.Models.Enums;

namespace DesignPattern.Adapter_Bridge.Models
{
    public class ConstructionVehicle_Car : Car
    {
        private readonly CarType _carType;
        private readonly ConstructionVehicleDataFactory _carDataFactory;
        private readonly ConstructionVehicleTool ConstructionVehicleTool;
        public ConstructionVehicle_Car(ConstructionVehicleDataFactory carDataFactory, CarType carType, ConstructionVehicleTool constructionVehicleTool) : base(carDataFactory)
        {
            this._carType = carType;
            this._carDataFactory = carDataFactory;
            this.ConstructionVehicleTool = constructionVehicleTool;
        }

        public int ToolWeightLimit { get; set; }

        public override void SetCarInfo()
        {
            this.NumOfSeat = _carDataFactory.GetCarNumOfSeat(CarType.ConstructionVehicle);
            this.NumOfTire = _carDataFactory.GetCarNumOfTire(CarType.ConstructionVehicle);
            this.ToolWeightLimit = _carDataFactory.GetToolWeightLimit(ConstructionVehicleTool.ToolSize);
        }
    }
}
