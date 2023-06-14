using DesignPattern.Adapter_Bridge.Factory;
using DesignPattern.Models.Car;
using DesignPattern.Models.Enums;

namespace DesignPattern.Adapter_Bridge.Models
{
    public class ConstructionVehicle_Car : Car
    {
        public ConstructionVehicleTool _ConstructionVehicleTool;
        public ConstructionVehicleDataFactory _ConstructionVehicleDataFactory;
        public ConstructionVehicle_Car(ICarDataFactory carDataFactory, CarType CarType, ConstructionVehicleTool constructionVehicleTool, ConstructionVehicleDataFactory constructionVehicleDataFactory) : base(carDataFactory, CarType)
        {
            _ConstructionVehicleTool = constructionVehicleTool;
            this._ConstructionVehicleDataFactory = constructionVehicleDataFactory;
        }

        public int ToolWeightLimit { get; set; }

        public override void SetCarInfo()
        {
            this.NumOfSeat = _carDataFactory.GetCarNumOfSeat(CarType.ConstructionVehicle);
            this.NumOfTire = _carDataFactory.GetCarNumOfTire(CarType.ConstructionVehicle);
            this.ToolWeightLimit = _ConstructionVehicleDataFactory.GetToolWeightLimit(_ConstructionVehicleTool.ToolSize);
        }
    }
}
